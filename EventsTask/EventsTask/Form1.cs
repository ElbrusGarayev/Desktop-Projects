using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Up_Click(object sender, EventArgs e)
        {
            timer.Start();
            downFloor1.BackColor = Color.Blue;
            downFloor2.BackColor = Color.Blue;
            int y = elevator.Location.Y;
            if(y != 0) y--;
            else
            {
                upFloor1.BackColor = Color.DarkRed;
                upFloor2.BackColor = Color.DarkRed;
            }
            elevator.Location = new System.Drawing.Point(elevator.Location.X, y);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //set floor
            int ey = elevator.Location.Y;
            int my = midFloor1.Location.Y;
            if (ey < my && up.Focused)
                floor.Text = "Floor: 2";
            else if ((ey > 0 && down.Focused && ey < my) || (ey < downFloor1.Location.Y && up.Focused))
                floor.Text = "Floor: 1";
            else if (ey > my ||ey < downFloor1.Location.Y)
                floor.Text = "Floor: G";

            //move elevator
            if (up.Focused) Up_Click(sender, e);
            else Down_Click(sender, e);
        }

        private void Down_Click(object sender, EventArgs e)
        {
            timer.Start();
            upFloor1.BackColor = Color.Blue;
            upFloor2.BackColor = Color.Blue;
            int y = elevator.Location.Y;
            if (y + elevator.Height != building.Height)  y++;
            else
            {
                downFloor1.BackColor = Color.DarkRed;
                downFloor2.BackColor = Color.DarkRed;
            }
            elevator.Location = new System.Drawing.Point(elevator.Location.X, y);
        }

        private void Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {           
                this.SelectNextControl(name, true, true, true, true);
            }
        }

        private void Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {           
                this.SelectNextControl(email, true, true, true, true);
            }
        }

        private void Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
            if (e.KeyChar == (char)13)
            {           
                this.SelectNextControl(phone, true, true, true, true);
            }
        }

        private void Gpa_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
            if (e.KeyChar == (char)13)
            {
                this.SelectNextControl(gpa, true, true, true, true);
            }
        }

        private void Name_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(name.Text))
            {
                MessageBox.Show("Please enter Name and Surname!");
                e.Cancel = true;
            }
            else e.Cancel = false;
        }

        private void Email_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(email.Text) || 
                (!email.Text.Contains("@") && !email.Text.Contains(".")))
            {
                MessageBox.Show("Email format is wrong!!!");
                e.Cancel = true;
            }
            else e.Cancel = false;
        }

        private void Phone_Validating(object sender, CancelEventArgs e)
        {
            if (phone.Text.Length < 9)
            {
                MessageBox.Show("Number format is wrong!!!");
                e.Cancel = true;
            }
            else e.Cancel = false;
        }

        private void Gpa_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt32(gpa.Text) > 100 || Convert.ToInt32(gpa.Text) < 0
                || String.IsNullOrEmpty(email.Text))
            {
                MessageBox.Show("GPA is not true!");
                e.Cancel = true;
            }
            else e.Cancel = false;
        }
        public class Human
        {
            public String name;
            public String email;
            public String number;
            public String gpa;
        }
        List<Human> humans = new List<Human>();
        private void Add_Click(object sender, EventArgs e)
        {
            Human human = new Human();
            human.name = name.Text;
            human.email = email.Text;
            human.number = phone.Text;
            human.gpa = gpa.Text;
            humans.Add(human);
            numsOfRec.Text = "Number of Records: " + humans.Count;
        }
        bool temp = false;
        int x1, x2, y1, y2;
        Pen pen = new Pen(Color.Transparent);
        Graphics graphic;

        private void WhiteBoard_MouseDown(object sender, MouseEventArgs e)
        {
            temp = true;
            x1 = e.X;
            y1 = e.Y;
        }

        private void Brush_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.FromArgb(120, 255, 0, 0), 5);
        }

        private void Eraser_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.White, 8);
        }

        private void WhiteBoard_MouseMove(object sender, MouseEventArgs e)
        {
            if (temp)
            {
                x2 = e.X;
                y2 = e.Y;
                graphic = whiteBoard.CreateGraphics();
                graphic.DrawLine(pen, x1, y1, x2, y2);
            }

            x1 = x2;
            y1 = y2;
        }

        private void WhiteBoard_MouseUp(object sender, MouseEventArgs e)
        {
            temp = false;
        }
    }
}
