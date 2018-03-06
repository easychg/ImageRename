using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace IRNM
{
    public partial class Form1 : Form
    {
        List<string> listExtention = new List<string>();
        public Form1()
        {
            InitializeComponent();
            Form.CheckForIllegalCrossThreadCalls = false;
            listExtention.AddRange(new string[] { ".jpg", ".gif", ".png", ".bmp", ".jpeg" });
            txt_start.Enabled = false;
            txt_startnum.Enabled = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            Application.ExitThread();
        }
        #region 在新线程中运行函数
        /// <summary>
        /// 在新线程中运行函数
        /// </summary>
        /// <param name="func">传入 函数名(无参、无返回值)</param>
        /// <param name="IsBackground">是否为后台线程(后台线程，窗口关闭后就终止线程)</param>
        public static void ThreadNew(VoidFunction func, bool IsBackground)
        {
            Thread th1 = new Thread(new ThreadStart(func));
            th1.IsBackground = IsBackground;//后台线程，窗口关闭后就终止线程
            th1.Start();
        }
        /// <summary>
        /// 在新线程中运行函数
        /// </summary>
        /// <param name="func">传入 函数名(有一个参数、无返回值)</param>
        /// <param name="para">object参数</param>
        /// <param name="IsBackground">是否为后台线程(后台线程，窗口关闭后就终止线程)</param>
        public static Thread ThreadNew(ParamFunction func, object para, bool IsBackground)
        {
            Thread th1 = new Thread(new ParameterizedThreadStart(func));
            //判断状态
            //((int)th1.ThreadState &((int)ThreadState.Running | (int)ThreadState.Suspended) ) == 0
            th1.IsBackground = IsBackground;
            th1.Start(para);
            return th1;
        }
        /// <summary>
        /// 允许线程之间进行操作
        /// </summary>
        public static void OprateBetweenThread()
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        /// <summary>
        /// 无参的、返回值为void的委托，可以用来做参数名
        /// </summary>
        public delegate void VoidFunction();

        /// <summary>
        /// 有一个参数的、返回值为void的委托，可以用来做参数名
        /// </summary>
        public delegate void ParamFunction(object para);


        #endregion

        private void lb_selectDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtDir.Text = fbd.SelectedPath;
            }
        }

       
        int success = 0; //成功
        int falure = 0; //失败
        int total = 0;
        
        private void MakeWaterMark()
        {
            success = 0;
            falure = 0;
            total = 0;
            string errmsg = "";
            string strtxtDir = txtDir.Text.Trim();
            if (strtxtDir == "")
            {
                MessageBox.Show("请选择目录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else if (Directory.Exists(strtxtDir) == false)
            {
                MessageBox.Show("文件夹不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else
            {
                if (rad_user.Checked == true)
                {
                    if (txt_start.Text == "" || txt_startnum.Text == "")
                    {
                        MessageBox.Show("自定义输入框不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }
                btnExec.Enabled = false;
                List<string> PictureList = new List<string>();
                lb_statusInfo.Text = "状态：正在检索图片…";
                SearchFile(txtDir.Text.Trim(), ref PictureList);
                int len = 0;
                int start = 0;
                string ss = txt_start.Text;
                if (rad_user.Checked == true) {
                    int count = PictureList.Count + Convert.ToInt32(txt_startnum.Text);
                    len = count.ToString().Length;
                    start = Convert.ToInt32(txt_startnum.Text);
                }
                
                string ext = ".jpg";
                if (rad_bmp.Checked == true) {
                    ext = ".bmp";
                }
                else if (rad_gif.Checked == true) {
                    ext = ".gif";
                }
                else if (rad_png.Checked == true)
                {
                    ext = ".png";
                }
                else if (rad_bmp.Checked == true)
                {
                    ext = ".bmp";
                }
                string name = "";
                foreach (string s in PictureList)
                {
                    try
                    {
                        if (rad_guid.Checked == true)
                        {
                            name = Guid.NewGuid().ToString() + ext;
                        }
                        else if (rad_time.Checked == true)
                        {
                            name = GetTimestamp() + ext;
                        }
                        else if (rad_ymdhmsf.Checked == true)
                        {
                            name = DateTime.Now.ToString("yyyyMMddHHmmssfff") + ext;
                        }
                        else if (rad_user.Checked == true)
                        {
                            string left = "";
                            for (int i = (success + start).ToString().Length; i < len; i++)
                            {
                                left += "0";
                            }
                            name = ss + left + (success + start) + ext;
                        }
                        else if (rab_history.Checked == true) {
                            name = "";
                        }
                        MakeWaterPic(s, ext, "", name);
                        success++;
                    }
                    catch (Exception er)
                    {
                        falure++;
                        errmsg += er.Message;
                    }
                    total++;
                    lb_statusInfo.Text = "状态：正在为第" + (total + 1) + "张图片加水印…";
                }
                lb_statusInfo.Text = "状态：完成！共" + total + ",成功" + success + ",失败" + falure;
                btnExec.Enabled = true;
                if (errmsg != "") MessageBox.Show(errmsg, "执行完成，部分文件出错信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void SearchFile(string parentDir, ref List<string> PictureList)
        {
            try
            {
                string[] subFiles = Directory.GetFiles(parentDir);
                string[] subDirs = Directory.GetDirectories(parentDir, "*.*", SearchOption.TopDirectoryOnly);
                PictureList.AddRange(subFiles);
                foreach (string dir in subDirs)
                {
                    SearchFile(dir, ref PictureList);
                }
            }
            catch (Exception ex) { }
        }


        private string MakeWaterPic(string SourcePicPath, string WaterText, string WaterPath, string SaveName)
        {
            if (File.Exists(SourcePicPath) == false)
            {
                return "-1";//文件不存在
            }

            string extension = Path.GetExtension(SourcePicPath).ToLower();//后缀
            //if (listExtention.Contains(extension) == false) throw new Exception("不允许的后缀:" + SourcePicPath + "\n");
            string fileName = SaveName;


            System.Drawing.Image image = System.Drawing.Image.FromFile(SourcePicPath, true);
            int imgwidth = image.Width;
            int imgheight = image.Height;
            using (System.Drawing.Bitmap bitmap = new Bitmap(image.Width, image.Height))
            {

                using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bitmap))//
                {
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    g.Clear(System.Drawing.Color.Transparent);
                    g.DrawImage(image, 0, 0, imgwidth, imgheight);//画上原图片
                    image.Dispose();
                    if (File.Exists(SourcePicPath))
                    {
                        File.Delete(SourcePicPath);
                    }
                    //保存加水印过后的图片,删除原始图片
                    // string newPath = fileName + extension;
                    extension = WaterText;
                    if (SaveName != "")
                    {
                        SourcePicPath = Path.GetDirectoryName(SourcePicPath) + "\\" + SaveName;
                    }
                    else {
                        SourcePicPath = Path.GetDirectoryName(SourcePicPath) + "\\" + Path.GetFileNameWithoutExtension(SourcePicPath) + extension;
                    }
                    switch (extension)
                    {
                        case ".jpg":
                            bitmap.Save(SourcePicPath, System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;
                        case ".gif":
                            bitmap.Save(SourcePicPath, System.Drawing.Imaging.ImageFormat.Gif);
                            break;
                        case ".png":
                            bitmap.Save(SourcePicPath, System.Drawing.Imaging.ImageFormat.Png);
                            break;
                        case ".jpeg":
                            bitmap.Save(SourcePicPath, System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;
                        case ".bmp":
                            bitmap.Save(SourcePicPath, System.Drawing.Imaging.ImageFormat.Bmp);
                            break;
                        default:
                            throw new Exception("不允许的后缀:" + SourcePicPath);
                    }
                    
                }
            }

            return "1";
            // Response.Redirect(newPath);
            //}
        }
        public string GetTimestamp()
        {
            TimeSpan ts = DateTime.Now - new DateTime(1970, 1, 1);
            return ts.TotalMilliseconds.ToString();
        }
        private void btnExec_Click(object sender, EventArgs e)
        {
            ThreadNew(MakeWaterMark, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //txtDir.Text = ConfigFile.Instanse["txtDir"];
            //txtMark.Text = ConfigFile.Instanse["txtMark"];
        }

        private void rad_user_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_user.Checked == true)
            {
                txt_start.Enabled = true;
                txt_startnum.Enabled = true;
            }
            else {
                txt_start.Enabled = false;
                txt_startnum.Enabled = false;
            }
        }
    }
}
