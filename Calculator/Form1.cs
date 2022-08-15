namespace Calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand_one = string.Empty;
        string operand_two = string.Empty;
        char operation = ' ';
        double result;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_string(object sender)
        {
            Button temp = sender as Button;
            if (operation == '+' || operation == '-' || operation == '*' || operation == '/')
            {
                this.textBox1.Text = "";
                operand_two += temp.Text;
                input += temp.Text;
                this.textBox1.Text = input;
            }
            else
            {
                this.textBox1.Text = "";
                operand_one += temp.Text;
                input += temp.Text;
                this.textBox1.Text = input;
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            input_string(sender);
        }

        private void two_Click(object sender, EventArgs e)
        {
            input_string(sender);
        }

        private void three_Click(object sender, EventArgs e)
        {
            input_string(sender);
        }

        private void four_Click(object sender, EventArgs e)
        {
            input_string(sender);
        }

        private void five_Click(object sender, EventArgs e)
        {
            input_string(sender);
        }

        private void six_Click(object sender, EventArgs e)
        {
            input_string(sender);
        }

        private void seven_Click(object sender, EventArgs e)
        {
            input_string(sender);
        }

        private void eight_Click(object sender, EventArgs e)
        {
            input_string(sender);
        }

        private void nine_Click(object sender, EventArgs e)
        {
            input_string(sender);
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
            input_string(sender);
        }

        private void dot_Click(object sender, EventArgs e)
        {
            input += ".";
            this.textBox1.Text = input;
        }


        private void add_Click(object sender, EventArgs e)
        {
            if (operation != ' ')
            {
                execute_Click(sender, e);
            }
            if (operand_one == string.Empty)
            {
                operand_one = "0";
            }
            operation = '+';
            input += "+";
            this.textBox1.Text = input;
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            if (operation != ' ')
            {
                execute_Click(sender, e);
            }
            if (operand_one == string.Empty)
            {
                operand_one = "0";
            }
            operation = '-';
            input += "-";
            this.textBox1.Text = input;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (operation != ' ')
            {
                execute_Click(sender, e);
            }
            if (operand_one == string.Empty)
            {
                operand_one = "0";
            }
            operation = '*';
            input += "*";
            this.textBox1.Text = input;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (operation != ' ')
            {
                execute_Click(sender, e);
            }
            if (operand_one == string.Empty)
            {
                operand_one = "0";
            }
            operation = '/';
            input += "/";
            this.textBox1.Text = input;
        }
        private void execute_Click(object sender, EventArgs e)
        {
            if (operand_one == string.Empty && operand_two == string.Empty)
            {
                input = string.Empty;
                this.textBox1.Text = "";
                input += "0";
                this.textBox1.Text = input;
                return;
            }
            if (operand_one != string.Empty && operation == ' ')
            {
                input = string.Empty;
                this.textBox1.Text = "";
                input += operand_one;
                this.textBox1.Text = input;
                return;
            }
            if (operand_one != string.Empty && operation != ' ')
            {
                string temp_operand_two = operand_one;
                operand_two = temp_operand_two;
            }
            result = 0;
            double num_one = Convert.ToDouble(operand_one);
            double num_two = Convert.ToDouble(operand_two);

            switch(operation)
            {
                case '+':
                    result = num_one + num_two;
                    break;
                case '-':
                    result = num_one - num_two;
                    break;
                case '*':
                    result = num_one * num_two;
                    break;
                case '/':
                    result = num_one / num_two;
                    break;
                default:
                    break;
            }

            operand_one = result.ToString();
            operand_two = string.Empty;
            input = string.Empty;
            operation = ' ';

            if(result == 0)
            {
                this.textBox1.Text = "";
                input += "0";
                this.textBox1.Text = input;
            }
            else
            {
                this.textBox1.Text = "";
                input += result.ToString();
                this.textBox1.Text = input;
            }
        }
    }
}