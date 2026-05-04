namespace _15._6___Enkel_kalkulator
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
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            button5 = new Button();
            lblOperator = new Label();
            label2 = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(120, 169);
            txtNumber1.Margin = new Padding(4);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(170, 34);
            txtNumber1.TabIndex = 0;
            // 
            // txtNumber2
            // 
            txtNumber2.Location = new Point(503, 171);
            txtNumber2.Margin = new Padding(4);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(170, 34);
            txtNumber2.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(120, 302);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 41);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Addition";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(393, 302);
            btnSubtract.Margin = new Padding(4);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(164, 41);
            btnSubtract.TabIndex = 3;
            btnSubtract.Text = "Subtraktion";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(120, 388);
            btnMultiply.Margin = new Padding(4);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(150, 41);
            btnMultiply.TabIndex = 4;
            btnMultiply.Text = "Multiplikation";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(393, 388);
            btnDivide.Margin = new Padding(4);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(164, 41);
            btnDivide.TabIndex = 5;
            btnDivide.Text = "Division";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // button5
            // 
            button5.Location = new Point(803, 343);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(214, 41);
            button5.TabIndex = 6;
            button5.Text = "Beräkna";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnCalculate_Click;
            // 
            // lblOperator
            // 
            lblOperator.AutoSize = true;
            lblOperator.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOperator.Location = new Point(370, 156);
            lblOperator.Margin = new Padding(4, 0, 4, 0);
            lblOperator.Name = "lblOperator";
            lblOperator.Size = new Size(50, 54);
            lblOperator.TabIndex = 7;
            lblOperator.Text = "+";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(745, 156);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 54);
            label2.TabIndex = 8;
            label2.Text = "=";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(857, 156);
            lblResult.Margin = new Padding(4, 0, 4, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(45, 54);
            lblResult.TabIndex = 9;
            lblResult.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1100, 630);
            Controls.Add(lblResult);
            Controls.Add(label2);
            Controls.Add(lblOperator);
            Controls.Add(button5);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
        private Button button5;
        private Label lblOperator;
        private Label label2;
        private Label lblResult;
    }
}
