namespace _15._9___ColorPicker
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
            vScrollBar1 = new VScrollBar();
            lblRed = new Label();
            SuspendLayout();
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(450, 62);
            vScrollBar1.Maximum = 264;
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(50, 264);
            vScrollBar1.TabIndex = 0;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // lblRed
            // 
            lblRed.AutoSize = true;
            lblRed.Location = new Point(450, 366);
            lblRed.Name = "lblRed";
            lblRed.Size = new Size(52, 20);
            lblRed.TabIndex = 1;
            lblRed.Text = "lblRed";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 432);
            Controls.Add(lblRed);
            Controls.Add(vScrollBar1);
            Name = "Form1";
            Text = "ColorPicker";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private VScrollBar vScrollBar1;
        private Label lblRed;
    }
}
