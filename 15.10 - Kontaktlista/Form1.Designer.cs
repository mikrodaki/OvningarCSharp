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
			SuspendLayout();
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.Location = new Point(21, 28);
			lblName.Name = "lblName";
			lblName.Size = new Size(64, 25);
			lblName.TabIndex = 0;
			lblName.Text = "Namn:";
			// 
			// lblTelephone
			// 
			lblTelephone.AutoSize = true;
			lblTelephone.Location = new Point(21, 119);
			lblTelephone.Name = "lblTelephone";
			lblTelephone.Size = new Size(139, 25);
			lblTelephone.TabIndex = 1;
			lblTelephone.Text = "Telefonnummer:";
			lblTelephone.Click += label1_Click;
			// 
			// lblContacts
			// 
			lblContacts.AutoSize = true;
			lblContacts.Location = new Point(232, 28);
			lblContacts.Name = "lblContacts";
			lblContacts.Size = new Size(92, 25);
			lblContacts.TabIndex = 2;
			lblContacts.Text = "Kontakter:";
			// 
			// textBoxName
			// 
			textBoxName.Location = new Point(26, 56);
			textBoxName.Name = "textBoxName";
			textBoxName.Size = new Size(150, 31);
			textBoxName.TabIndex = 3;
			// 
			// textBoxTelephone
			// 
			textBoxTelephone.Location = new Point(26, 160);
			textBoxTelephone.Name = "textBoxTelephone";
			textBoxTelephone.Size = new Size(150, 31);
			textBoxTelephone.TabIndex = 4;
			// 
			// listBoxContacts
			// 
			listBoxContacts.FormattingEnabled = true;
			listBoxContacts.ItemHeight = 25;
			listBoxContacts.Location = new Point(232, 62);
			listBoxContacts.Name = "listBoxContacts";
			listBoxContacts.Size = new Size(180, 179);
			listBoxContacts.TabIndex = 5;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(463, 443);
			Controls.Add(listBoxContacts);
			Controls.Add(textBoxTelephone);
			Controls.Add(textBoxName);
			Controls.Add(lblContacts);
			Controls.Add(lblTelephone);
			Controls.Add(lblName);
			Name = "Form1";
			Text = "Kontaktlista";
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
	}
}
