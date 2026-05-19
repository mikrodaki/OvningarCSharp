namespace ContactList
{
	public partial class Form1 : Form
	{
		List<Person> contacs = new List<Person>();
		public Form1()
		{
			InitializeComponent();
		}

		//private void Form1_Load(object sender, EventArgs e)
		//{

		//}

		private void buttonRemove_Click(object sender, EventArgs e)
		{
			var index = listBoxContacts.SelectedIndex;
			if (index != -1)
			{
				listBoxContacts.Items.RemoveAt(index);
				contacs.RemoveAt(index);
				if (contacs.Count == 0)
					buttonRemove.Enabled = false;
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
				contacs.Add(person);
				buttonRemove.Enabled = true;
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
