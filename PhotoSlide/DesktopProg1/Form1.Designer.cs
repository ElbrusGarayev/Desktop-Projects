namespace DesktopProg1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Open_File = new System.Windows.Forms.Button();
            this.Previous = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.SlideShow = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.BackgroundImage = global::DesktopProg1.Properties.Resources.galaxy_colorful_background_vector_1035_13595;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(205, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(549, 377);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Open_File
            // 
            this.Open_File.BackColor = System.Drawing.Color.Aquamarine;
            this.Open_File.Font = new System.Drawing.Font("Banjax Notched", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open_File.Location = new System.Drawing.Point(349, 457);
            this.Open_File.Name = "Open_File";
            this.Open_File.Size = new System.Drawing.Size(271, 50);
            this.Open_File.TabIndex = 1;
            this.Open_File.Text = "Select Folder";
            this.Open_File.UseVisualStyleBackColor = false;
            this.Open_File.Click += new System.EventHandler(this.Open_File_Click);
            // 
            // Previous
            // 
            this.Previous.BackColor = System.Drawing.Color.PaleGreen;
            this.Previous.Font = new System.Drawing.Font("Banjax Notched", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Previous.Location = new System.Drawing.Point(205, 457);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(138, 50);
            this.Previous.TabIndex = 2;
            this.Previous.Text = "<<Previous";
            this.Previous.UseVisualStyleBackColor = false;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.LightGreen;
            this.Next.Font = new System.Drawing.Font("Banjax Notched", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Next.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Next.Location = new System.Drawing.Point(623, 457);
            this.Next.Margin = new System.Windows.Forms.Padding(0);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(131, 50);
            this.Next.TabIndex = 3;
            this.Next.Text = "Next>>";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // SlideShow
            // 
            this.SlideShow.BackColor = System.Drawing.Color.Aqua;
            this.SlideShow.Font = new System.Drawing.Font("Banjax Notched", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlideShow.Location = new System.Drawing.Point(205, 513);
            this.SlideShow.Name = "SlideShow";
            this.SlideShow.Size = new System.Drawing.Size(549, 49);
            this.SlideShow.TabIndex = 4;
            this.SlideShow.Text = "<<Start Slide Show>>";
            this.SlideShow.UseVisualStyleBackColor = false;
            this.SlideShow.Click += new System.EventHandler(this.SlideShow_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::DesktopProg1.Properties.Resources.Elfdalian_Ancient_Viking_Forest;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(971, 654);
            this.Controls.Add(this.SlideShow);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.Open_File);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Open_File;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button SlideShow;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Timer timer1;
    }
}

