namespace _15._6___Enkel_kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            lblOperator.Text = "-";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblOperator.Text = "+";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            lblOperator.Text = "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            lblOperator.Text = "/";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            bool validA = double.TryParse(txtNumber1.Text, out double a);
            bool validB = double.TryParse(txtNumber2.Text, out double b);

            bool validNumbers = validA && validB;

            double result = 0;

            if (validNumbers)
            {
                switch (lblOperator.Text)
                {
                    case "+":
                        result = a + b;
                        break;
                    case "-":
                        result = a - b;
                        break;
                    case "*":
                        result = a * b;
                        break;
                    case "/":
                        result = a / b;
                        break;
                }

                lblResult.Text = result.ToString();
            }
            else
            {
                lblResult.Text = "Fel";
            }
        }
    }
}
