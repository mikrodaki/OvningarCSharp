using System.Windows.Forms;

namespace ContactList
{
	public partial class Form1 : Form
	{
		List<Person> contacts = new List<Person>();
		public Form1()
		{
			InitializeComponent();
		}


		private void buttonRemove_Click(object sender, EventArgs e)
		{
			var index = listBoxContacts.SelectedIndex;
			if (index != -1)
			{
				listBoxContacts.Items.RemoveAt(index);
				contacts.RemoveAt(index);
				//if (contacts.Count == 0)
				//	buttonRemove.Enabled = false;
			}
		}

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            listBoxContacts.ClearSelected();
        }

		/* 
			Används så att namn i lisboxen avmarkeras
			när man försöker lägga till en ny
		*/
        private void textBox_Enter(object sender, EventArgs e)
        {
            listBoxContacts.ClearSelected();
        }

        private void listBoxContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonRemove.Enabled = listBoxContacts.SelectedIndex != -1;
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
				//buttonRemove.Enabled = true;
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
		}

		private void textBoxTelephoneNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}
	}
}
