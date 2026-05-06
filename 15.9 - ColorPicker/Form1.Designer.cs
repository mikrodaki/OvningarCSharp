namespace ColorPicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			redScrollBar = new VScrollBar();
			lblRedNumber = new Label();
			lblRed = new Label();
			lblGreen = new Label();
			lblGreenNumber = new Label();
			vScrollBar2 = new VScrollBar();
			lblBlue = new Label();
			lblBlueNumber = new Label();
			blueScrollBar = new VScrollBar();
			pictureBox1 = new PictureBox();
			pictureBox2 = new PictureBox();
			pictureBox3 = new PictureBox();
			pictureBox4 = new PictureBox();
			pictureBox5 = new PictureBox();
			pictureBox6 = new PictureBox();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			button4 = new Button();
			button5 = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
			SuspendLayout();
			// 
			// redScrollBar
			// 
			redScrollBar.Location = new Point(832, 78);
			redScrollBar.Maximum = 264;
			redScrollBar.Name = "redScrollBar";
			redScrollBar.Size = new Size(50, 330);
			redScrollBar.TabIndex = 0;
			redScrollBar.Scroll += redScrollBar_Scroll;
			// 
			// lblRedNumber
			// 
			lblRedNumber.AutoSize = true;
			lblRedNumber.Location = new Point(832, 438);
			lblRedNumber.Margin = new Padding(4, 0, 4, 0);
			lblRedNumber.MinimumSize = new Size(50, 0);
			lblRedNumber.Name = "lblRedNumber";
			lblRedNumber.Size = new Size(50, 25);
			lblRedNumber.TabIndex = 1;
			lblRedNumber.Text = "0";
			lblRedNumber.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblRed
			// 
			lblRed.AutoSize = true;
			lblRed.Location = new Point(832, 27);
			lblRed.Margin = new Padding(4, 0, 4, 0);
			lblRed.MinimumSize = new Size(50, 0);
			lblRed.Name = "lblRed";
			lblRed.Size = new Size(50, 25);
			lblRed.TabIndex = 2;
			lblRed.Text = "Röd";
			lblRed.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblGreen
			// 
			lblGreen.AutoSize = true;
			lblGreen.Location = new Point(928, 27);
			lblGreen.Margin = new Padding(4, 0, 4, 0);
			lblGreen.MinimumSize = new Size(50, 0);
			lblGreen.Name = "lblGreen";
			lblGreen.Size = new Size(51, 25);
			lblGreen.TabIndex = 5;
			lblGreen.Text = "Grön";
			lblGreen.TextAlign = ContentAlignment.MiddleCenter;
			lblGreen.Click += lblGreen_Click;
			// 
			// lblGreenNumber
			// 
			lblGreenNumber.AutoSize = true;
			lblGreenNumber.Location = new Point(928, 438);
			lblGreenNumber.Margin = new Padding(4, 0, 4, 0);
			lblGreenNumber.MinimumSize = new Size(50, 0);
			lblGreenNumber.Name = "lblGreenNumber";
			lblGreenNumber.Size = new Size(50, 25);
			lblGreenNumber.TabIndex = 4;
			lblGreenNumber.Text = "0";
			lblGreenNumber.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// vScrollBar2
			// 
			vScrollBar2.Location = new Point(928, 78);
			vScrollBar2.Maximum = 264;
			vScrollBar2.Name = "vScrollBar2";
			vScrollBar2.Size = new Size(50, 330);
			vScrollBar2.TabIndex = 3;
			vScrollBar2.Scroll += greenScrollBar_Scroll;
			// 
			// lblBlue
			// 
			lblBlue.AutoSize = true;
			lblBlue.Location = new Point(1015, 27);
			lblBlue.Margin = new Padding(4, 0, 4, 0);
			lblBlue.MinimumSize = new Size(50, 0);
			lblBlue.Name = "lblBlue";
			lblBlue.Size = new Size(50, 25);
			lblBlue.TabIndex = 8;
			lblBlue.Text = "Blå";
			lblBlue.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblBlueNumber
			// 
			lblBlueNumber.AutoSize = true;
			lblBlueNumber.Location = new Point(1015, 438);
			lblBlueNumber.Margin = new Padding(4, 0, 4, 0);
			lblBlueNumber.MinimumSize = new Size(50, 0);
			lblBlueNumber.Name = "lblBlueNumber";
			lblBlueNumber.Size = new Size(50, 25);
			lblBlueNumber.TabIndex = 7;
			lblBlueNumber.Text = "0";
			lblBlueNumber.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// blueScrollBar
			// 
			blueScrollBar.Location = new Point(1015, 78);
			blueScrollBar.Maximum = 264;
			blueScrollBar.Name = "blueScrollBar";
			blueScrollBar.Size = new Size(50, 330);
			blueScrollBar.TabIndex = 6;
			blueScrollBar.Scroll += blueScrollBar_Scroll;
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.Black;
			pictureBox1.Location = new Point(50, 78);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(722, 330);
			pictureBox1.TabIndex = 9;
			pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			pictureBox2.Location = new Point(51, 436);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(116, 75);
			pictureBox2.TabIndex = 10;
			pictureBox2.TabStop = false;
			pictureBox2.Click += pictureBox2_Click;
			// 
			// pictureBox3
			// 
			pictureBox3.Location = new Point(202, 436);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(116, 75);
			pictureBox3.TabIndex = 11;
			pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			pictureBox4.Location = new Point(356, 436);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(116, 75);
			pictureBox4.TabIndex = 12;
			pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			pictureBox5.Location = new Point(506, 436);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new Size(116, 75);
			pictureBox5.TabIndex = 13;
			pictureBox5.TabStop = false;
			// 
			// pictureBox6
			// 
			pictureBox6.Location = new Point(656, 436);
			pictureBox6.Name = "pictureBox6";
			pictureBox6.Size = new Size(116, 75);
			pictureBox6.TabIndex = 14;
			pictureBox6.TabStop = false;
			// 
			// button1
			// 
			button1.Location = new Point(55, 528);
			button1.Name = "button1";
			button1.Size = new Size(112, 34);
			button1.TabIndex = 15;
			button1.Text = "Spara";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(202, 528);
			button2.Name = "button2";
			button2.Size = new Size(112, 34);
			button2.TabIndex = 16;
			button2.Text = "Spara";
			button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.Location = new Point(356, 528);
			button3.Name = "button3";
			button3.Size = new Size(112, 34);
			button3.TabIndex = 17;
			button3.Text = "Spara";
			button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			button4.Location = new Point(506, 528);
			button4.Name = "button4";
			button4.Size = new Size(112, 34);
			button4.TabIndex = 18;
			button4.Text = "Spara";
			button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			button5.Location = new Point(656, 528);
			button5.Name = "button5";
			button5.Size = new Size(112, 34);
			button5.TabIndex = 19;
			button5.Text = "Spara";
			button5.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveBorder;
			ClientSize = new Size(1105, 588);
			Controls.Add(button5);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(pictureBox6);
			Controls.Add(pictureBox5);
			Controls.Add(pictureBox4);
			Controls.Add(pictureBox3);
			Controls.Add(pictureBox2);
			Controls.Add(pictureBox1);
			Controls.Add(lblBlue);
			Controls.Add(lblBlueNumber);
			Controls.Add(blueScrollBar);
			Controls.Add(lblGreen);
			Controls.Add(lblGreenNumber);
			Controls.Add(vScrollBar2);
			Controls.Add(lblRed);
			Controls.Add(lblRedNumber);
			Controls.Add(redScrollBar);
			Margin = new Padding(4);
			Name = "Form1";
			Text = "ColorPicker";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private VScrollBar redScrollBar;
        private Label lblRedNumber;
		private Label lblRed;
		private Label lblGreen;
		private Label lblGreenNumber;
		private VScrollBar vScrollBar2;
		private Label lblBlue;
		private Label lblBlueNumber;
		private VScrollBar blueScrollBar;
		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
		private PictureBox pictureBox3;
		private PictureBox pictureBox4;
		private PictureBox pictureBox5;
		private PictureBox pictureBox6;
		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
		private Button button5;
	}
}
