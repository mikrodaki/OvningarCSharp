namespace ContactList
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
            lblName = new Label();
            lblTelephone = new Label();
            lblContacts = new Label();
            textBoxName = new TextBox();
            textBoxTelephone = new TextBox();
            listBoxContacts = new ListBox();
            buttonAdd = new Button();
            buttonRemove = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(17, 22);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Namn:";
            // 
            // lblTelephone
            // 
            lblTelephone.AutoSize = true;
            lblTelephone.Location = new Point(17, 95);
            lblTelephone.Margin = new Padding(2, 0, 2, 0);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new Size(116, 20);
            lblTelephone.TabIndex = 1;
            lblTelephone.Text = "Telefonnummer:";
            lblTelephone.Click += label1_Click;
            // 
            // lblContacts
            // 
            lblContacts.AutoSize = true;
            lblContacts.Location = new Point(186, 22);
            lblContacts.Margin = new Padding(2, 0, 2, 0);
            lblContacts.Name = "lblContacts";
            lblContacts.Size = new Size(76, 20);
            lblContacts.TabIndex = 2;
            lblContacts.Text = "Kontakter:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(21, 45);
            textBoxName.Margin = new Padding(2, 2, 2, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(136, 27);
            textBoxName.TabIndex = 3;
            // 
            // textBoxTelephone
            // 
            textBoxTelephone.Location = new Point(21, 128);
            textBoxTelephone.Margin = new Padding(2, 2, 2, 2);
            textBoxTelephone.Name = "textBoxTelephone";
            textBoxTelephone.Size = new Size(136, 27);
            textBoxTelephone.TabIndex = 4;
            // 
            // listBoxContacts
            // 
            listBoxContacts.FormattingEnabled = true;
            listBoxContacts.Location = new Point(186, 45);
            listBoxContacts.Margin = new Padding(2, 2, 2, 2);
            listBoxContacts.Name = "listBoxContacts";
            listBoxContacts.Size = new Size(159, 164);
            listBoxContacts.TabIndex = 5;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = SystemColors.Control;
            buttonAdd.Location = new Point(21, 237);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 39);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Lägg till";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(251, 237);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(94, 39);
            buttonRemove.TabIndex = 7;
            buttonRemove.Text = "Ta bort";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(370, 310);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Controls.Add(listBoxContacts);
            Controls.Add(textBoxTelephone);
            Controls.Add(textBoxName);
            Controls.Add(lblContacts);
            Controls.Add(lblTelephone);
            Controls.Add(lblName);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Kontaktlista";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
		private Label lblTelephone;
		private Label lblContacts;
		private TextBox textBoxName;
		private TextBox textBoxTelephone;
		private ListBox listBoxContacts;
        private Button buttonAdd;
        private Button buttonRemove;
    }
}
