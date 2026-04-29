namespace _15._5___Poängtavla
{
	public partial class Form1 : Form
	{
		int homeScore = 0;
		int awayScore = 0;
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			homeScore++;
			lblHomeScore.Text = homeScore.ToString();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			homeScore = 0;
			awayScore = 0;
			lblHomeScore.Text = homeScore.ToString();
			lblAwayScore.Text = awayScore.ToString();
		}

		private void lblHomePoints_Click(object sender, EventArgs e)
		{

		}

		private void btnAwayGoal_Click(object sender, EventArgs e)
		{
			awayScore++;
			lblAwayScore.Text = awayScore.ToString();
		}
	}
}
