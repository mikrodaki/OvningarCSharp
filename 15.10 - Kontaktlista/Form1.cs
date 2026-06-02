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
            var index = listBoxContacts.SelectedIndex;
            if (index != -1)
            {
                listBoxContacts.Items.RemoveAt(index);
                contacts.RemoveAt(index);
                buttonRemove.Enabled = false;
                buttonShow.Enabled = false;
                buttonEdit.Enabled = false;
                buttonAdd.Enabled = true;
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            var index = listBoxContacts.SelectedIndex;
            var person = contacts[index];
            MessageBox.Show(person.Name + "\n" + person.TelephoneNumber);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            listBoxContacts.ClearSelected();
            if (listBoxContacts.SelectedIndex == -1)
            {
                labelError.Text = "";
                buttonAdd.Enabled = true;
                buttonRemove.Enabled = false;
                buttonShow.Enabled = false;
                buttonEdit.Enabled = false;
            }
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
            if (listBoxContacts.SelectedIndex != -1)
            {
                buttonAdd.Enabled = false;
                buttonRemove.Enabled = true;
                buttonShow.Enabled = true;
                buttonEdit.Enabled = true;
            }
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

        }

        private void textBoxTelephoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var index = listBoxContacts.SelectedIndex;
            editingIndex = index;
            var person = contacts[editingIndex];
            textBoxName.Text = person.Name;
            textBoxTelephoneNumber.Text = person.TelephoneNumber;
            buttonAdd.Enabled = false;
            buttonRemove.Enabled = false;
            buttonShow.Enabled = false;
            buttonEdit.Enabled = false;
            buttonSave.Visible = true;
            buttonCancel.Visible = true;
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

			buttonAdd.Enabled = true;
			buttonRemove.Enabled = false;
			buttonShow.Enabled = false;
			buttonEdit.Enabled = false;
			buttonSave.Visible = false;
			buttonCancel.Visible = false;
		}

		private void buttonCancel_Click(object sender, EventArgs e)
        {
			textBoxName.Clear();
            textBoxTelephoneNumber.Clear();
            buttonAdd.Enabled = true;
            buttonRemove.Enabled = false;
            buttonShow.Enabled = false;
            buttonEdit.Enabled = false;
            buttonSave.Visible = false;
            buttonCancel.Visible = false;
        }
    }
}
