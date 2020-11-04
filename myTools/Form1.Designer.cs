namespace myTools
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.labPhys = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labVirtual = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labUseMemory = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearMemory = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCloseProcess = new System.Windows.Forms.Button();
            this.txtProcessName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslabMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIgnoreDir = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnWatch = new System.Windows.Forms.Button();
            this.picDir = new System.Windows.Forms.PictureBox();
            this.txtDirPath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labAppName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.picApp = new System.Windows.Forms.PictureBox();
            this.txtAppPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picApp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "物理内存:";
            // 
            // labPhys
            // 
            this.labPhys.AutoSize = true;
            this.labPhys.ForeColor = System.Drawing.Color.Black;
            this.labPhys.Location = new System.Drawing.Point(76, 20);
            this.labPhys.Name = "labPhys";
            this.labPhys.Size = new System.Drawing.Size(11, 12);
            this.labPhys.TabIndex = 1;
            this.labPhys.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(8, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "虚拟内存:";
            // 
            // labVirtual
            // 
            this.labVirtual.AutoSize = true;
            this.labVirtual.ForeColor = System.Drawing.Color.Black;
            this.labVirtual.Location = new System.Drawing.Point(76, 40);
            this.labVirtual.Name = "labVirtual";
            this.labVirtual.Size = new System.Drawing.Size(11, 12);
            this.labVirtual.TabIndex = 3;
            this.labVirtual.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(8, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "内存使用率:";
            // 
            // labUseMemory
            // 
            this.labUseMemory.AutoSize = true;
            this.labUseMemory.ForeColor = System.Drawing.Color.Green;
            this.labUseMemory.Location = new System.Drawing.Point(78, 60);
            this.labUseMemory.Name = "labUseMemory";
            this.labUseMemory.Size = new System.Drawing.Size(17, 12);
            this.labUseMemory.TabIndex = 5;
            this.labUseMemory.Text = "0%";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearMemory);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labUseMemory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labPhys);
            this.groupBox1.Controls.Add(this.labVirtual);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 88);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "内存信息";
            // 
            // btnClearMemory
            // 
            this.btnClearMemory.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClearMemory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearMemory.ForeColor = System.Drawing.Color.White;
            this.btnClearMemory.Location = new System.Drawing.Point(139, 55);
            this.btnClearMemory.Name = "btnClearMemory";
            this.btnClearMemory.Size = new System.Drawing.Size(67, 25);
            this.btnClearMemory.TabIndex = 6;
            this.btnClearMemory.Text = "清理内存";
            this.btnClearMemory.UseVisualStyleBackColor = false;
            this.btnClearMemory.Click += new System.EventHandler(this.btnClearMemory_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCloseProcess);
            this.groupBox2.Controls.Add(this.txtProcessName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(250, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 83);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "关闭进程";
            // 
            // btnCloseProcess
            // 
            this.btnCloseProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCloseProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseProcess.ForeColor = System.Drawing.Color.White;
            this.btnCloseProcess.Location = new System.Drawing.Point(187, 31);
            this.btnCloseProcess.Name = "btnCloseProcess";
            this.btnCloseProcess.Size = new System.Drawing.Size(75, 25);
            this.btnCloseProcess.TabIndex = 6;
            this.btnCloseProcess.Text = "关闭进程";
            this.btnCloseProcess.UseVisualStyleBackColor = false;
            this.btnCloseProcess.Click += new System.EventHandler(this.btnCloseProcess_Click);
            // 
            // txtProcessName
            // 
            this.txtProcessName.Location = new System.Drawing.Point(69, 34);
            this.txtProcessName.Name = "txtProcessName";
            this.txtProcessName.Size = new System.Drawing.Size(106, 21);
            this.txtProcessName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(8, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "进程名称:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslabMsg});
            this.statusStrip1.Location = new System.Drawing.Point(0, 595);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(814, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslabMsg
            // 
            this.tsslabMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tsslabMsg.Name = "tsslabMsg";
            this.tsslabMsg.Size = new System.Drawing.Size(768, 17);
            this.tsslabMsg.Spring = true;
            this.tsslabMsg.Text = "开发赞助商：资源驿站（www.zy13.net），点击访问。";
            this.tsslabMsg.Click += new System.EventHandler(this.tsslabMsg_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtIgnoreDir);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnClearLog);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.btnWatch);
            this.groupBox3.Controls.Add(this.picDir);
            this.groupBox3.Controls.Add(this.txtDirPath);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox3.Location = new System.Drawing.Point(14, 108);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(790, 474);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "实时监控目录文件";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(598, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 11);
            this.label10.TabIndex = 36;
            this.label10.Text = "多个文件夹请用英文逗号（,）隔开";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.CadetBlue;
            this.label11.Location = new System.Drawing.Point(8, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(533, 12);
            this.label11.TabIndex = 36;
            this.label11.Text = "使用说明：日志文件夹不需要监控；使用监控的过程中，请不要关闭本软件，否则将无法监控文件。";
            // 
            // txtIgnoreDir
            // 
            this.txtIgnoreDir.Location = new System.Drawing.Point(593, 20);
            this.txtIgnoreDir.Multiline = true;
            this.txtIgnoreDir.Name = "txtIgnoreDir";
            this.txtIgnoreDir.Size = new System.Drawing.Size(188, 65);
            this.txtIgnoreDir.TabIndex = 34;
            this.txtIgnoreDir.Text = "runtime,log,cache,temp";
            this.txtIgnoreDir.TextChanged += new System.EventHandler(this.txtIgnoreDir_TextChanged);
            this.txtIgnoreDir.MouseLeave += new System.EventHandler(this.txtIgnoreDir_MouseLeave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(272, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(323, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "实时监控文件操作日志，可以有效防止网站文件被黑客篡改.";
            // 
            // btnClearLog
            // 
            this.btnClearLog.BackColor = System.Drawing.Color.Olive;
            this.btnClearLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearLog.ForeColor = System.Drawing.Color.White;
            this.btnClearLog.Location = new System.Drawing.Point(423, 31);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(75, 25);
            this.btnClearLog.TabIndex = 32;
            this.btnClearLog.Text = "清空日志";
            this.btnClearLog.UseVisualStyleBackColor = false;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // listBox1
            // 
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox1.ForeColor = System.Drawing.Color.Gray;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(9, 98);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(772, 364);
            this.listBox1.TabIndex = 31;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            // 
            // btnWatch
            // 
            this.btnWatch.BackColor = System.Drawing.Color.Green;
            this.btnWatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWatch.ForeColor = System.Drawing.Color.White;
            this.btnWatch.Location = new System.Drawing.Point(328, 30);
            this.btnWatch.Name = "btnWatch";
            this.btnWatch.Size = new System.Drawing.Size(75, 25);
            this.btnWatch.TabIndex = 30;
            this.btnWatch.Text = "开始监控";
            this.btnWatch.UseVisualStyleBackColor = false;
            this.btnWatch.Click += new System.EventHandler(this.btnWatch_Click);
            // 
            // picDir
            // 
            this.picDir.BackColor = System.Drawing.Color.White;
            this.picDir.Image = ((System.Drawing.Image)(resources.GetObject("picDir.Image")));
            this.picDir.Location = new System.Drawing.Point(283, 34);
            this.picDir.Name = "picDir";
            this.picDir.Size = new System.Drawing.Size(18, 16);
            this.picDir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDir.TabIndex = 29;
            this.picDir.TabStop = false;
            this.picDir.Click += new System.EventHandler(this.picDir_Click);
            // 
            // txtDirPath
            // 
            this.txtDirPath.Location = new System.Drawing.Point(78, 31);
            this.txtDirPath.Name = "txtDirPath";
            this.txtDirPath.Size = new System.Drawing.Size(225, 21);
            this.txtDirPath.TabIndex = 28;
            this.txtDirPath.Text = "D:\\";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(518, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 27;
            this.label9.Text = "忽略文件夹:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(8, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 27;
            this.label5.Text = "所在目录：";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.IncludeSubdirectories = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            this.fileSystemWatcher1.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Created);
            this.fileSystemWatcher1.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Deleted);
            this.fileSystemWatcher1.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher1_Renamed);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labAppName);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btnClose);
            this.groupBox4.Controls.Add(this.picApp);
            this.groupBox4.Controls.Add(this.txtAppPath);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox4.Location = new System.Drawing.Point(538, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(266, 88);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "关闭开机启动项";
            // 
            // labAppName
            // 
            this.labAppName.AutoSize = true;
            this.labAppName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAppName.ForeColor = System.Drawing.Color.Green;
            this.labAppName.Location = new System.Drawing.Point(67, 57);
            this.labAppName.Name = "labAppName";
            this.labAppName.Size = new System.Drawing.Size(29, 12);
            this.labAppName.TabIndex = 31;
            this.labAppName.Text = "未知";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(6, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 30;
            this.label7.Text = "程序名称:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(153, 49);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 25);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "关闭开机启动";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picApp
            // 
            this.picApp.BackColor = System.Drawing.Color.White;
            this.picApp.Image = ((System.Drawing.Image)(resources.GetObject("picApp.Image")));
            this.picApp.Location = new System.Drawing.Point(237, 25);
            this.picApp.Name = "picApp";
            this.picApp.Size = new System.Drawing.Size(18, 16);
            this.picApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picApp.TabIndex = 28;
            this.picApp.TabStop = false;
            this.picApp.Click += new System.EventHandler(this.picApp_Click);
            // 
            // txtAppPath
            // 
            this.txtAppPath.Location = new System.Drawing.Point(69, 22);
            this.txtAppPath.Name = "txtAppPath";
            this.txtAppPath.Size = new System.Drawing.Size(188, 21);
            this.txtAppPath.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 26;
            this.label6.Text = "程序路径:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 617);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统工具箱";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labPhys;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labVirtual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labUseMemory;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClearMemory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCloseProcess;
        private System.Windows.Forms.TextBox txtProcessName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslabMsg;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox picDir;
        private System.Windows.Forms.TextBox txtDirPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnWatch;
        private System.Windows.Forms.ListBox listBox1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox picApp;
        private System.Windows.Forms.TextBox txtAppPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labAppName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIgnoreDir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}

