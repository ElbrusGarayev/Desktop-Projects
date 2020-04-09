namespace CarList
{
    partial class carList
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
            this.components = new System.ComponentModel.Container();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.insert = new System.Windows.Forms.Button();
            this.RowNums = new System.Windows.Forms.Button();
            this.deleteRows = new System.Windows.Forms.Button();
            this.scretchMode = new System.Windows.Forms.RadioButton();
            this.enableChkBox = new System.Windows.Forms.RadioButton();
            this.idBox = new System.Windows.Forms.ComboBox();
            this.nameBox = new System.Windows.Forms.ComboBox();
            this.color = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.relDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nameUp = new System.Windows.Forms.TextBox();
            this.colorUp = new System.Windows.Forms.TextBox();
            this.priceUp = new System.Windows.Forms.TextBox();
            this.idSearch = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.newModel = new System.Windows.Forms.RadioButton();
            this.oldModel = new System.Windows.Forms.RadioButton();
            this.cList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rowsNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pBox
            // 
            this.pBox.BackColor = System.Drawing.Color.Transparent;
            this.pBox.Location = new System.Drawing.Point(624, 85);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(317, 200);
            this.pBox.TabIndex = 1;
            this.pBox.TabStop = false;
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.SystemColors.Control;
            this.insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.insert.Location = new System.Drawing.Point(624, 16);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(317, 49);
            this.insert.TabIndex = 2;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // RowNums
            // 
            this.RowNums.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RowNums.Location = new System.Drawing.Point(354, 477);
            this.RowNums.Name = "RowNums";
            this.RowNums.Size = new System.Drawing.Size(164, 49);
            this.RowNums.TabIndex = 3;
            this.RowNums.Text = "Show Number of Rows";
            this.RowNums.UseVisualStyleBackColor = true;
            this.RowNums.Click += new System.EventHandler(this.RowNums_Click);
            // 
            // deleteRows
            // 
            this.deleteRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteRows.Location = new System.Drawing.Point(624, 325);
            this.deleteRows.Name = "deleteRows";
            this.deleteRows.Size = new System.Drawing.Size(317, 65);
            this.deleteRows.TabIndex = 4;
            this.deleteRows.Text = "Delete Checked Rows";
            this.deleteRows.UseVisualStyleBackColor = true;
            this.deleteRows.Click += new System.EventHandler(this.DeleteRows_Click);
            // 
            // scretchMode
            // 
            this.scretchMode.AutoSize = true;
            this.scretchMode.BackColor = System.Drawing.Color.DarkGray;
            this.scretchMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scretchMode.Location = new System.Drawing.Point(798, 295);
            this.scretchMode.Name = "scretchMode";
            this.scretchMode.Size = new System.Drawing.Size(143, 24);
            this.scretchMode.TabIndex = 5;
            this.scretchMode.Text = "Scretch Mode";
            this.scretchMode.UseVisualStyleBackColor = false;
            this.scretchMode.CheckedChanged += new System.EventHandler(this.ScretchMode_CheckedChanged);
            // 
            // enableChkBox
            // 
            this.enableChkBox.AutoSize = true;
            this.enableChkBox.BackColor = System.Drawing.Color.DarkGray;
            this.enableChkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.enableChkBox.Location = new System.Drawing.Point(624, 295);
            this.enableChkBox.Name = "enableChkBox";
            this.enableChkBox.Size = new System.Drawing.Size(171, 24);
            this.enableChkBox.TabIndex = 6;
            this.enableChkBox.Text = "Enable Checkbox";
            this.enableChkBox.UseVisualStyleBackColor = false;
            this.enableChkBox.CheckedChanged += new System.EventHandler(this.EnableChkBox_CheckedChanged);
            this.enableChkBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EnableChkBox_MouseClick);
            // 
            // idBox
            // 
            this.idBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.idBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.idBox.FormattingEnabled = true;
            this.idBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.idBox.Location = new System.Drawing.Point(26, 12);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(59, 24);
            this.idBox.TabIndex = 7;
            this.idBox.Text = "ID";
            this.idBox.Enter += new System.EventHandler(this.IdBox_Enter);
            this.idBox.Leave += new System.EventHandler(this.IdBox_Leave);
            // 
            // nameBox
            // 
            this.nameBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.nameBox.FormattingEnabled = true;
            this.nameBox.Items.AddRange(new object[] {
            "Mercedes",
            "BMW",
            "Land Rover"});
            this.nameBox.Location = new System.Drawing.Point(91, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(111, 24);
            this.nameBox.TabIndex = 8;
            this.nameBox.Text = "Car Name";
            this.nameBox.Enter += new System.EventHandler(this.NameBox_Enter);
            this.nameBox.Leave += new System.EventHandler(this.NameBox_Leave);
            // 
            // color
            // 
            this.color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.color.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.color.Location = new System.Drawing.Point(208, 12);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(100, 22);
            this.color.TabIndex = 9;
            this.color.Text = "Color";
            this.color.Enter += new System.EventHandler(this.Color_Enter);
            this.color.Leave += new System.EventHandler(this.Color_Leave);
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.price.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.price.Location = new System.Drawing.Point(175, 42);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(133, 23);
            this.price.TabIndex = 10;
            this.price.Text = "Price";
            this.price.Enter += new System.EventHandler(this.Price_Enter);
            this.price.Leave += new System.EventHandler(this.Price_Leave);
            // 
            // relDate
            // 
            this.relDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.relDate.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.relDate.Location = new System.Drawing.Point(26, 42);
            this.relDate.Name = "relDate";
            this.relDate.Size = new System.Drawing.Size(143, 23);
            this.relDate.TabIndex = 11;
            this.relDate.Text = "Release Date";
            this.relDate.Enter += new System.EventHandler(this.RelDate_Enter);
            this.relDate.Leave += new System.EventHandler(this.RelDate_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Update Panel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(332, 578);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Current Date/Time:";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date.Location = new System.Drawing.Point(549, 578);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(119, 25);
            this.date.TabIndex = 15;
            this.date.Text = "Date Time";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // nameUp
            // 
            this.nameUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameUp.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.nameUp.Location = new System.Drawing.Point(177, 455);
            this.nameUp.Name = "nameUp";
            this.nameUp.Size = new System.Drawing.Size(131, 26);
            this.nameUp.TabIndex = 17;
            this.nameUp.Text = "Name";
            this.nameUp.Enter += new System.EventHandler(this.NameUp_Enter);
            this.nameUp.Leave += new System.EventHandler(this.NameUp_Leave);
            // 
            // colorUp
            // 
            this.colorUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colorUp.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.colorUp.Location = new System.Drawing.Point(177, 487);
            this.colorUp.Name = "colorUp";
            this.colorUp.Size = new System.Drawing.Size(131, 26);
            this.colorUp.TabIndex = 18;
            this.colorUp.Text = "Color";
            this.colorUp.Enter += new System.EventHandler(this.ColorUp_Enter);
            this.colorUp.Leave += new System.EventHandler(this.ColorUp_Leave);
            // 
            // priceUp
            // 
            this.priceUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.priceUp.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.priceUp.Location = new System.Drawing.Point(177, 519);
            this.priceUp.Name = "priceUp";
            this.priceUp.Size = new System.Drawing.Size(131, 26);
            this.priceUp.TabIndex = 19;
            this.priceUp.Text = "Price";
            this.priceUp.Enter += new System.EventHandler(this.PriceUp_Enter);
            this.priceUp.Leave += new System.EventHandler(this.PriceUp_Leave);
            // 
            // idSearch
            // 
            this.idSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idSearch.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.idSearch.Location = new System.Drawing.Point(26, 455);
            this.idSearch.Name = "idSearch";
            this.idSearch.Size = new System.Drawing.Size(131, 26);
            this.idSearch.TabIndex = 20;
            this.idSearch.Text = "ID";
            this.idSearch.Enter += new System.EventHandler(this.IdUp_Enter);
            this.idSearch.Leave += new System.EventHandler(this.IdSearch_Leave);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.search.Location = new System.Drawing.Point(26, 506);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(131, 39);
            this.search.TabIndex = 21;
            this.search.Text = "Search ";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.Search_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.update.Location = new System.Drawing.Point(26, 565);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(282, 60);
            this.update.TabIndex = 22;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.Update_Click);
            // 
            // newModel
            // 
            this.newModel.AutoSize = true;
            this.newModel.BackColor = System.Drawing.Color.Transparent;
            this.newModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newModel.Location = new System.Drawing.Point(466, 26);
            this.newModel.Name = "newModel";
            this.newModel.Size = new System.Drawing.Size(134, 28);
            this.newModel.TabIndex = 23;
            this.newModel.TabStop = true;
            this.newModel.Text = "New Model";
            this.newModel.UseVisualStyleBackColor = false;
            // 
            // oldModel
            // 
            this.oldModel.AutoSize = true;
            this.oldModel.BackColor = System.Drawing.Color.Transparent;
            this.oldModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oldModel.Location = new System.Drawing.Point(314, 26);
            this.oldModel.Name = "oldModel";
            this.oldModel.Size = new System.Drawing.Size(125, 28);
            this.oldModel.TabIndex = 24;
            this.oldModel.TabStop = true;
            this.oldModel.Text = "Old Model";
            this.oldModel.UseVisualStyleBackColor = false;
            // 
            // cList
            // 
            this.cList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.cList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cList.FullRowSelect = true;
            this.cList.GridLines = true;
            this.cList.HideSelection = false;
            this.cList.Location = new System.Drawing.Point(26, 85);
            this.cList.Name = "cList";
            this.cList.Size = new System.Drawing.Size(574, 305);
            this.cList.TabIndex = 26;
            this.cList.UseCompatibleStateImageBehavior = false;
            this.cList.View = System.Windows.Forms.View.Details;
            this.cList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.CList_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Color";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Release Date";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Price";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Model";
            this.columnHeader6.Width = 100;
            // 
            // rowsNum
            // 
            this.rowsNum.AutoSize = true;
            this.rowsNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rowsNum.Location = new System.Drawing.Point(549, 488);
            this.rowsNum.Name = "rowsNum";
            this.rowsNum.Size = new System.Drawing.Size(183, 25);
            this.rowsNum.TabIndex = 27;
            this.rowsNum.Text = "Number of rows:";
            // 
            // carList
            // 
            this.AcceptButton = this.insert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarList.Properties.Resources._15_of_the_Worst_Used_Cars_gear_patrol_lead_full;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(987, 636);
            this.Controls.Add(this.rowsNum);
            this.Controls.Add(this.cList);
            this.Controls.Add(this.oldModel);
            this.Controls.Add(this.newModel);
            this.Controls.Add(this.update);
            this.Controls.Add(this.search);
            this.Controls.Add(this.idSearch);
            this.Controls.Add(this.priceUp);
            this.Controls.Add(this.colorUp);
            this.Controls.Add(this.nameUp);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.relDate);
            this.Controls.Add(this.price);
            this.Controls.Add(this.color);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.enableChkBox);
            this.Controls.Add(this.scretchMode);
            this.Controls.Add(this.deleteRows);
            this.Controls.Add(this.RowNums);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.pBox);
            this.Name = "carList";
            this.Text = "Car List";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button RowNums;
        private System.Windows.Forms.Button deleteRows;
        private System.Windows.Forms.RadioButton scretchMode;
        private System.Windows.Forms.RadioButton enableChkBox;
        private System.Windows.Forms.ComboBox idBox;
        private System.Windows.Forms.ComboBox nameBox;
        private System.Windows.Forms.TextBox color;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox relDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox nameUp;
        private System.Windows.Forms.TextBox colorUp;
        private System.Windows.Forms.TextBox priceUp;
        private System.Windows.Forms.TextBox idSearch;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.RadioButton newModel;
        private System.Windows.Forms.RadioButton oldModel;
        private System.Windows.Forms.ListView cList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label rowsNum;
    }
}

