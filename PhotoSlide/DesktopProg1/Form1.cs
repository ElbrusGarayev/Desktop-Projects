using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopProg1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[] folderFile = null;
        private int selected = 0;
        

        private void Open_File_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] part1 = null, part2 = null;
                part1 = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.jpg");
                part2 = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.jpeg");
                folderFile = part1.Concat(part2).ToArray();
                showImage(folderFile[0]);
            }
        }

        private void showImage(string path)
        {
            Image imgtemp = Image.FromFile(path);
            pictureBox1.Image = imgtemp;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void prevImage()
        {
            if (selected == 0)
            {
                selected = folderFile.Length - 1;
                showImage(folderFile[selected]);
            }
            else
            {
                selected = selected - 1;
                showImage(folderFile[selected]);
            }
        }

        private void nextImage()
        {
            if (selected == folderFile.Length - 1)
            {
                selected = 0;
                showImage(folderFile[selected]);
            }
            else
            {
                selected = selected + 1;
                showImage(folderFile[selected]);
            }
        }

        private void SlideShow_Click_1(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
                SlideShow.Text = "<< START Slide Show >>";
            }
            else
            {
                timer1.Enabled = true;
                SlideShow.Text = "<< STOP Slide Show >>";
            }
        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            nextImage();
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            prevImage();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            nextImage();
        }

    }
}
