namespace _15._7___Enkel_additionskalkulator
{
    public partial class Form1 : Form
    {
        List<int> numbers = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResult.Text += "1";
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

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
            AddNumberToList();
            txtResult.ResetText();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            txtResult.ResetText();
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != " ")
                AddNumberToList();
            txtResult.ResetText();
            var result = CalculateSum();
            if (result != 0)
                txtResult.Text = result.ToString();
            numbers.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {

        }

        private int CalculateSum()
        {
            int result = 0;
            result = numbers[0];
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                result += numbers[i + 1];
            }
            return result;
        }

        private void AddNumberToList()
        {
            int.TryParse(txtResult.Text, out int number);
            numbers.Add(number);
        }

        private void buttonDEL_Click(object sender, EventArgs e)
        {
            txtResult.ResetText();
        }
    }
}
