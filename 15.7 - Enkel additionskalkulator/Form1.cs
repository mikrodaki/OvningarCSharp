namespace _15._7___Enkel_additionskalkulator
{
	public partial class Form1 : Form
	{
		List<decimal> numbers = new List<decimal>();
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			txtResult.Text += "1";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			txtResult.Text += "2";
		}

		private void button3_Click(object sender, EventArgs e)
		{
			txtResult.Text += "3";
		}

		private void button4_Click(object sender, EventArgs e)
		{
			txtResult.Text += "4";
		}

		private void button5_Click(object sender, EventArgs e)
		{
			txtResult.Text += "5";
		}

		private void button6_Click(object sender, EventArgs e)
		{
			txtResult.Text += "6";
		}

		private void button7_Click(object sender, EventArgs e)
		{
			txtResult.Text += "7";
		}

		private void button8_Click(object sender, EventArgs e)
		{
			txtResult.Text += "8";
		}

		private void button9_Click(object sender, EventArgs e)
		{
			txtResult.Text += "9";
		}

		private void buttonAddition_Click(object sender, EventArgs e)
		{
			if (AddNumberToList())
				txtResult.ResetText();
			else 
			{
				txtResult.Text = "Error";
				errorTimer.Start();
			}
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			numbers.Clear();
			txtResult.ResetText();
		}

		private void buttonEquals_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtResult.Text) && numbers.Count == 0)
				return;
			if (!string.IsNullOrWhiteSpace(txtResult.Text))
				if (!AddNumberToList())
				{
					txtResult.Text = "Error";
					errorTimer.Start();
					return;
				}
			var result = CalculateSum();
			txtResult.Text = result.ToString("0.##");
			numbers.Clear();
		}



		private void button0_Click(object sender, EventArgs e)
		{
			txtResult.Text += "0";
		}

		private decimal CalculateSum()
		{
			//if (numbers.Count == 0)
			//    return 0;
			//int result = 0;
			//foreach (int n in numbers)
			//{
			//    result += n;
			//}
			//return result;
			return numbers.Sum();
		}

		private bool AddNumberToList()
		{
			if (decimal.TryParse(txtResult.Text, out decimal number))
			{
				numbers.Add(number);
				return true;
			}
			return false;
		}

		private void buttonDEL_Click(object sender, EventArgs e)
		{
			if (txtResult.Text.Length > 0)
				txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
		}

		private void buttonComma_Click(object sender, EventArgs e)
		{
			if (!txtResult.Text.Contains(","))
			{
				if (string.IsNullOrEmpty(txtResult.Text))
					txtResult.Text = "0,";
				else
					txtResult.Text += ",";
			}
		}

		private void errorTimer_Tick(object sender, EventArgs e)
		{
			txtResult.ResetText();
			errorTimer.Stop();
			numbers.Clear();
		}
	}
}
