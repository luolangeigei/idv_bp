using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
          backgroundWorker1.RunWorkerAsync();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
          
          //  materialTabControl1.SelectedIndex = 1;//从0开始哦，第一个tabpage
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            Form2 f= new Form2();
            f.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            DirectoryInfo folder = new DirectoryInfo(@AppDomain.CurrentDomain.BaseDirectory + "pic\\hun\\");
            foreach (FileInfo file in folder.GetFiles("*.png"))
            {
                string[] name = file.FullName.Split('\\');
                jgz_xz_1.Items.Add(name.Last());
                jgz_ban_1.Items.Add(name.Last());
                jgz_ban_2.Items.Add(name.Last());
                jgz_ban_3.Items.Add(name.Last());
            }
            DirectoryInfo folder1 = new DirectoryInfo(@AppDomain.CurrentDomain.BaseDirectory + "pic\\sur\\");
            foreach (FileInfo file in folder1.GetFiles("*.png"))
            {
                string[] name = file.FullName.Split('\\');
                qsz_ban_1.Items.Add(name.Last());
                qsz_ban_2.Items.Add(name.Last());
                qsz_ban_3.Items.Add(name.Last());
                qsz_ban_4.Items.Add(name.Last());
                qsz_ban_5.Items.Add(name.Last());
                qsz_ban_6.Items.Add(name.Last());
                qsz_xz_1.Items.Add(name.Last());
                qsz_xz_2.Items.Add(name.Last());
                qsz_xz_3.Items.Add(name.Last());
                qsz_xz_4.Items.Add(name.Last());
               
            }
            InstalledFontCollection MyFont = new InstalledFontCollection();
            FontFamily[] MyFontFamilies = MyFont.Families;
            int Count = MyFontFamilies.Length;
            for (int i = 0; i < Count; i++)
            {
                font_text.Items.Add(MyFontFamilies[i].Name);
            }
            
        }

        private void materialComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void qsz_xz_1_TextChanged(object sender, EventArgs e)
        {
            qsz.qx1 = qsz_xz_1.Text;
        }

        private void qsz_xz_2_TextChanged(object sender, EventArgs e)
        {
            qsz.qx2 = qsz_xz_2.Text;
        }

        private void qsz_xz_3_TextChanged(object sender, EventArgs e)
        {
            qsz.qx3 = qsz_xz_3.Text;
        }

        private void qsz_xz_4_TextChanged(object sender, EventArgs e)
        {
            qsz.qx4 = qsz_xz_4.Text;
        }

        private void jgz_ban_1_TextChanged(object sender, EventArgs e)
        {
            qsz.jb1 = jgz_ban_1.Text;
        }

        private void jgz_ban_2_TextChanged(object sender, EventArgs e)
        {
            qsz.jb2 = jgz_ban_2.Text;
        }

        private void jgz_ban_3_TextChanged(object sender, EventArgs e)
        {
            qsz.jb3 = jgz_ban_3.Text;
        }

        private void qsz_ban_1_TextChanged(object sender, EventArgs e)
        {
            qsz.qb1 = qsz_ban_1.Text;
        }

        private void qsz_ban_2_TextChanged(object sender, EventArgs e)
        {
            qsz.qb2 = qsz_ban_2.Text;
        }

        private void qsz_ban_3_TextChanged(object sender, EventArgs e)
        {
            qsz.qb3 = qsz_ban_3.Text;
        }

        private void qsz_ban_4_TextChanged(object sender, EventArgs e)
        {
            qsz.qb4 = qsz_ban_4.Text;
        }

        private void qsz_ban_5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void qsz_ban_5_TextChanged(object sender, EventArgs e)
        {
            qsz.qb5 = qsz_ban_5.Text;
        }

        private void qsz_ban_6_TextChanged(object sender, EventArgs e)
        {
            qsz.qb6 = qsz_ban_6.Text;
        }

        private void jgz_xz_1_TextChanged(object sender, EventArgs e)
        {
            qsz.jx1 = jgz_xz_1.Text;
        }

        private void materialMaskedTextBox1_TextChanged(object sender, EventArgs e)
        {
           qsz.name1= materialMaskedTextBox1.Text;
        }

        private void materialMaskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            qsz.name2= materialMaskedTextBox2.Text;
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            (materialMaskedTextBox1.Text, materialMaskedTextBox2.Text) = (materialMaskedTextBox2.Text, materialMaskedTextBox1.Text);
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            qsz.font_name = font_text.Text;
            qsz.font_size=font_size.Text;
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {

            OpenFileDialog openfile = new OpenFileDialog();

            if (openfile.ShowDialog() == DialogResult.OK && openfile.FileName!="") ;
            {
                pictureBox1.ImageLocation = openfile.FileName;
                img_path.Text = openfile.FileName;
                qsz.img_path= openfile.FileName;
            }

            openfile.Dispose();
        }


    }
}
