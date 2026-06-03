using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

namespace ContactList
{
    public partial class Form1 : Form
    {
        List<Person> contacts = new List<Person>()
        {
            new Person("Anna", "0701234567"),
            new Person("Erik", "0739876543"),
            new Person("Lisa", "0765554433")
        };

		// Index that is currently being edited
        int editingIndex = -1;
        public Form1()
        {
            InitializeComponent();
            foreach (Person person in contacts)
            {
                listBoxContacts.Items.Add(person.Name);
            }
        }



		private void buttonRemove_Click(object sender, EventArgs e)
		{
			int index = listBoxContacts.SelectedIndex;

			if (index == -1)
				return;

			listBoxContacts.Items.RemoveAt(index);
			contacts.RemoveAt(index);

			UpdateUI();
		}

		private void buttonShow_Click(object sender, EventArgs e)
        {
            var index = listBoxContacts.SelectedIndex;

			if (index == -1)
				return;
			
			var person = contacts[index];
            MessageBox.Show(person.Name + "\n" + person.TelephoneNumber);
        }

		/* 
		   If the user clicks anywhere on the form (other than in another controller) 
		   the form is reset.  	
		*/
		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			listBoxContacts.ClearSelected();
			labelError.Text = "";
			listBoxContacts.Focus();
			UpdateUI();
		}

		/* 
			Used to clear the contact in the listBox if the user
			decides to insted enter a new contact
		*/
		private void textBox_Enter(object sender, EventArgs e)
		{
			listBoxContacts.ClearSelected();
			UpdateUI();
		}

		private void listBoxContacts_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateUI();
		}


		private void buttonAdd_Click(object sender, EventArgs e)
        {
            labelError.Text = "";
            var name = textBoxName.Text;
            var telephoneNumber = textBoxTelephoneNumber.Text;
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(telephoneNumber))
            {
                var person = new Person(name, telephoneNumber);
                contacts.Add(person);
                listBoxContacts.Items.Add(person.Name);
                textBoxName.Clear();
                textBoxTelephoneNumber.Clear();
            }
            else
            {
				if (string.IsNullOrEmpty(name))
					labelError.Text += "Namn saknas ";

				if (string.IsNullOrEmpty(telephoneNumber))
					labelError.Text += "\nTelefonnummer saknas ";
			}
			UpdateUI();

        }

        private void textBoxTelephoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var index = listBoxContacts.SelectedIndex;

			if (index == -1)
				return;
			
			editingIndex = index;
            var person = contacts[editingIndex];
            textBoxName.Text = person.Name;
            textBoxTelephoneNumber.Text = person.TelephoneNumber;
			UpdateUI();
        }

		private void buttonSave_Click(object sender, EventArgs e)
		{
			labelError.Text = "";

			var name = textBoxName.Text;
			var telephoneNumber = textBoxTelephoneNumber.Text;

			if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(telephoneNumber))
			{
				if (string.IsNullOrEmpty(name))
					labelError.Text += "Namn saknas ";
				if (string.IsNullOrEmpty(telephoneNumber))
					labelError.Text += "\nTelefonnummer saknas ";

				return;
			}

			contacts[editingIndex].Name = name;
			contacts[editingIndex].TelephoneNumber = telephoneNumber;
			listBoxContacts.Items[editingIndex] = name;

			textBoxName.Clear();
			textBoxTelephoneNumber.Clear();

			editingIndex = -1;

			UpdateUI() ;
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			textBoxName.Clear();
			textBoxTelephoneNumber.Clear();

			editingIndex = -1;

			UpdateUI();
		}

		private void UpdateUI()
		{
			bool isEditing = editingIndex != -1;
			bool contactSelected = listBoxContacts.SelectedIndex != -1;

			// Default state
			buttonAdd.Enabled = true;
			buttonShow.Enabled = false;
			buttonEdit.Enabled = false;
			buttonRemove.Enabled = false;
			buttonSave.Visible = false;
			buttonCancel.Visible = false;

			// If a contact is selected
			if (contactSelected)
			{
				buttonAdd.Enabled = false;
				buttonShow.Enabled = true;
				buttonEdit.Enabled = true;
				buttonRemove.Enabled = true;
			}

			// If the user is editing a contact
			if (isEditing)
			{
				buttonAdd.Enabled = false;
				buttonShow.Enabled = false;
				buttonEdit.Enabled = false;
				buttonRemove.Enabled = false;
				buttonSave.Visible = true;
				buttonCancel.Visible = true;
			}
		}
	}
}
