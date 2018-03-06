namespace IRNM
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnExec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_statusInfo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rad_jpg = new System.Windows.Forms.RadioButton();
            this.rad_gif = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rad_png = new System.Windows.Forms.RadioButton();
            this.rad_bmp = new System.Windows.Forms.RadioButton();
            this.rad_ymdhmsf = new System.Windows.Forms.RadioButton();
            this.rad_time = new System.Windows.Forms.RadioButton();
            this.rad_guid = new System.Windows.Forms.RadioButton();
            this.rad_user = new System.Windows.Forms.RadioButton();
            this.txt_start = new System.Windows.Forms.TextBox();
            this.txt_startnum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rab_history = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(466, 439);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(75, 23);
            this.btnExec.TabIndex = 0;
            this.btnExec.Text = "执行";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "文件夹：";
            this.label1.Click += new System.EventHandler(this.lb_selectDir_Click);
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(112, 58);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(429, 21);
            this.txtDir.TabIndex = 2;
            this.txtDir.Click += new System.EventHandler(this.lb_selectDir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "新类型：";
            // 
            // lb_statusInfo
            // 
            this.lb_statusInfo.AutoSize = true;
            this.lb_statusInfo.Location = new System.Drawing.Point(50, 444);
            this.lb_statusInfo.Name = "lb_statusInfo";
            this.lb_statusInfo.Size = new System.Drawing.Size(77, 12);
            this.lb_statusInfo.TabIndex = 4;
            this.lb_statusInfo.Text = "状态：未执行";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rad_bmp);
            this.groupBox2.Controls.Add(this.rad_png);
            this.groupBox2.Controls.Add(this.rad_gif);
            this.groupBox2.Controls.Add(this.rad_jpg);
            this.groupBox2.Location = new System.Drawing.Point(112, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 63);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // rad_jpg
            // 
            this.rad_jpg.AutoSize = true;
            this.rad_jpg.Checked = true;
            this.rad_jpg.Location = new System.Drawing.Point(49, 25);
            this.rad_jpg.Name = "rad_jpg";
            this.rad_jpg.Size = new System.Drawing.Size(41, 16);
            this.rad_jpg.TabIndex = 0;
            this.rad_jpg.TabStop = true;
            this.rad_jpg.Text = "jpg";
            this.rad_jpg.UseVisualStyleBackColor = true;
            // 
            // rad_gif
            // 
            this.rad_gif.AutoSize = true;
            this.rad_gif.Location = new System.Drawing.Point(114, 25);
            this.rad_gif.Name = "rad_gif";
            this.rad_gif.Size = new System.Drawing.Size(41, 16);
            this.rad_gif.TabIndex = 1;
            this.rad_gif.Text = "gif";
            this.rad_gif.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lb_statusInfo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnExec);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 506);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rab_history);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txt_startnum);
            this.groupBox3.Controls.Add(this.txt_start);
            this.groupBox3.Controls.Add(this.rad_user);
            this.groupBox3.Controls.Add(this.rad_guid);
            this.groupBox3.Controls.Add(this.rad_time);
            this.groupBox3.Controls.Add(this.rad_ymdhmsf);
            this.groupBox3.Location = new System.Drawing.Point(112, 221);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(429, 201);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // rad_png
            // 
            this.rad_png.AutoSize = true;
            this.rad_png.Location = new System.Drawing.Point(179, 25);
            this.rad_png.Name = "rad_png";
            this.rad_png.Size = new System.Drawing.Size(41, 16);
            this.rad_png.TabIndex = 2;
            this.rad_png.Text = "png";
            this.rad_png.UseVisualStyleBackColor = true;
            // 
            // rad_bmp
            // 
            this.rad_bmp.AutoSize = true;
            this.rad_bmp.Location = new System.Drawing.Point(244, 25);
            this.rad_bmp.Name = "rad_bmp";
            this.rad_bmp.Size = new System.Drawing.Size(41, 16);
            this.rad_bmp.TabIndex = 3;
            this.rad_bmp.Text = "bmp";
            this.rad_bmp.UseVisualStyleBackColor = true;
            // 
            // rad_ymdhmsf
            // 
            this.rad_ymdhmsf.AutoSize = true;
            this.rad_ymdhmsf.Checked = true;
            this.rad_ymdhmsf.Location = new System.Drawing.Point(47, 31);
            this.rad_ymdhmsf.Name = "rad_ymdhmsf";
            this.rad_ymdhmsf.Size = new System.Drawing.Size(281, 16);
            this.rad_ymdhmsf.TabIndex = 0;
            this.rad_ymdhmsf.TabStop = true;
            this.rad_ymdhmsf.Text = "年月日十分秒毫秒，例：yyyyMMddHHmmssfff.jpg";
            this.rad_ymdhmsf.UseVisualStyleBackColor = true;
            // 
            // rad_time
            // 
            this.rad_time.AutoSize = true;
            this.rad_time.Location = new System.Drawing.Point(47, 67);
            this.rad_time.Name = "rad_time";
            this.rad_time.Size = new System.Drawing.Size(59, 16);
            this.rad_time.TabIndex = 1;
            this.rad_time.Text = "时间戳";
            this.rad_time.UseVisualStyleBackColor = true;
            // 
            // rad_guid
            // 
            this.rad_guid.AutoSize = true;
            this.rad_guid.Location = new System.Drawing.Point(47, 106);
            this.rad_guid.Name = "rad_guid";
            this.rad_guid.Size = new System.Drawing.Size(47, 16);
            this.rad_guid.TabIndex = 2;
            this.rad_guid.Text = "guid";
            this.rad_guid.UseVisualStyleBackColor = true;
            // 
            // rad_user
            // 
            this.rad_user.AutoSize = true;
            this.rad_user.Location = new System.Drawing.Point(47, 140);
            this.rad_user.Name = "rad_user";
            this.rad_user.Size = new System.Drawing.Size(113, 16);
            this.rad_user.TabIndex = 3;
            this.rad_user.Text = "自定义+起始序号";
            this.rad_user.UseVisualStyleBackColor = true;
            this.rad_user.CheckedChanged += new System.EventHandler(this.rad_user_CheckedChanged);
            // 
            // txt_start
            // 
            this.txt_start.Location = new System.Drawing.Point(166, 139);
            this.txt_start.Name = "txt_start";
            this.txt_start.Size = new System.Drawing.Size(112, 21);
            this.txt_start.TabIndex = 4;
            this.txt_start.Text = "u";
            // 
            // txt_startnum
            // 
            this.txt_startnum.Location = new System.Drawing.Point(302, 139);
            this.txt_startnum.Name = "txt_startnum";
            this.txt_startnum.Size = new System.Drawing.Size(47, 21);
            this.txt_startnum.TabIndex = 5;
            this.txt_startnum.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(64, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(389, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "注：本工具会删除原文件，只保存改名后的文件，请将原文件复制一份！";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "文件名：";
            // 
            // rab_history
            // 
            this.rab_history.AutoSize = true;
            this.rab_history.Location = new System.Drawing.Point(47, 173);
            this.rab_history.Name = "rab_history";
            this.rab_history.Size = new System.Drawing.Size(59, 16);
            this.rab_history.TabIndex = 7;
            this.rab_history.TabStop = true;
            this.rab_history.Text = "不更名";
            this.rab_history.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 531);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "更名";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_statusInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rad_bmp;
        private System.Windows.Forms.RadioButton rad_png;
        private System.Windows.Forms.RadioButton rad_gif;
        private System.Windows.Forms.RadioButton rad_jpg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_startnum;
        private System.Windows.Forms.TextBox txt_start;
        private System.Windows.Forms.RadioButton rad_user;
        private System.Windows.Forms.RadioButton rad_guid;
        private System.Windows.Forms.RadioButton rad_time;
        private System.Windows.Forms.RadioButton rad_ymdhmsf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rab_history;

    }
}

