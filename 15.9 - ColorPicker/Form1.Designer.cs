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
            greenScrollBar = new VScrollBar();
            lblBlue = new Label();
            lblBlueNumber = new Label();
            blueScrollBar = new VScrollBar();
            pictureBoxLarge = new PictureBox();
            pictureBoxSmall1 = new PictureBox();
            pictureBoxSmall2 = new PictureBox();
            pictureBoxSmall3 = new PictureBox();
            pictureBoxSmall4 = new PictureBox();
            pictureBoxSmall5 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLarge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSmall1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSmall2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSmall3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSmall4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSmall5).BeginInit();
            SuspendLayout();
            // 
            // redScrollBar
            // 
            redScrollBar.Location = new Point(666, 62);
            redScrollBar.Maximum = 264;
            redScrollBar.Name = "redScrollBar";
            redScrollBar.Size = new Size(50, 264);
            redScrollBar.TabIndex = 0;
            redScrollBar.Scroll += redScrollBar_Scroll;
            // 
            // lblRedNumber
            // 
            lblRedNumber.AutoSize = true;
            lblRedNumber.Location = new Point(666, 350);
            lblRedNumber.MinimumSize = new Size(40, 0);
            lblRedNumber.Name = "lblRedNumber";
            lblRedNumber.Size = new Size(40, 20);
            lblRedNumber.TabIndex = 1;
            lblRedNumber.Text = "0";
            lblRedNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRed
            // 
            lblRed.AutoSize = true;
            lblRed.Location = new Point(666, 22);
            lblRed.MinimumSize = new Size(40, 0);
            lblRed.Name = "lblRed";
            lblRed.Size = new Size(40, 20);
            lblRed.TabIndex = 2;
            lblRed.Text = "Röd";
            lblRed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGreen
            // 
            lblGreen.AutoSize = true;
            lblGreen.Location = new Point(742, 22);
            lblGreen.MinimumSize = new Size(40, 0);
            lblGreen.Name = "lblGreen";
            lblGreen.Size = new Size(41, 20);
            lblGreen.TabIndex = 5;
            lblGreen.Text = "Grön";
            lblGreen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGreenNumber
            // 
            lblGreenNumber.AutoSize = true;
            lblGreenNumber.Location = new Point(742, 350);
            lblGreenNumber.MinimumSize = new Size(40, 0);
            lblGreenNumber.Name = "lblGreenNumber";
            lblGreenNumber.Size = new Size(40, 20);
            lblGreenNumber.TabIndex = 4;
            lblGreenNumber.Text = "0";
            lblGreenNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // greenScrollBar
            // 
            greenScrollBar.Location = new Point(742, 62);
            greenScrollBar.Maximum = 264;
            greenScrollBar.Name = "greenScrollBar";
            greenScrollBar.Size = new Size(50, 264);
            greenScrollBar.TabIndex = 3;
            greenScrollBar.Scroll += greenScrollBar_Scroll;
            // 
            // lblBlue
            // 
            lblBlue.AutoSize = true;
            lblBlue.Location = new Point(812, 22);
            lblBlue.MinimumSize = new Size(40, 0);
            lblBlue.Name = "lblBlue";
            lblBlue.Size = new Size(40, 20);
            lblBlue.TabIndex = 8;
            lblBlue.Text = "Blå";
            lblBlue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBlueNumber
            // 
            lblBlueNumber.AutoSize = true;
            lblBlueNumber.Location = new Point(812, 350);
            lblBlueNumber.MinimumSize = new Size(40, 0);
            lblBlueNumber.Name = "lblBlueNumber";
            lblBlueNumber.Size = new Size(40, 20);
            lblBlueNumber.TabIndex = 7;
            lblBlueNumber.Text = "0";
            lblBlueNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // blueScrollBar
            // 
            blueScrollBar.Location = new Point(812, 62);
            blueScrollBar.Maximum = 264;
            blueScrollBar.Name = "blueScrollBar";
            blueScrollBar.Size = new Size(50, 264);
            blueScrollBar.TabIndex = 6;
            blueScrollBar.Scroll += blueScrollBar_Scroll;
            // 
            // pictureBoxLarge
            // 
            pictureBoxLarge.BackColor = Color.Black;
            pictureBoxLarge.Location = new Point(40, 62);
            pictureBoxLarge.Margin = new Padding(2);
            pictureBoxLarge.Name = "pictureBoxLarge";
            pictureBoxLarge.Size = new Size(578, 264);
            pictureBoxLarge.TabIndex = 9;
            pictureBoxLarge.TabStop = false;
            // 
            // pictureBoxSmall1
            // 
            pictureBoxSmall1.Location = new Point(41, 349);
            pictureBoxSmall1.Margin = new Padding(2);
            pictureBoxSmall1.Name = "pictureBoxSmall1";
            pictureBoxSmall1.Size = new Size(93, 60);
            pictureBoxSmall1.TabIndex = 10;
            pictureBoxSmall1.TabStop = false;
            pictureBoxSmall1.Click += pictureBoxSmall1_Click;
            // 
            // pictureBoxSmall2
            // 
            pictureBoxSmall2.Location = new Point(162, 349);
            pictureBoxSmall2.Margin = new Padding(2);
            pictureBoxSmall2.Name = "pictureBoxSmall2";
            pictureBoxSmall2.Size = new Size(93, 60);
            pictureBoxSmall2.TabIndex = 11;
            pictureBoxSmall2.TabStop = false;
            pictureBoxSmall2.Click += pictureBoxSmall2_Click;
            // 
            // pictureBoxSmall3
            // 
            pictureBoxSmall3.Location = new Point(285, 349);
            pictureBoxSmall3.Margin = new Padding(2);
            pictureBoxSmall3.Name = "pictureBoxSmall3";
            pictureBoxSmall3.Size = new Size(93, 60);
            pictureBoxSmall3.TabIndex = 12;
            pictureBoxSmall3.TabStop = false;
            pictureBoxSmall3.Click += pictureBoxSmall3_Click;
            // 
            // pictureBoxSmall4
            // 
            pictureBoxSmall4.Location = new Point(405, 349);
            pictureBoxSmall4.Margin = new Padding(2);
            pictureBoxSmall4.Name = "pictureBoxSmall4";
            pictureBoxSmall4.Size = new Size(93, 60);
            pictureBoxSmall4.TabIndex = 13;
            pictureBoxSmall4.TabStop = false;
            pictureBoxSmall4.Click += pictureBoxSmall4_Click;
            // 
            // pictureBoxSmall5
            // 
            pictureBoxSmall5.Location = new Point(525, 349);
            pictureBoxSmall5.Margin = new Padding(2);
            pictureBoxSmall5.Name = "pictureBoxSmall5";
            pictureBoxSmall5.Size = new Size(93, 60);
            pictureBoxSmall5.TabIndex = 14;
            pictureBoxSmall5.TabStop = false;
            pictureBoxSmall5.Click += pictureBoxSmall5_Click;
            // 
            // button1
            // 
            button1.Location = new Point(44, 422);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(90, 27);
            button1.TabIndex = 15;
            button1.Text = "Spara";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(162, 422);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(90, 27);
            button2.TabIndex = 16;
            button2.Text = "Spara";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(285, 422);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(90, 27);
            button3.TabIndex = 17;
            button3.Text = "Spara";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(405, 422);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(90, 27);
            button4.TabIndex = 18;
            button4.Text = "Spara";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(525, 422);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(90, 27);
            button5.TabIndex = 19;
            button5.Text = "Spara";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(884, 470);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBoxSmall5);
            Controls.Add(pictureBoxSmall4);
            Controls.Add(pictureBoxSmall3);
            Controls.Add(pictureBoxSmall2);
            Controls.Add(pictureBoxSmall1);
            Controls.Add(pictureBoxLarge);
            Controls.Add(lblBlue);
            Controls.Add(lblBlueNumber);
            Controls.Add(blueScrollBar);
            Controls.Add(lblGreen);
            Controls.Add(lblGreenNumber);
            Controls.Add(greenScrollBar);
            Controls.Add(lblRed);
            Controls.Add(lblRedNumber);
            Controls.Add(redScrollBar);
            Name = "Form1";
            Text = "ColorPicker";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLarge).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSmall1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSmall2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSmall3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSmall4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSmall5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private VScrollBar redScrollBar;
        private Label lblRedNumber;
		private Label lblRed;
		private Label lblGreen;
		private Label lblGreenNumber;
		private VScrollBar greenScrollBar;
		private Label lblBlue;
		private Label lblBlueNumber;
		private VScrollBar blueScrollBar;
		private PictureBox pictureBoxLarge;
		private PictureBox pictureBoxSmall1;
		private PictureBox pictureBoxSmall2;
		private PictureBox pictureBoxSmall3;
		private PictureBox pictureBoxSmall4;
		private PictureBox pictureBoxSmall5;
		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
		private Button button5;
	}
}
