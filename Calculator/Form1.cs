namespace Calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)
        {
            input += "1";
            this.textBox1.Text = input;
        }

        private void two_Click(object sender, EventArgs e)
        {
            input += "2";
            this.textBox1.Text = input;
        }

        private void three_Click(object sender, EventArgs e)
        {
            input += "3";
            this.textBox1.Text = input;
        }

        private void four_Click(object sender, EventArgs e)
        {
            input += "4";
            this.textBox1.Text = input;
        }

        private void five_Click(object sender, EventArgs e)
        {
            input += "5";
            this.textBox1.Text = input;
        }

        private void six_Click(object sender, EventArgs e)
        {
            input += "6";
            this.textBox1.Text = input;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            input += "7";
            this.textBox1.Text = input;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            input += "8";
            this.textBox1.Text = input;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            input += "9";
            this.textBox1.Text = input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            input = String.Empty;
            this.textBox1.Text = input;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            input += "0";
            this.textBox1.Text = input;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            input += ".";
            this.textBox1.Text = input;
        }
    }
}