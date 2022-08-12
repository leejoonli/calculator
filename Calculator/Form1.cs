namespace Calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand_one = string.Empty;
        //string[] operands = new string[2];
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
            if (operation == '+')
            {
                //operands.Append(operand_temp);
                this.textBox1.Text = "";
                operand_two += "1";
                this.textBox1.Text = operand_two;
            }
            this.textBox1.Text = "";
            operand_one += "1";
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
            input = string.Empty;
            operand_one = string.Empty;
            operand_two = string.Empty;
            operation = ' ';
            //Array.Clear(operands);
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
            input += "+";
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
            double result = 0;
            double num_one = Convert.ToDouble(operand_one);
            double num_two = Convert.ToDouble(operand_two);

            switch(operation)
            {
                case '+':
                    result = num_one + num_two;
                    break;
                default:
                    break;
            }

            operand_one = string.Empty;
            operand_two = string.Empty;
            input = string.Empty;
            operation = ' ';

            this.textBox1.Text = "";
            input += result.ToString();
            this.textBox1.Text = input;
        }
    }
}