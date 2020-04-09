using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarList
{
    public partial class carList : Form
    {
        public carList()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString("dddd, MMM dd yyyy, HH:mm:ss:ffff");
        }

        private void Color_Enter(object sender, EventArgs e)
        {
            if (color.Text == "Color") {
                color.Clear();
                color.ForeColor = Color.Black;
            }
        }

        private void RelDate_Enter(object sender, EventArgs e)
        {
            if (relDate.Text == "Release Date") {
                relDate.Clear();
                relDate.ForeColor = Color.Black;
            }
        }

        private void Price_Enter(object sender, EventArgs e)
        {
            if (price.Text == "Price") {
                price.Clear();
                price.ForeColor = Color.Black;
            }
        }

        private void IdUp_Enter(object sender, EventArgs e)
        {
            if (idSearch.Text == "ID") {
                idSearch.Clear();
                idSearch.ForeColor = Color.Black;
            }
        }

        private void NameUp_Enter(object sender, EventArgs e)
        {
            if (nameUp.Text == "Name") {
                nameUp.Clear();
                nameUp.ForeColor = Color.Black;
            }
        }

        private void ColorUp_Enter(object sender, EventArgs e)
        {
            if (colorUp.Text == "Color") {
                colorUp.Clear();
                colorUp.ForeColor = Color.Black;
            }
        }

        private void PriceUp_Enter(object sender, EventArgs e)
        {
            if (priceUp.Text == "Price"){
                priceUp.Clear();
                priceUp.ForeColor = Color.Black;
            }
        }

        private void NameBox_Enter(object sender, EventArgs e)
        {
            if (nameBox.Text.Equals("Car Name"))
            {
                nameBox.Text = "";
                nameBox.ForeColor = Color.Black;
            }
        }

        private void IdBox_Enter(object sender, EventArgs e)
        {
            if (idBox.Text.Equals("ID"))
            {
                idBox.Text = "";
                idBox.ForeColor = Color.Black;
            }
        }

        private void IdBox_Leave(object sender, EventArgs e)
        {
            if (idBox.Text.Equals("")) { idBox.Text = "ID"; idBox.ForeColor = Color.Gray; }
            
        }

        private void NameBox_Leave(object sender, EventArgs e)
        {
            if (nameBox.Text.Equals("")) {nameBox.Text = "Car Name"; nameBox.ForeColor = Color.Gray; }
        }

        private void Color_Leave(object sender, EventArgs e)
        {
            if (color.Text.Equals("")) { color.Text = "Color"; color.ForeColor = Color.Gray; }
        }

        private void RelDate_Leave(object sender, EventArgs e)
        {
            if (relDate.Text.Equals("")) {relDate.Text = "Release Date"; relDate.ForeColor = Color.Gray; }
        }

        private void Price_Leave(object sender, EventArgs e)
        {
            if (price.Text.Equals("")) { price.Text = "Price"; price.ForeColor = Color.Gray; }
        }

        private void IdSearch_Leave(object sender, EventArgs e)
        {
            if (idSearch.Text.Equals("")) {idSearch.Text = "ID"; idSearch.ForeColor = Color.Gray; }
        }

        private void NameUp_Leave(object sender, EventArgs e)
        {
            if (nameUp.Text.Equals("")) {nameUp.Text = "Name"; nameUp.ForeColor = Color.Gray; }
        }

        private void ColorUp_Leave(object sender, EventArgs e)
        {
            if (colorUp.Text.Equals("")) {colorUp.Text = "Color"; colorUp.ForeColor = Color.Gray; }
        }

        private void PriceUp_Leave(object sender, EventArgs e)
        {
            if (priceUp.Text.Equals("")) {priceUp.Text = "Price"; priceUp.ForeColor = Color.Gray; }
        }

        int i = 0;
        private void Insert_Click(object sender, EventArgs e)
        {
            ListViewItem carList = new ListViewItem();
            carList.Text = idBox.Text;
            carList.SubItems.Add(nameBox.Text);
            carList.SubItems.Add(color.Text);
            carList.SubItems.Add(relDate.Text);
            carList.SubItems.Add("$" + price.Text);

            _ = newModel.Checked ? carList.SubItems.Add(newModel.Text) : carList.SubItems.Add(oldModel.Text);

            cList.Items.Add(carList);

            idBox.Text = "ID";
            nameBox.Text = "Car Name";
            color.Text = "Color"; color.ForeColor = Color.Gray;
            relDate.Text = "Release Date"; relDate.ForeColor = Color.Gray;
            price.Text = "Price"; price.ForeColor = Color.Gray;
            _ = newModel.Checked ? newModel.Checked = false : oldModel.Checked = false;
        }

        private void ScretchMode_CheckedChanged(object sender, EventArgs e)
        {
            pBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void CList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            foreach(ListViewItem item in cList.SelectedItems)
            {
                if(item.SubItems[1].Text == "Mercedes")
                    pBox.Image = Image.FromFile(@"C:\Users\Elbru\source\repos\CarList\CarList\Cars\mercedes.jpeg");
                if (item.SubItems[1].Text == "BMW")
                    pBox.Image = Image.FromFile(@"C:\Users\Elbru\source\repos\CarList\CarList\Cars\bmw.jpg");
                if (item.SubItems[1].Text == "Land Rover")
                    pBox.Image = Image.FromFile(@"C:\Users\Elbru\source\repos\CarList\CarList\Cars\range.jpg");
            }
        }

        private void RowNums_Click(object sender, EventArgs e)
        {
            rowsNum.Text = "Number of rows: " + cList.Items.Count;
        }

        private void EnableChkBox_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = true;
            cList.CheckBoxes = true;
        }

        private void DeleteRows_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in cList.CheckedItems)
            {
                cList.Items.Remove(item);
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in cList.Items)
            {
                if(item.Text.Equals(idSearch.Text))
                {
                    nameUp.Text = item.SubItems[1].Text; nameUp.ForeColor = Color.Black;
                    colorUp.Text = item.SubItems[2].Text; colorUp.ForeColor = Color.Black;
                    priceUp.Text = item.SubItems[4].Text; priceUp.ForeColor = Color.Black;
                }
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in cList.Items)
            {
                if (item.ToString().Contains(idSearch.Text))
                {
                    item.SubItems[1].Text = nameUp.Text;
                    item.SubItems[2].Text = colorUp.Text;
                    item.SubItems[4].Text = priceUp.Text;
                }
            }
        }
        bool isChecked = false;
        private void EnableChkBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (enableChkBox.Checked && !isChecked)
            {
                enableChkBox.Checked = false;
                cList.CheckBoxes = false;
            } 
            else
            {
                enableChkBox.Checked = true;
                isChecked = false;
            }
        }
    }
}