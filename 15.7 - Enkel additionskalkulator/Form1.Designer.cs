namespace _15._7___Enkel_additionskalkulator
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
            txtResult = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonClear = new Button();
            buttonAddition = new Button();
            buttonEquals = new Button();
            button0 = new Button();
            buttonDEL = new Button();
            buttonComma = new Button();
            SuspendLayout();
            // 
            // txtResult
            // 
            txtResult.Enabled = false;
            txtResult.Font = new Font("Cascadia Code", 16F);
            txtResult.Location = new Point(29, 39);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(234, 38);
            txtResult.TabIndex = 0;
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 12F);
            button1.Location = new Point(29, 97);
            button1.Name = "button1";
            button1.Size = new Size(74, 65);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Tahoma", 12F);
            button2.Location = new Point(109, 97);
            button2.Name = "button2";
            button2.Size = new Size(74, 65);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Tahoma", 12F);
            button3.Location = new Point(189, 97);
            button3.Name = "button3";
            button3.Size = new Size(74, 65);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Tahoma", 12F);
            button4.Location = new Point(29, 168);
            button4.Name = "button4";
            button4.Size = new Size(74, 65);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Tahoma", 12F);
            button5.Location = new Point(109, 169);
            button5.Name = "button5";
            button5.Size = new Size(74, 65);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Tahoma", 12F);
            button6.Location = new Point(189, 169);
            button6.Name = "button6";
            button6.Size = new Size(74, 65);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Tahoma", 12F);
            button7.Location = new Point(29, 239);
            button7.Name = "button7";
            button7.Size = new Size(74, 65);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Tahoma", 12F);
            button8.Location = new Point(109, 240);
            button8.Name = "button8";
            button8.Size = new Size(74, 65);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Tahoma", 12F);
            button9.Location = new Point(189, 240);
            button9.Name = "button9";
            button9.Size = new Size(74, 65);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Tahoma", 12F);
            buttonClear.Location = new Point(29, 310);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(74, 65);
            buttonClear.TabIndex = 10;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonAddition
            // 
            buttonAddition.Font = new Font("Tahoma", 12F);
            buttonAddition.Location = new Point(189, 310);
            buttonAddition.Name = "buttonAddition";
            buttonAddition.Size = new Size(74, 65);
            buttonAddition.TabIndex = 11;
            buttonAddition.Text = "+";
            buttonAddition.UseVisualStyleBackColor = true;
            buttonAddition.Click += buttonAddition_Click;
            // 
            // buttonEquals
            // 
            buttonEquals.Font = new Font("Tahoma", 12F);
            buttonEquals.Location = new Point(29, 381);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(74, 65);
            buttonEquals.TabIndex = 12;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = true;
            buttonEquals.Click += buttonEquals_Click;
            // 
            // button0
            // 
            button0.Font = new Font("Tahoma", 12F);
            button0.Location = new Point(109, 310);
            button0.Name = "button0";
            button0.Size = new Size(74, 65);
            button0.TabIndex = 13;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // buttonDEL
            // 
            buttonDEL.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDEL.Location = new Point(109, 381);
            buttonDEL.Name = "buttonDEL";
            buttonDEL.Size = new Size(74, 65);
            buttonDEL.TabIndex = 14;
            buttonDEL.Text = "DEL";
            buttonDEL.UseVisualStyleBackColor = true;
            buttonDEL.Click += buttonDEL_Click;
            // 
            // buttonComma
            // 
            buttonComma.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonComma.Location = new Point(189, 381);
            buttonComma.Name = "buttonComma";
            buttonComma.Size = new Size(74, 65);
            buttonComma.TabIndex = 15;
            buttonComma.Text = ",";
            buttonComma.UseVisualStyleBackColor = true;
            buttonComma.Click += buttonComma_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(291, 491);
            Controls.Add(buttonComma);
            Controls.Add(buttonDEL);
            Controls.Add(button0);
            Controls.Add(buttonEquals);
            Controls.Add(buttonAddition);
            Controls.Add(buttonClear);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtResult);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResult;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonClear;
        private Button buttonAddition;
        private Button buttonEquals;
        private Button button0;
        private Button buttonDEL;
        private Button buttonComma;
    }
}
