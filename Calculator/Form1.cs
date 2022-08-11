namespace Calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand_one = string.Empty;
        string operand_two = string.Empty;
        char operation;
        //double result;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)
        {
            if (operation != '+' || operation != '-' || operation != '*' || operation != '/') 
            {
                this.textBox1.Text = "";
                operand_one += "1";
                input = operand_one;
                this.textBox1.Text = input;
            }
            else
            {
                this.textBox1.Text = "";
                operand_two += "1";
                input = $"{operand_one}{operation}{operand_two}";
                input = operand_two;
                this.textBox1.Text = input;
            }
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
            input = string.Empty;
            operand_one = string.Empty;
            operand_two = string.Empty;
            operation = ' ';
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


        private void add_Click(object sender, EventArgs e)
        {
            operation = '+';
            input = $"{operand_one}{operation}{operand_two}";
            this.textBox1.Text = input;
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            operation = '-';
            input += "-";
            this.textBox1.Text = input;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            operation = '*';
            input += "*";
            this.textBox1.Text = input;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            operation = '/';
            input += "/";
            this.textBox1.Text = input;
        }
        private void execute_Click(object sender, EventArgs e)
        {

        }
    }
}