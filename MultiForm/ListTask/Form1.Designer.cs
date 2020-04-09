namespace ListTask
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.mark = new System.Windows.Forms.TextBox();
            this.delIndex = new System.Windows.Forms.TextBox();
            this.listSize = new System.Windows.Forms.Label();
            this.listCap = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.showList = new System.Windows.Forms.Button();
            this.delPerson = new System.Windows.Forms.Button();
            this.deleteAll = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Enabled = false;
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.Location = new System.Drawing.Point(68, 42);
            this.name.Margin = new System.Windows.Forms.Padding(5);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(164, 26);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // surname
            // 
            this.surname.Enabled = false;
            this.surname.ForeColor = System.Drawing.Color.Black;
            this.surname.Location = new System.Drawing.Point(68, 132);
            this.surname.Margin = new System.Windows.Forms.Padding(5);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(164, 26);
            this.surname.TabIndex = 1;
            this.surname.Text = "Surname";
            // 
            // mark
            // 
            this.mark.Enabled = false;
            this.mark.ForeColor = System.Drawing.Color.Black;
            this.mark.Location = new System.Drawing.Point(68, 220);
            this.mark.Margin = new System.Windows.Forms.Padding(5);
            this.mark.Name = "mark";
            this.mark.Size = new System.Drawing.Size(164, 26);
            this.mark.TabIndex = 2;
            this.mark.Text = "Mark";
            // 
            // delIndex
            // 
            this.delIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.delIndex.ForeColor = System.Drawing.Color.Gray;
            this.delIndex.Location = new System.Drawing.Point(230, 348);
            this.delIndex.Margin = new System.Windows.Forms.Padding(5);
            this.delIndex.Name = "delIndex";
            this.delIndex.Size = new System.Drawing.Size(125, 32);
            this.delIndex.TabIndex = 3;
            this.delIndex.Text = "Index";
            this.delIndex.Enter += new System.EventHandler(this.DelIndex_Enter);
            this.delIndex.Leave += new System.EventHandler(this.DelIndex_Leave);
            // 
            // listSize
            // 
            this.listSize.AutoSize = true;
            this.listSize.Location = new System.Drawing.Point(399, 98);
            this.listSize.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.listSize.Name = "listSize";
            this.listSize.Size = new System.Drawing.Size(78, 20);
            this.listSize.TabIndex = 4;
            this.listSize.Text = "List Size";
            // 
            // listCap
            // 
            this.listCap.AutoSize = true;
            this.listCap.Location = new System.Drawing.Point(399, 223);
            this.listCap.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.listCap.Name = "listCap";
            this.listCap.Size = new System.Drawing.Size(78, 20);
            this.listCap.TabIndex = 5;
            this.listCap.Text = "Capacity";
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(68, 286);
            this.generate.Margin = new System.Windows.Forms.Padding(5);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(152, 35);
            this.generate.TabIndex = 6;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(230, 286);
            this.add.Margin = new System.Windows.Forms.Padding(5);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(125, 35);
            this.add.TabIndex = 7;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // showList
            // 
            this.showList.Location = new System.Drawing.Point(371, 286);
            this.showList.Margin = new System.Windows.Forms.Padding(5);
            this.showList.Name = "showList";
            this.showList.Size = new System.Drawing.Size(149, 35);
            this.showList.TabIndex = 8;
            this.showList.Text = "Show All List";
            this.showList.UseVisualStyleBackColor = true;
            this.showList.Click += new System.EventHandler(this.ShowList_Click);
            // 
            // delPerson
            // 
            this.delPerson.Location = new System.Drawing.Point(68, 345);
            this.delPerson.Margin = new System.Windows.Forms.Padding(5);
            this.delPerson.Name = "delPerson";
            this.delPerson.Size = new System.Drawing.Size(152, 35);
            this.delPerson.TabIndex = 9;
            this.delPerson.Text = "Delete Person";
            this.delPerson.UseVisualStyleBackColor = true;
            this.delPerson.Click += new System.EventHandler(this.DelPerson_Click);
            // 
            // deleteAll
            // 
            this.deleteAll.Location = new System.Drawing.Point(371, 345);
            this.deleteAll.Margin = new System.Windows.Forms.Padding(5);
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(149, 35);
            this.deleteAll.TabIndex = 10;
            this.deleteAll.Text = "Delete All List";
            this.deleteAll.UseVisualStyleBackColor = true;
            this.deleteAll.Click += new System.EventHandler(this.DeleteAll_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Number of records";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "List Capacity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(578, 441);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deleteAll);
            this.Controls.Add(this.delPerson);
            this.Controls.Add(this.showList);
            this.Controls.Add(this.add);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.listCap);
            this.Controls.Add(this.listSize);
            this.Controls.Add(this.delIndex);
            this.Controls.Add(this.mark);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox mark;
        private System.Windows.Forms.TextBox delIndex;
        private System.Windows.Forms.Label listSize;
        private System.Windows.Forms.Label listCap;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button showList;
        private System.Windows.Forms.Button delPerson;
        private System.Windows.Forms.Button deleteAll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

