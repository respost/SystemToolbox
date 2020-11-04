using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using System.Globalization;
using System.Threading;

namespace myTools
{
    public partial class Form1 : Form
    {
        //Ini文件辅助类
        private IniHelper ini = null;
        //忽略文件夹数组
        private string[] dirArray;

        private string global_dirPath;
        private string global_ignoreDir;

        public Form1()
        {
            InitializeComponent();
            //加载config.ini配置文件           
            LoadIniConfig();
            /*在多线程程序中：
             * 新创建的线程不能访问UI线程创建的窗口控件，
             * 如果需要访问窗口中的控件，可以在窗口构造函数中将CheckForIllegalCrossThreadCalls设置为false         
             */
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void LoadIniConfig()
        {
            this.ini = new IniHelper("config.ini");
            string iniDirPath = this.ini.ReadString("Setting", "DirPath", "D:\\wwwroot");
            string iniIgnoreDir = this.ini.ReadString("Setting", "IgnoreDir", "runtime,log,cache,temp");
            this.txtDirPath.Text = iniDirPath;
            global_dirPath = iniDirPath;
            this.txtIgnoreDir.Text = iniIgnoreDir;
            global_ignoreDir = iniIgnoreDir;
        }
        //内存信息
        [StructLayout(LayoutKind.Sequential)]
        public struct MemoryInfo //此处全是以字节为单位
        {
             public uint dwLength;//长度
             public uint dwMemoryLoad;//内存使用率
             public uint dwTotalPhys;//总物理内存
             public uint dwAvailPhys;//可用物理内存
             public uint dwTotalPageFile;//交换文件总大小
             public uint dwAvailPageFile;//可用交换文件大小
             public uint dwTotalVirtual;//总虚拟内存
             public uint dwAvailVirtual;//可用虚拟内存大小
        }
        //读取内存
        [DllImport("kernel32")]
        public static extern void GlobalMemoryStatus(ref MemoryInfo MemInfo);
        //清理内存
        [DllImport("psapi.dll")]
        static extern int EmptyWorkingSet(IntPtr hwProc);

        private void Form1_Load(object sender, EventArgs e)
        {
            //加载内存信息
            showMemoryInfo();
        }
        /// <summary>
        /// 读取内存
        /// </summary>
        /// <returns></returns>
        private static MemoryInfo GetMemoryStatus()
        {
            MemoryInfo MemInfo;
            MemInfo = new MemoryInfo();
            GlobalMemoryStatus(ref MemInfo);
            return MemInfo;
        }

        /// <summary>
        /// 释放内存
        /// </summary>
        public static void ClearMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                //对于系统进程会拒绝访问，导致出错，此处对异常不进行处理。
                try
                {
                    EmptyWorkingSet(process.Handle);
                }
                catch
                {
                }
            }
        }
        // <summary>
        /// 关闭进程
        /// </summary>
        /// <param name="processName">进程名</param>
        private void KillProcess(string processName)
        {
            try
            {
                if (processName.Contains(".exe"))
                {
                    //去掉.exe
                    processName = processName.Substring(0,processName.Length -4);
                }
                Process[] Processes = Process.GetProcessesByName(processName);
  
                if (Processes.Length > 0)
                {
                    for (int i = 0; i < Processes.Length; i++)
                    {
                        if (!Processes[i].CloseMainWindow()) //尝试关闭进程 释放资源
                        {
                            Processes[i].Kill(); //强制关闭
                        }          
                    }
                    tsslabMsg.Text = string.Format("{0} {1}进程总数量：{2}，已全部关闭", DateTime.Now.ToLongTimeString().ToString(), processName, Processes.Length);
                }
                else
                {
                    tsslabMsg.Text = string.Format("{0} {1}进程不存在", DateTime.Now.ToLongTimeString().ToString(), processName);
                }
            }
            catch //出现异常，表明 kill 进程失败
            {
                tsslabMsg.Text = string.Format("{0} {1}进程关闭失败", DateTime.Now.ToLongTimeString().ToString(), processName);
            }
        }
        private void showMemoryInfo(){
            //读取内存
            MemoryInfo MemInfo = GetMemoryStatus();
            //物理内存
            long totalPhysMb = Convert.ToInt64(MemInfo.dwTotalPhys.ToString()) / 1024 / 1024;
            long availPhysMb = Convert.ToInt64(MemInfo.dwAvailPhys.ToString()) / 1024 / 1024;
            //虚拟内存
            long totalVirtualMb = Convert.ToInt64(MemInfo.dwTotalVirtual.ToString()) / 1024 / 1024;
            long availVirtualMb = Convert.ToInt64(MemInfo.dwAvailVirtual.ToString()) / 1024 / 1024;

            long memoryLoad = Convert.ToInt64(MemInfo.dwMemoryLoad.ToString());
            this.labPhys.Text = totalPhysMb + " MB（可用 " + availPhysMb + " MB）";
            this.labVirtual.Text = totalVirtualMb + " MB（可用 " + availVirtualMb + " MB）";
            this.labUseMemory.Text = memoryLoad + "%";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //定时器每秒更新一次
            showMemoryInfo();
            ClearMemory();
        }

