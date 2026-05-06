namespace ColorPicker
{
	public partial class Form1 : Form
	{
		int red = 0;
		int green = 0;
		int blue = 0;
		List<Rgb> memory = new List<Rgb>();
		public Form1()
		{
			InitializeComponent();
			for (int i = 0; i < 5; i++)
			{
				memory.Add(new Rgb(0, 0, 0));
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void redScrollBar_Scroll(object sender, ScrollEventArgs e)
		{
			red = e.NewValue;
			lblRedNumber.Text = red.ToString();
			UpdateColor();
		}

		private void lblGreen_Click(object sender, EventArgs e)
		{

		}

		private void greenScrollBar_Scroll(object sender, ScrollEventArgs e)
		{
			green = e.NewValue;
			lblGreenNumber.Text = green.ToString();
			UpdateColor();
		}

		private void blueScrollBar_Scroll(object sender, ScrollEventArgs e)
		{
			blue = e.NewValue;
			lblBlueNumber.Text = blue.ToString();
			UpdateColor();
		}

		private void UpdateColor()
		{
			pictureBox1.BackColor = Color.FromArgb(red, green, blue);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			pictureBox2.BackColor = pictureBox1.BackColor;
			memory[0].R = (int)red;
			memory[0].G = (int)green;
			memory[0].B = (int)blue;
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			pictureBox1.BackColor = Color.FromArgb(memory[0].R, memory[0].G, memory[0].B);
		}
	}
}
