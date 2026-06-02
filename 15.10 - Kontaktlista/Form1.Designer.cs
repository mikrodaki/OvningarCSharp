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
            textBoxName.Margin = new Padding(2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(136, 27);
            textBoxName.TabIndex = 3;
            // 
            // textBoxTelephoneNumber
            // 
            textBoxTelephoneNumber.Location = new Point(21, 117);
            textBoxTelephoneNumber.Margin = new Padding(2);
            textBoxTelephoneNumber.Name = "textBoxTelephoneNumber";
            textBoxTelephoneNumber.Size = new Size(136, 27);
            textBoxTelephoneNumber.TabIndex = 4;
            textBoxTelephoneNumber.Enter += textBox_Enter;
            textBoxTelephoneNumber.KeyPress += textBoxTelephoneNumber_KeyPress;
            // 
            // listBoxContacts
            // 
            listBoxContacts.FormattingEnabled = true;
            listBoxContacts.Location = new Point(186, 45);
            listBoxContacts.Margin = new Padding(2);
            listBoxContacts.Name = "listBoxContacts";
            listBoxContacts.Size = new Size(159, 164);
            listBoxContacts.TabIndex = 5;
            listBoxContacts.SelectedIndexChanged += listBoxContacts_SelectedIndexChanged;
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
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Enabled = false;
            buttonRemove.Location = new Point(137, 237);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(94, 39);
            buttonRemove.TabIndex = 7;
            buttonRemove.Text = "Ta bort";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.ForeColor = Color.IndianRed;
            labelError.Location = new Point(21, 155);
            labelError.Margin = new Padding(2, 0, 2, 0);
            labelError.Name = "labelError";
            labelError.Size = new Size(0, 20);
            labelError.TabIndex = 8;
            // 
            // buttonShow
            // 
            buttonShow.Enabled = false;
            buttonShow.Location = new Point(250, 237);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(94, 39);
            buttonShow.TabIndex = 9;
            buttonShow.Text = "Visa";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Enabled = false;
            buttonEdit.Location = new Point(21, 290);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(94, 39);
            buttonEdit.TabIndex = 10;
            buttonEdit.Text = "Redigera";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(137, 290);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 39);
            buttonSave.TabIndex = 11;
            buttonSave.Text = "Spara";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Visible = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(250, 290);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 39);
            buttonCancel.TabIndex = 12;
            buttonCancel.Text = "Avbryt";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Visible = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(370, 359);
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
