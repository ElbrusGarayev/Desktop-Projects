namespace EventsTask
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
            this.components = new System.ComponentModel.Container();
            this.building = new System.Windows.Forms.Panel();
            this.midFloor1 = new System.Windows.Forms.Panel();
            this.downFloor2 = new System.Windows.Forms.Panel();
            this.upFloor2 = new System.Windows.Forms.Panel();
            this.downFloor1 = new System.Windows.Forms.Panel();
            this.midFloor2 = new System.Windows.Forms.Panel();
            this.upFloor1 = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.floor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numsOfRec = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.gpa = new System.Windows.Forms.TextBox();
            this.eraser = new System.Windows.Forms.Button();
            this.brush = new System.Windows.Forms.Button();
            this.whiteBoard = new System.Windows.Forms.PictureBox();
            this.down = new System.Windows.Forms.Button();
            this.up = new System.Windows.Forms.Button();
            this.elevator = new System.Windows.Forms.Panel();
            this.building.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.whiteBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // building
            // 
            this.building.BackColor = System.Drawing.Color.PaleGreen;
            this.building.Controls.Add(this.midFloor1);
            this.building.Controls.Add(this.elevator);
            this.building.Controls.Add(this.downFloor2);
            this.building.Controls.Add(this.upFloor2);
            this.building.Controls.Add(this.downFloor1);
            this.building.Controls.Add(this.midFloor2);
            this.building.Controls.Add(this.upFloor1);
            this.building.Location = new System.Drawing.Point(544, 86);
            this.building.Name = "building";
            this.building.Size = new System.Drawing.Size(259, 347);
            this.building.TabIndex = 0;
            // 
            // midFloor1
            // 
            this.midFloor1.BackColor = System.Drawing.Color.DimGray;
            this.midFloor1.Location = new System.Drawing.Point(0, 115);
            this.midFloor1.Name = "midFloor1";
            this.midFloor1.Size = new System.Drawing.Size(78, 115);
            this.midFloor1.TabIndex = 2;
            // 
            // downFloor2
            // 
            this.downFloor2.BackColor = System.Drawing.Color.Blue;
            this.downFloor2.Location = new System.Drawing.Point(178, 230);
            this.downFloor2.Name = "downFloor2";
            this.downFloor2.Size = new System.Drawing.Size(81, 118);
            this.downFloor2.TabIndex = 3;
            // 
            // upFloor2
            // 
            this.upFloor2.BackColor = System.Drawing.Color.Blue;
            this.upFloor2.Location = new System.Drawing.Point(178, 0);
            this.upFloor2.Name = "upFloor2";
            this.upFloor2.Size = new System.Drawing.Size(81, 115);
            this.upFloor2.TabIndex = 1;
            // 
            // downFloor1
            // 
            this.downFloor1.BackColor = System.Drawing.Color.Blue;
            this.downFloor1.Location = new System.Drawing.Point(0, 230);
            this.downFloor1.Name = "downFloor1";
            this.downFloor1.Size = new System.Drawing.Size(78, 118);
            this.downFloor1.TabIndex = 3;
            // 
            // midFloor2
            // 
            this.midFloor2.BackColor = System.Drawing.Color.DimGray;
            this.midFloor2.Location = new System.Drawing.Point(178, 115);
            this.midFloor2.Name = "midFloor2";
            this.midFloor2.Size = new System.Drawing.Size(81, 115);
            this.midFloor2.TabIndex = 3;
            // 
            // upFloor1
            // 
            this.upFloor1.BackColor = System.Drawing.Color.Blue;
            this.upFloor1.Location = new System.Drawing.Point(0, 0);
            this.upFloor1.Name = "upFloor1";
            this.upFloor1.Size = new System.Drawing.Size(78, 115);
            this.upFloor1.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(588, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elevator";
            // 
            // floor
            // 
            this.floor.AutoSize = true;
            this.floor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.floor.Location = new System.Drawing.Point(825, 249);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(82, 24);
            this.floor.TabIndex = 3;
            this.floor.Text = "Floor: 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name/Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone Number(+994)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "GPA:";
            // 
            // numsOfRec
            // 
            this.numsOfRec.AutoSize = true;
            this.numsOfRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numsOfRec.Location = new System.Drawing.Point(12, 228);
            this.numsOfRec.Name = "numsOfRec";
            this.numsOfRec.Size = new System.Drawing.Size(184, 20);
            this.numsOfRec.TabIndex = 8;
            this.numsOfRec.Text = "Number of Records: 0";
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.add.Location = new System.Drawing.Point(204, 215);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(146, 38);
            this.add.TabIndex = 9;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name.Location = new System.Drawing.Point(204, 57);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(146, 26);
            this.name.TabIndex = 10;
            this.name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_KeyPress);
            this.name.Validating += new System.ComponentModel.CancelEventHandler(this.Name_Validating);
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.email.Location = new System.Drawing.Point(204, 101);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(146, 26);
            this.email.TabIndex = 11;
            this.email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Email_KeyPress);
            this.email.Validating += new System.ComponentModel.CancelEventHandler(this.Email_Validating);
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phone.Location = new System.Drawing.Point(204, 145);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(146, 26);
            this.phone.TabIndex = 12;
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Phone_KeyPress);
            this.phone.Validating += new System.ComponentModel.CancelEventHandler(this.Phone_Validating);
            // 
            // gpa
            // 
            this.gpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gpa.Location = new System.Drawing.Point(204, 183);
            this.gpa.Name = "gpa";
            this.gpa.Size = new System.Drawing.Size(146, 26);
            this.gpa.TabIndex = 13;
            this.gpa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Gpa_KeyPress);
            this.gpa.Validating += new System.ComponentModel.CancelEventHandler(this.Gpa_Validating);
            // 
            // eraser
            // 
            this.eraser.BackgroundImage = global::EventsTask.Properties.Resources._1200px_Eraser_icon_svg;
            this.eraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eraser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eraser.Location = new System.Drawing.Point(204, 464);
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(146, 96);
            this.eraser.TabIndex = 16;
            this.eraser.UseVisualStyleBackColor = true;
            this.eraser.Click += new System.EventHandler(this.Eraser_Click);
            // 
            // brush
            // 
            this.brush.BackgroundImage = global::EventsTask.Properties.Resources._30_300536_paint_brush_icon_png_clipart_png_download_paint;
            this.brush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.brush.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.brush.Location = new System.Drawing.Point(16, 464);
            this.brush.Name = "brush";
            this.brush.Size = new System.Drawing.Size(133, 96);
            this.brush.TabIndex = 15;
            this.brush.UseVisualStyleBackColor = true;
            this.brush.Click += new System.EventHandler(this.Brush_Click);
            // 
            // whiteBoard
            // 
            this.whiteBoard.BackColor = System.Drawing.Color.White;
            this.whiteBoard.Location = new System.Drawing.Point(16, 270);
            this.whiteBoard.Name = "whiteBoard";
            this.whiteBoard.Size = new System.Drawing.Size(334, 175);
            this.whiteBoard.TabIndex = 14;
            this.whiteBoard.TabStop = false;
            this.whiteBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WhiteBoard_MouseDown);
            this.whiteBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WhiteBoard_MouseMove);
            this.whiteBoard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WhiteBoard_MouseUp);
            // 
            // down
            // 
            this.down.BackgroundImage = global::EventsTask.Properties.Resources.arrow_down;
            this.down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.down.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.down.Location = new System.Drawing.Point(419, 270);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(101, 107);
            this.down.TabIndex = 2;
            this.down.UseVisualStyleBackColor = true;
            this.down.Click += new System.EventHandler(this.Down_Click);
            // 
            // up
            // 
            this.up.BackgroundImage = global::EventsTask.Properties.Resources.arrow_up;
            this.up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.up.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.up.Location = new System.Drawing.Point(419, 157);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(101, 107);
            this.up.TabIndex = 1;
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.Up_Click);
            // 
            // elevator
            // 
            this.elevator.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.elevator.BackgroundImage = global::EventsTask.Properties.Resources.img_572708;
            this.elevator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.elevator.Location = new System.Drawing.Point(78, 115);
            this.elevator.Name = "elevator";
            this.elevator.Size = new System.Drawing.Size(100, 115);
            this.elevator.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 572);
            this.Controls.Add(this.eraser);
            this.Controls.Add(this.brush);
            this.Controls.Add(this.whiteBoard);
            this.Controls.Add(this.gpa);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.email);
            this.Controls.Add(this.name);
            this.Controls.Add(this.add);
            this.Controls.Add(this.numsOfRec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.down);
            this.Controls.Add(this.up);
            this.Controls.Add(this.building);
            this.Name = "Form1";
            this.Text = "Form1";
            this.building.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.whiteBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel building;
        private System.Windows.Forms.Panel midFloor1;
        private System.Windows.Forms.Panel elevator;
        private System.Windows.Forms.Panel downFloor2;
        private System.Windows.Forms.Panel upFloor2;
        private System.Windows.Forms.Panel downFloor1;
        private System.Windows.Forms.Panel midFloor2;
        private System.Windows.Forms.Panel upFloor1;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label floor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label numsOfRec;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox gpa;
        private System.Windows.Forms.PictureBox whiteBoard;
        private System.Windows.Forms.Button brush;
        private System.Windows.Forms.Button eraser;
    }
}

