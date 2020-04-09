using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace RandomNumberGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pBox1.BackColor = Color.Transparent;
            pBox2.BackColor = Color.Transparent;
            MessageBox.Show("Good luck all!!!");

            
        }
        Random rnd = new Random();
        int sum1 = 0, sum2 = 0;
        int one;   int p1 = 0;
        int two;   int p2 = 0;
        ArrayList pathList = new ArrayList();

        private void Form1_Load(object sender, EventArgs e)
        {
            pBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pathList.Add(@"C:\Users\Elbru\source\repos\RandomNumberGame\RandomNumberGame\Resources\Dices\1.png");
            pathList.Add(@"C:\Users\Elbru\source\repos\RandomNumberGame\RandomNumberGame\Resources\Dices\2.png");
            pathList.Add(@"C:\Users\Elbru\source\repos\RandomNumberGame\RandomNumberGame\Resources\Dices\3.png");
            pathList.Add(@"C:\Users\Elbru\source\repos\RandomNumberGame\RandomNumberGame\Resources\Dices\4.png");
            pathList.Add(@"C:\Users\Elbru\source\repos\RandomNumberGame\RandomNumberGame\Resources\Dices\5.png");
            pathList.Add(@"C:\Users\Elbru\source\repos\RandomNumberGame\RandomNumberGame\Resources\Dices\6.png");
        }

        private int GenerateAndSum()
        {
            one = rnd.Next(1, 7);
            two = rnd.Next(1, 7);
            return one + two;
        }

        private void check(int sum, String player)
        {
            if(sum >= 100)
            {
                Player1.Enabled = false;
                Player2.Enabled = false;
                MessageBox.Show(player + " won", "Winner!!!");
                _ = player.Equals("Player1") ? Player1.Enabled = true : Player2.Enabled = true;
                _ = player.Equals("Player1") ? p1++ : p2++;
                Play1.Text = "Player1: " + p1;
                Play2.Text = "Player2: " + p2;
                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
                label5.Text = "";
                label6.Text = "";
                sum1 = 0; sum2 = 0;
            }
        }

        private void showPhotos()
        {
            switch (one)
            {
                case 1:
                    pBox1.Image = Image.FromFile(pathList[0].ToString());
                    break;
                case 2:
                    pBox1.Image = Image.FromFile(pathList[1].ToString());
                    break;
                case 3:
                    pBox1.Image = Image.FromFile(pathList[2].ToString());
                    break;
                case 4:
                    pBox1.Image = Image.FromFile(pathList[3].ToString());
                    break;
                case 5:
                    pBox1.Image = Image.FromFile(pathList[4].ToString());
                    break;
                case 6:
                    pBox1.Image = Image.FromFile(pathList[5].ToString());
                    break;
            }

            switch (two)
            {
                case 1:
                    pBox2.Image = Image.FromFile(pathList[0].ToString());
                    break;
                case 2:
                    pBox2.Image = Image.FromFile(pathList[1].ToString());
                    break;
                case 3:
                    pBox2.Image = Image.FromFile(pathList[2].ToString());
                    break;
                case 4:
                    pBox2.Image = Image.FromFile(pathList[3].ToString());
                    break;
                case 5:
                    pBox2.Image = Image.FromFile(pathList[4].ToString());
                    break;
                case 6:
                    pBox2.Image = Image.FromFile(pathList[5].ToString());
                    break;
            }
        }

        private void Player1_Click(object sender, EventArgs e)
        {
            sum1 += GenerateAndSum();
            label1.Text = "First: " + one.ToString();
            label2.Text = "Second: " + two.ToString();
            label3.Text = "Sum: " + sum1.ToString();
            showPhotos();
            Player1.Enabled = false;
            Player2.Enabled = true;

            check(sum1, "Player1");
        }

        private void Player2_Click(object sender, EventArgs e)
        {
            sum2 += GenerateAndSum();
            label6.Text = "First: " + one.ToString();
            label4.Text = "Second: " + two.ToString();
            label5.Text = "Sum: " + sum2.ToString();
            showPhotos();
            Player2.Enabled = false;
            Player1.Enabled = true;

            check(sum2, "Player2");
        }
    }
}