        private void btnClearMemory_Click(object sender, EventArgs e)
        {
            ClearMemory();
            tsslabMsg.Text = "内存清理成功";
        }

        private void btnCloseProcess_Click(object sender, EventArgs e)
        {
            string processName = this.txtProcessName.Text.Trim();
            if (processName == string.Empty)
            {
                MessageBox.Show("请输入进程名称");
                return;
            }
            //杀掉进程
            KillProcess(processName);

        }

        private void picDir_Click(object sender, EventArgs e)
        {
            //获取文件和路径名 一起显示在 txtbox 控件里
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                this.txtDirPath.Text = folder.SelectedPath;
                global_dirPath = this.txtDirPath.Text.Trim();
                this.ini.WriteString("Setting", "DirPath", global_dirPath);
            }
        }

        private void btnWatch_Click(object sender, EventArgs e)
        {        
            if (global_dirPath == string.Empty || !Directory.Exists(global_dirPath))
            {
                MessageBox.Show("目录不存在，请先选择要查看的目录");
                picDir_Click(sender, e);
                return;
            }
            if (this.btnWatch.Text == "开始监控")
            {
                StartLook();
            }
            else
            {
                DialogResult diagorel = MessageBox.Show("确定要停止监控吗，停止后就不能实时查看目录文件的变动情况了？", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (diagorel == DialogResult.Yes)
                {
                    StopLook();
                }
            }
        }

        private void StopLook()
        {
            this.btnWatch.Text = "开始监控";
            this.btnWatch.BackColor = Color.Green;
            fileSystemWatcher1.EnableRaisingEvents = false;
        }

        private void StartLook()
        {
            string txtIgnoreDir = "$RECYCLE.BIN," + this.global_ignoreDir;
            if (txtIgnoreDir != string.Empty)
            {
                dirArray = txtIgnoreDir.Split(',');
            }
            this.btnWatch.Text = "停止监控";
            this.btnWatch.BackColor = Color.Red;
            fileSystemWatcher1.Path = global_dirPath;
            fileSystemWatcher1.EnableRaisingEvents = true;
        }
        /// <summary>
        /// 判断是否要忽略
        /// </summary>
        /// <param name="path"></param>
        /// <returns>返回true表示忽略</returns>
        private bool JudgeWhethertoIgnore(string path)
        {
            bool flag = false;
            foreach (var item in dirArray)
            {
                //全部转换为大写，再进行比较
                if (path.ToUpper().IndexOf(item.ToUpper()) != -1)
                {
                    //存在则忽略
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            string fullPath = e.FullPath;
            //判断是不是文件夹，以及是否在忽略文件夹数组里
            if (!Directory.Exists(fullPath) && !JudgeWhethertoIgnore(fullPath))
                AddLog(LogType.Changed, fullPath);          
        }

        private void fileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {
            string fullPath = e.FullPath;
            //判断是不是文件夹，以及是否在忽略文件夹数组里
            if (!Directory.Exists(fullPath) && !JudgeWhethertoIgnore(fullPath))
                AddLog(LogType.Created, fullPath);
        }

        private void fileSystemWatcher1_Deleted(object sender, FileSystemEventArgs e)
        {
            string fullPath = e.FullPath;
            //判断是不是文件夹，以及是否在忽略文件夹数组里
            if (!Directory.Exists(fullPath) && !JudgeWhethertoIgnore(fullPath))
                AddLog(LogType.Deleted, fullPath);
        }

        private void fileSystemWatcher1_Renamed(object sender, RenamedEventArgs e)
        {
            string fullPath = e.FullPath;
            //判断是不是文件夹，以及是否在忽略文件夹数组里
            if (!Directory.Exists(fullPath) && !JudgeWhethertoIgnore(fullPath))
                AddLog(LogType.Renamed, fullPath);
        }

        private void picApp_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.txtAppPath.SelectedText = dialog.FileName;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string appPath = this.txtAppPath.Text.Trim();
            if (appPath == string.Empty)
            {
                MessageBox.Show("启动程序路径不能为空");
                return;
            }
            int start = appPath.LastIndexOf("\\") + 1;
            int end = appPath.LastIndexOf(".");
            string appName = appPath.Substring(start, end - start);
            this.labAppName.Text = appName;
            try
            {
                Boot.SetAutoStart(false, appName, appPath);
                tsslabMsg.Text = string.Format("开机启动项[{0}]，已成功关闭", appName);
            }
            catch (Exception)
            {
                tsslabMsg.Text = string.Format("开机启动项[{0}]，关闭失败", appName);
            }
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1)
                return;

            Font prefixFont = new Font(e.Font, FontStyle.Bold);
            ColoredListBoxItem li = (ColoredListBoxItem)((ListBox)sender).Items[e.Index];
            Brush br = new SolidBrush(li.TextColor);

            int timeWidth = (int)e.Graphics.MeasureString(" " + new DateTime(2222, 12, 22, 22, 22, 22, 222, CultureInfo.CurrentCulture.Calendar, DateTimeKind.Local).ToString(), prefixFont, e.Bounds.Width, StringFormat.GenericDefault).Width;
            int prefixWidth = (int)e.Graphics.MeasureString(" [Management]", prefixFont, e.Bounds.Width, StringFormat.GenericDefault).Width;
            string prefix = "";
            switch (li.Prefix)
            {
                case "Created":
                    prefix = "[创建文件] ";
                    break;
                case "Changed":
                    prefix = "[修改文件] ";
                    break;
                case "Deleted":
                    prefix = "[删除文件] ";
                    break;
                case "Renamed":
                    prefix = "[重命名文件] ";
                    break;
                default:
                    break;
            }

            e.DrawBackground();
            Rectangle newBounds = new Rectangle(e.Bounds.Location, e.Bounds.Size);

            e.Graphics.DrawString(li.Time.ToString(), prefixFont, br, newBounds, StringFormat.GenericDefault);
            newBounds.X += timeWidth;
            newBounds.Width -= timeWidth;

            e.Graphics.DrawString(prefix, prefixFont, br, newBounds, StringFormat.GenericDefault);
            newBounds.X += prefixWidth;
            newBounds.Width -= prefixWidth;

            e.Graphics.DrawString(
                li.Text, e.Font, br, newBounds.X, newBounds.Y,
                StringFormat.GenericDefault);

            e.DrawFocusRectangle();

        }
        /// <summary>
        /// 添加日志到listBox的项里
        /// </summary>
        /// <param name="prefix"></param>
        /// <param name="text"></param>
        public void AddLog(LogType prefix, string text)
        {
            if (listBox1.InvokeRequired)
            {
                try
                {
                    //listBox1.BeginInvoke(new UtilsHelper.Action<LogType, string>(AddLog), prefix, text);
                }
                catch (ObjectDisposedException)
                {
                }
                return;
            }

            Color rowColor = Color.Black;
            switch (prefix)
            {
                case LogType.Created://创建
                    rowColor = Color.Green;
                    break;

                case LogType.Changed://修改
                    rowColor = Color.DarkBlue;
                    break;

                case LogType.Deleted://删除
                    rowColor = Color.Brown;
                    break;
                case LogType.Renamed: //重命名
                    rowColor = Color.Black;
                    break;
            }

            listBox1.BeginUpdate();
            if (listBox1.Items.Count == 2048)
                listBox1.Items.RemoveAt(0);

            listBox1.Items.Add(new ColoredListBoxItem(DateTime.Now, prefix.ToString(), text, rowColor));

            int h = listBox1.ClientSize.Height - listBox1.Margin.Vertical;
            int i = listBox1.Items.Count - 1;
            while (h >= 0 && i > 0)
            {
                int nh = listBox1.GetItemHeight(i);

                if (nh > h)
                    break;
                else
                {
                    h -= nh;
                    i--;
                }
            }

            listBox1.TopIndex = i;
            listBox1.EndUpdate();
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
        }

        private void txtIgnoreDir_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtIgnoreDir_MouseLeave(object sender, EventArgs e)
        {
            string newIgnoreDir = this.txtIgnoreDir.Text.Trim();
            //监控目录存在，并且忽略文件夹集合发现改变时，重启监控进程
            if (global_dirPath != string.Empty && Directory.Exists(global_dirPath) && newIgnoreDir != string.Empty && !newIgnoreDir.Equals(global_ignoreDir))
            {
                tsslabMsg.Text = "正在重启监控...";
                StopLook();
                global_ignoreDir = newIgnoreDir;
                this.ini.WriteString("Setting", "IgnoreDir", newIgnoreDir);
                ThreadPool.QueueUserWorkItem(state =>
                {
                    //延迟2秒执行
                    Thread.Sleep(2000);
                    BeginInvoke(new Action(() =>
                    {
                        //这里是需要实现的功能代码
                        StartLook();
                        tsslabMsg.Text = "监控重启成功！";
                    }));
                });  
            }
        }

        private void tsslabMsg_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.zy13.net");
        }
    }
}
