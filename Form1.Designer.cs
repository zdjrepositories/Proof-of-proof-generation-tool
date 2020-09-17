namespace 在校证明生成工具
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
            this.label1 = new System.Windows.Forms.Label();
            this.学号 = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.姓名 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.系别 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.年级 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.编号 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.班级 = new System.Windows.Forms.TextBox();
            this.专业 = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.签发 = new System.Windows.Forms.TextBox();
            this.拟稿 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.字 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开根目录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.重启ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.版本V10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(32, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(13, 12, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号：";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // 学号
            // 
            this.学号.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.学号.Location = new System.Drawing.Point(109, 49);
            this.学号.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.学号.Name = "学号";
            this.学号.Size = new System.Drawing.Size(188, 38);
            this.学号.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(847, 38);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(166, 58);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(29, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "姓名：";
            // 
            // 姓名
            // 
            this.姓名.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.姓名.Location = new System.Drawing.Point(109, 146);
            this.姓名.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.姓名.Name = "姓名";
            this.姓名.Size = new System.Drawing.Size(188, 38);
            this.姓名.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(338, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "系别：";
            // 
            // 系别
            // 
            this.系别.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.系别.Location = new System.Drawing.Point(423, 146);
            this.系别.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.系别.Name = "系别";
            this.系别.Size = new System.Drawing.Size(590, 38);
            this.系别.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(29, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "年级：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(338, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "编号：";
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPreview.Location = new System.Drawing.Point(847, 386);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(166, 61);
            this.btnPreview.TabIndex = 11;
            this.btnPreview.Text = "预览";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrint.Location = new System.Drawing.Point(847, 526);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(166, 61);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "打印";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // 年级
            // 
            this.年级.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.年级.Location = new System.Drawing.Point(109, 218);
            this.年级.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.年级.Name = "年级";
            this.年级.Size = new System.Drawing.Size(188, 38);
            this.年级.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(448, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 28);
            this.label8.TabIndex = 15;
            // 
            // 编号
            // 
            this.编号.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.编号.Location = new System.Drawing.Point(423, 50);
            this.编号.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.编号.Name = "编号";
            this.编号.Size = new System.Drawing.Size(245, 38);
            this.编号.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(338, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 28);
            this.label9.TabIndex = 18;
            this.label9.Text = "班级：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(338, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 28);
            this.label10.TabIndex = 19;
            this.label10.Text = "专业：";
            // 
            // 班级
            // 
            this.班级.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.班级.Location = new System.Drawing.Point(423, 218);
            this.班级.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.班级.Name = "班级";
            this.班级.Size = new System.Drawing.Size(590, 38);
            this.班级.TabIndex = 20;
            // 
            // 专业
            // 
            this.专业.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.专业.Location = new System.Drawing.Point(423, 288);
            this.专业.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.专业.Name = "专业";
            this.专业.Size = new System.Drawing.Size(590, 38);
            this.专业.TabIndex = 21;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(35, 475);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 22;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(30, 288);
            this.label3.Margin = new System.Windows.Forms.Padding(13, 12, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 38);
            this.label3.TabIndex = 24;
            this.label3.Text = "拟稿：";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(32, 358);
            this.label11.Margin = new System.Windows.Forms.Padding(13, 12, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 38);
            this.label11.TabIndex = 25;
            this.label11.Text = "签发：";
            this.label11.UseCompatibleTextRendering = true;
            // 
            // 签发
            // 
            this.签发.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.签发.Location = new System.Drawing.Point(109, 355);
            this.签发.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.签发.Name = "签发";
            this.签发.Size = new System.Drawing.Size(188, 38);
            this.签发.TabIndex = 26;
            // 
            // 拟稿
            // 
            this.拟稿.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.拟稿.Location = new System.Drawing.Point(109, 288);
            this.拟稿.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.拟稿.Name = "拟稿";
            this.拟稿.Size = new System.Drawing.Size(188, 38);
            this.拟稿.TabIndex = 27;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(58, 414);
            this.label18.Margin = new System.Windows.Forms.Padding(13, 12, 3, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 38);
            this.label18.TabIndex = 29;
            this.label18.Text = "字：";
            this.label18.UseCompatibleTextRendering = true;
            // 
            // 字
            // 
            this.字.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.字.Location = new System.Drawing.Point(109, 414);
            this.字.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.字.Name = "字";
            this.字.Size = new System.Drawing.Size(188, 38);
            this.字.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(348, 347);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(482, 343);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1065, 33);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开根目录ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.重启ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(62, 29);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开根目录ToolStripMenuItem
            // 
            this.打开根目录ToolStripMenuItem.Name = "打开根目录ToolStripMenuItem";
            this.打开根目录ToolStripMenuItem.Size = new System.Drawing.Size(179, 30);
            this.打开根目录ToolStripMenuItem.Text = "打开根目录";
            this.打开根目录ToolStripMenuItem.Click += new System.EventHandler(this.打开根目录ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(176, 6);
            // 
            // 重启ToolStripMenuItem
            // 
            this.重启ToolStripMenuItem.Name = "重启ToolStripMenuItem";
            this.重启ToolStripMenuItem.Size = new System.Drawing.Size(179, 30);
            this.重启ToolStripMenuItem.Text = "重启";
            this.重启ToolStripMenuItem.Click += new System.EventHandler(this.重启ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(179, 30);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.版本V10ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(62, 29);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 版本V10ToolStripMenuItem
            // 
            this.版本V10ToolStripMenuItem.Name = "版本V10ToolStripMenuItem";
            this.版本V10ToolStripMenuItem.Size = new System.Drawing.Size(162, 30);
            this.版本V10ToolStripMenuItem.Text = "版本V1.0";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1065, 702);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.字);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.拟稿);
            this.Controls.Add(this.签发);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.专业);
            this.Controls.Add(this.班级);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.编号);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.年级);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.系别);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.姓名);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.学号);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "在校证明生成工具";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox 学号;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox 姓名;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox 系别;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox 年级;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox 编号;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox 班级;
        private System.Windows.Forms.TextBox 专业;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox 签发;
        private System.Windows.Forms.TextBox 拟稿;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox 字;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开根目录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重启ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 版本V10ToolStripMenuItem;
    }
}

