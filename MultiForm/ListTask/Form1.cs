using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
            ArrayList names = new ArrayList(new string[] { "Valeria", "Dmitri", "Zara", "Alexey", "Nick" });
            ArrayList surnames = new ArrayList(new string[] { "Rykhalskiy", "Yamnyk", "Trustra", "Shevchenko", "Minina" });
            Random rnd = new Random();

        private void Generate_Click(object sender, EventArgs e)
        {
            name.Text = names[rnd.Next(0, 5)].ToString();
            surname.Text = surnames[rnd.Next(0, 5)].ToString();
            mark.Text = rnd.Next(51, 100).ToString();
        }

        private void DelIndex_Enter(object sender, EventArgs e)
        {
            if (delIndex.Text.Equals("Index"))
            {
                delIndex.Text = "";
                delIndex.ForeColor = Color.Black;
            }
        }

        private void DelIndex_Leave(object sender, EventArgs e)
        {
            if (delIndex.Text.Equals("")) { delIndex.Text = "Index"; delIndex.ForeColor = Color.Gray; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        Form2 form2 = new Form2();
        private void Add_Click(object sender, EventArgs e)
        {
            form2.setData(name.Text, surname.Text, mark.Text);
            set();
            form2.arrList.Clear();
        }

        private void ShowList_Click(object sender, EventArgs e)
        {
            form2.Show();
        }

        private void DelPerson_Click(object sender, EventArgs e)
        {
            form2.delData(delIndex.Text);
            set();
        }

        private void DeleteAll_Click(object sender, EventArgs e)
        {
            form2.deleteAll();
            set();
        }

        public void set()
        {
            listSize.Text = form2.size().ToString();
            listCap.Text = form2.capacity().ToString();
        }
    }
}
