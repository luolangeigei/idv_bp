using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form2 : Form
    {
        [DllImport("user32.dll")]
        public static extern int ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer2.Start();
            timer1.Start();
            qsz_xz_1.Parent = pictureBox1;
            qsz_xz_2.Parent = pictureBox1;
            qsz_xz_3.Parent = pictureBox1;
            qsz_xz_4.Parent = pictureBox1;
            jgz_ban_1.Parent = pictureBox1;
            jgz_ban_2.Parent = pictureBox1;
            jgz_ban_3.Parent = pictureBox1;
            jgz_ban_4.Parent = pictureBox1;
            qsz_ban_1.Parent = pictureBox1;
            qsz_ban_2.Parent = pictureBox1;
            qsz_ban_3.Parent = pictureBox1;
            qsz_ban_4.Parent = pictureBox1;
            qsz_ban_5.Parent = pictureBox1;
            qsz_ban_6.Parent = pictureBox1;
            jgz_xz_1.Parent = pictureBox1;
            name_1.Parent = pictureBox1;
            name_2.Parent = pictureBox1;
            if(qsz.img_path!=null)
                pictureBox1.BackgroundImage = Image.FromFile(qsz.img_path);
            if (qsz.font_size!=null|qsz.font_size!=null)
            name_2.Font=name_1.Font = new Font(qsz.font_name, Convert.ToInt32(qsz.font_size));
        }






        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                name_1.Text = qsz.name1;
                name_2.Text = qsz.name2;
            }
            catch
            {

            }
            try
            {
                qsz_xz_1.BackgroundImage = Image.FromFile(@AppDomain.CurrentDomain.BaseDirectory + "pic\\sur\\" + qsz.qx1);
                qsz_xz_2.BackgroundImage = Image.FromFile(@AppDomain.CurrentDomain.BaseDirectory + "pic\\sur\\" + qsz.qx2);
                qsz_xz_3.BackgroundImage = Image.FromFile(@AppDomain.CurrentDomain.BaseDirectory + "pic\\sur\\" + qsz.qx3);
                qsz_xz_4.BackgroundImage = Image.FromFile(@AppDomain.CurrentDomain.BaseDirectory + "pic\\sur\\" + qsz.qx4);
            }
            catch { }
            try
            {
                jgz_ban_1.BackgroundImage = Image.FromFile(@AppDomain.CurrentDomain.BaseDirectory + "pic\\hun\\" + qsz.jb1);
                jgz_ban_2.BackgroundImage = Image.FromFile(@AppDomain.CurrentDomain.BaseDirectory + "pic\\hun\\" + qsz.jb2);
                jgz_ban_3.BackgroundImage = Image.FromFile(@AppDomain.CurrentDomain.BaseDirectory + "pic\\hun\\" + qsz.jb3);
            }
            catch { }
            try
            {
                qsz_ban_1.BackgroundImage = Image.FromFile(@AppDomain.CurrentDomain.BaseDirectory + "pic\\sur\\" + qsz.qb1);
                qsz_ban_2.BackgroundImage = Image.FromFile(@AppDomain.CurrentDomain.BaseDirectory + "pic\\sur\\" + qsz.qb2);
                qsz_ban_3.BackgroundImage = Image.FromFile(@AppDomain.CurrentDomain.BaseDirectory + "pic\\sur\\" + qsz.qb3);
                qsz_ban_4.BackgroundImage = Image.FromFile(@AppDomain.CurrentDomain.BaseDirectory + "pic\\sur\\" + qsz.qb4);
                qsz_ban_5.BackgroundImage = Image.FromFile(@AppDomain.CurrentDomain.BaseDirectory + "pic\\sur\\" + qsz.qb5);
                qsz_ban_6.BackgroundImage = Image.FromFile(@AppDomain.CurrentDomain.BaseDirectory + "pic\\sur\\" + qsz.qb6);
            }
            catch
            { }
            try
            { 
                jgz_xz_1.BackgroundImage = Image.FromFile(@AppDomain.CurrentDomain.BaseDirectory + "pic\\hunbig\\" + qsz.jx1);
            }
            catch
            {

            }
        
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        public static void maxh()
        {
         
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Process[] processes = Process.GetProcesses();
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1);
            }
        }
        [DllImport("kernel32.dll")]
        private static extern bool SetProcessWorkingSetSize(IntPtr proc, int min, int max);
    }
}
