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

        private void redScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            red = e.NewValue;
            lblRedNumber.Text = red.ToString();
            UpdateColor();
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
            pictureBoxLarge.BackColor = Color.FromArgb(red, green, blue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBoxSmall1.BackColor = pictureBoxLarge.BackColor;
            SaveToMemory(0);
        }

        private void pictureBoxSmall1_Click(object sender, EventArgs e)
        {
            var rgb = memory[0];
            ApplyRgb(rgb);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBoxSmall2.BackColor = pictureBoxLarge.BackColor;
            SaveToMemory(1);
        }

        private void pictureBoxSmall2_Click(object sender, EventArgs e)
        {
            var rgb = memory[1];
            ApplyRgb(rgb);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBoxSmall3.BackColor = pictureBoxLarge.BackColor;
            SaveToMemory(2);
        }

        private void pictureBoxSmall3_Click(object sender, EventArgs e)
        {
            var rgb = memory[2];
            ApplyRgb(rgb);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBoxSmall4.BackColor = pictureBoxLarge.BackColor;
            SaveToMemory(3);
        }

        private void pictureBoxSmall4_Click(object sender, EventArgs e)
        {
            var rgb = memory[3];
            ApplyRgb(rgb);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBoxSmall5.BackColor = pictureBoxLarge.BackColor;
            SaveToMemory(4);
        }

        private void pictureBoxSmall5_Click(object sender, EventArgs e)
        {
            var rgb = memory[4];
            ApplyRgb(rgb);
        }
        private void ApplyRgb(Rgb rgb)
        {
            var red = rgb.R;
            var green = rgb.G;
            var blue = rgb.B;

            pictureBoxLarge.BackColor = Color.FromArgb(red, green, blue);

            lblRedNumber.Text = red.ToString();
            lblGreenNumber.Text = green.ToString();
            lblBlueNumber.Text = blue.ToString();

            redScrollBar.Value = red;
            greenScrollBar.Value = green;
            blueScrollBar.Value = blue;

        }

        private void SaveToMemory(int index)
        {
            memory[index].R = red;
            memory[index].G = green;
            memory[index].B = blue;
        }

    }
}
