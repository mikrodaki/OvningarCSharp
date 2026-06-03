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
			textBoxTelephoneNumber = new TextBox();
			listBoxContacts = new ListBox();
			buttonAdd = new Button();
			buttonRemove = new Button();
			labelError = new Label();
			buttonShow = new Button();
			buttonEdit = new Button();
			buttonSave = new Button();
			buttonCancel = new Button();
			SuspendLayout();
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.Location = new Point(21, 28);
			lblName.Margin = new Padding(2, 0, 2, 0);
			lblName.Name = "lblName";
			lblName.Size = new Size(64, 25);
			lblName.TabIndex = 0;
			lblName.Text = "Namn:";
			// 
			// lblTelephone
			// 
			lblTelephone.AutoSize = true;
			lblTelephone.Location = new Point(21, 119);
			lblTelephone.Margin = new Padding(2, 0, 2, 0);
			lblTelephone.Name = "lblTelephone";
			lblTelephone.Size = new Size(139, 25);
			lblTelephone.TabIndex = 1;
			lblTelephone.Text = "Telefonnummer:";
			// 
			// lblContacts
			// 
			lblContacts.AutoSize = true;
			lblContacts.Location = new Point(232, 28);
			lblContacts.Margin = new Padding(2, 0, 2, 0);
			lblContacts.Name = "lblContacts";
			lblContacts.Size = new Size(92, 25);
			lblContacts.TabIndex = 2;
			lblContacts.Text = "Kontakter:";
			// 
			// textBoxName
			// 
			textBoxName.Location = new Point(26, 56);
			textBoxName.Margin = new Padding(2);
			textBoxName.Name = "textBoxName";
			textBoxName.Size = new Size(169, 31);
			textBoxName.TabIndex = 3;
			textBoxName.Enter += textBox_Enter;
			// 
			// textBoxTelephoneNumber
			// 
			textBoxTelephoneNumber.Location = new Point(26, 146);
			textBoxTelephoneNumber.Margin = new Padding(2);
			textBoxTelephoneNumber.Name = "textBoxTelephoneNumber";
			textBoxTelephoneNumber.Size = new Size(169, 31);
			textBoxTelephoneNumber.TabIndex = 4;
			textBoxTelephoneNumber.Enter += textBox_Enter;
			textBoxTelephoneNumber.KeyPress += textBoxTelephoneNumber_KeyPress;
			// 
			// listBoxContacts
			// 
			listBoxContacts.FormattingEnabled = true;
			listBoxContacts.ItemHeight = 25;
			listBoxContacts.Location = new Point(232, 56);
			listBoxContacts.Margin = new Padding(2);
			listBoxContacts.Name = "listBoxContacts";
			listBoxContacts.Size = new Size(198, 204);
			listBoxContacts.TabIndex = 0;
			listBoxContacts.SelectedIndexChanged += listBoxContacts_SelectedIndexChanged;
			// 
			// buttonAdd
			// 
			buttonAdd.BackColor = SystemColors.Window;
			buttonAdd.Location = new Point(26, 296);
			buttonAdd.Margin = new Padding(4);
			buttonAdd.Name = "buttonAdd";
			buttonAdd.Size = new Size(118, 49);
			buttonAdd.TabIndex = 6;
			buttonAdd.Text = "Lägg till";
			buttonAdd.UseVisualStyleBackColor = true;
			buttonAdd.Click += buttonAdd_Click;
			// 
			// buttonRemove
			// 
			buttonRemove.BackColor = SystemColors.Window;
			buttonRemove.Enabled = false;
			buttonRemove.Location = new Point(171, 296);
			buttonRemove.Margin = new Padding(4);
			buttonRemove.Name = "buttonRemove";
			buttonRemove.Size = new Size(118, 49);
			buttonRemove.TabIndex = 7;
			buttonRemove.Text = "Ta bort";
			buttonRemove.UseVisualStyleBackColor = false;
			buttonRemove.Click += buttonRemove_Click;
			// 
			// labelError
			// 
			labelError.AutoSize = true;
			labelError.ForeColor = Color.IndianRed;
			labelError.Location = new Point(26, 194);
			labelError.Margin = new Padding(2, 0, 2, 0);
			labelError.Name = "labelError";
			labelError.Size = new Size(0, 25);
			labelError.TabIndex = 8;
			// 
			// buttonShow
			// 
			buttonShow.Enabled = false;
			buttonShow.Location = new Point(312, 296);
			buttonShow.Margin = new Padding(4);
			buttonShow.Name = "buttonShow";
			buttonShow.Size = new Size(118, 49);
			buttonShow.TabIndex = 9;
			buttonShow.Text = "Visa";
			buttonShow.UseVisualStyleBackColor = true;
			buttonShow.Click += buttonShow_Click;
			// 
			// buttonEdit
			// 
			buttonEdit.Enabled = false;
			buttonEdit.Location = new Point(26, 362);
			buttonEdit.Margin = new Padding(4);
			buttonEdit.Name = "buttonEdit";
			buttonEdit.Size = new Size(118, 49);
			buttonEdit.TabIndex = 10;
			buttonEdit.Text = "Redigera";
			buttonEdit.UseVisualStyleBackColor = true;
			buttonEdit.Click += buttonEdit_Click;
			// 
			// buttonSave
			// 
			buttonSave.Location = new Point(171, 362);
			buttonSave.Margin = new Padding(4);
			buttonSave.Name = "buttonSave";
			buttonSave.Size = new Size(118, 49);
			buttonSave.TabIndex = 11;
			buttonSave.Text = "Spara";
			buttonSave.UseVisualStyleBackColor = true;
			buttonSave.Visible = false;
			buttonSave.Click += buttonSave_Click;
			// 
			// buttonCancel
			// 
			buttonCancel.Location = new Point(312, 362);
			buttonCancel.Margin = new Padding(4);
			buttonCancel.Name = "buttonCancel";
			buttonCancel.Size = new Size(118, 49);
			buttonCancel.TabIndex = 12;
			buttonCancel.Text = "Avbryt";
			buttonCancel.UseVisualStyleBackColor = true;
			buttonCancel.Visible = false;
			buttonCancel.Click += buttonCancel_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.AppWorkspace;
			ClientSize = new Size(462, 449);
			Controls.Add(buttonCancel);
			Controls.Add(buttonSave);
			Controls.Add(buttonEdit);
			Controls.Add(buttonShow);
			Controls.Add(labelError);
			Controls.Add(buttonRemove);
			Controls.Add(buttonAdd);
			Controls.Add(listBoxContacts);
			Controls.Add(textBoxTelephoneNumber);
			Controls.Add(textBoxName);
			Controls.Add(lblContacts);
			Controls.Add(lblTelephone);
			Controls.Add(lblName);
			ForeColor = Color.Black;
			Margin = new Padding(2);
			Name = "Form1";
			Text = "Kontaktlista";
			MouseDown += Form1_MouseDown;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblName;
		private Label lblTelephone;
		private Label lblContacts;
		private TextBox textBoxName;
		private TextBox textBoxTelephoneNumber;
		private ListBox listBoxContacts;
        private Button buttonAdd;
        private Button buttonRemove;
		private Label labelError;
        private Button buttonShow;
		private Button buttonEdit;
		private Button buttonSave;
		private Button buttonCancel;
	}
}
