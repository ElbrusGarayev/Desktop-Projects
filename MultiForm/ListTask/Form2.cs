using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ListTask
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void setData(String name, String surname, String mark)
        {
            ListViewItem llist = new ListViewItem();
            llist.Text = name;
            llist.SubItems.Add(surname);
            llist.SubItems.Add(mark);

            list.Items.Add(llist);
        }

        public void delData(String index) => 
            list.Items.RemoveAt(Int16.Parse(index));

        public void deleteAll()
        {
            list.Items.Clear();
        }

        public int size()
        {
            return list.Items.Count;
        }
        public ArrayList arrList = new ArrayList();
        public int capacity()
        {
            foreach (ListViewItem item in list.Items)
            {
                arrList.Add(item);
            }
            return arrList.Capacity;
        }
    }
}
