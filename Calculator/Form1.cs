namespace Calculator
{
    public partial class Form1 : Form
    {
        Queue<string> history = new Queue<string>();
        string input = string.Empty;
        string operand_one = string.Empty;
        string operand_two = string.Empty;
        char operation = ' ';
        double result;
        bool has_executed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
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
                return;
            }
            else
            {
                if (has_executed)
                {
                    operand_one = string.Empty;
                    input = string.Empty;
                    this.textBox1.Text = "";
                    operand_one += temp.Text;
                    input += temp.Text;
                    this.textBox1.Text = input;
                    has_executed = false;
                    return;
                }
                else
                {
                    this.textBox1.Text = "";
                    operand_one += temp.Text;
                    input += temp.Text;
                    this.textBox1.Text = input;
                    return;
                }
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            input_string(sender);
            return;
        }

        private void two_Click(object sender, EventArgs e)
        {
            input_string(sender);
            return;
        }

        private void three_Click(object sender, EventArgs e)
        {
            input_string(sender);
            return;
        }

        private void four_Click(object sender, EventArgs e)
        {
            input_string(sender);
            return;
        }

        private void five_Click(object sender, EventArgs e)
        {
            input_string(sender);
            return;
        }

        private void six_Click(object sender, EventArgs e)
        {
            input_string(sender);
            return;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            input_string(sender);
            return;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            input_string(sender);
            return;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            input_string(sender);
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            history.Clear();
            input = string.Empty;
            operand_one = string.Empty;
            operand_two = string.Empty;
            operation = ' ';
            this.textBox1.Text = input;
            this.textBox2.Text = input;
            return;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            input_string(sender);
            return;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (!operand_one.Contains('.'))
            {
                if(operand_one == string.Empty)
                {
                    operand_one += "0";
                }
                this.textBox1.Text = "";
                operand_one += '.';
                input += ".";
                this.textBox1.Text = input;
                return;
            }
            else if (!operand_two.Contains('.') && operation != ' ')
            {
                if (operand_two == string.Empty)
                {
                    operand_two += "0";
                }
                this.textBox1.Text = "";
                operand_two += '.';
                input += ".";
                this.textBox1.Text = input;
                return;
            }
        }
        private void check_operation(object sender)
        {
            Button temp = sender as Button;
            if (operation == '-')
            {
                operation = char.Parse(temp.Text);
                this.textBox1.Text = "";
                input = input.Replace('-', operation);
                this.textBox1.Text = input;
            }
            else if (operation == '+')
            {
                operation = char.Parse(temp.Text);
                this.textBox1.Text = "";
                input = input.Replace('+', operation);
                this.textBox1.Text = input;
            }
            else if (operation == '*')
            {
                operation = char.Parse(temp.Text);
                this.textBox1.Text = "";
                input = input.Replace('*', operation);
                this.textBox1.Text = input;
            }
            else if(operation == '/')
            {
                operation = char.Parse(temp.Text);
                this.textBox1.Text = "";
                input = input.Replace('/', operation);
                this.textBox1.Text = input;
            }
        }
        private void add_Click(object sender, EventArgs e)
        {
            if (operation == '-' || operation == '*' || operation == '/')
            {
                check_operation(sender);
                return;
            }
            if (operation != ' ' && operand_one != string.Empty)
            {
                execute_Click(sender, e);
                return;
            }
            if (operand_one == string.Empty)
            {
                operand_one = "0";
                input += operand_one;
                this.textBox1.Text = input;
                return;
            }
            operation = '+';
            input += "+";
            this.textBox1.Text = input;
            return;
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            if (operation == '+' || operation == '*' || operation == '/')
            {
                check_operation(sender);
                return;
            }
            if (operation != ' ' && operand_one != string.Empty)
            {
                execute_Click(sender, e);
                return;
            }
            if (operand_one == string.Empty)
            {
                operand_one = "0";
                input += operand_one;
                this.textBox1.Text = input;
                return;
            }
            operation = '-';
            input += "-";
            this.textBox1.Text = input;
            return;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (operation == '-' || operation == '+' || operation == '/')
            {
                check_operation(sender);
                return;
            }
            if (operation != ' ' && operand_one != string.Empty)
            {
                execute_Click(sender, e);
                return;
            }
            if (operand_one == string.Empty)
            {
                operand_one = "0";
                input += operand_one;
                this.textBox1.Text = input;
                return;
            }
            operation = '*';
            input += "*";
            this.textBox1.Text = input;
            return;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (operation == '-' || operation == '*' || operation == '+')
            {
                check_operation(sender);
                return;
            }
            if (operation != ' ' && operand_one != string.Empty)
            {
                execute_Click(sender, e);
                return;
            }
            if (operand_one == string.Empty)
            {
                operand_one = "0";
                input += operand_one;
                this.textBox1.Text = input;
                return;
            }
            operation = '/';
            input += "/";
            this.textBox1.Text = input;
            return;
        }

        private void divide_into_one_Click(object sender, EventArgs e)
        {
            if(operand_one == string.Empty)
            {
                operand_one += "1";
                operand_two += "0";
                operation = '/';
                execute_Click(sender, e);
                return;
            }
            else
            {
                operand_two = operand_one;
                operand_one = "1";
                operation = '/';
                execute_Click(sender, e);
                return;
            }
        }

        private void square_Click(object sender, EventArgs e)
        {
            if(operand_one == string.Empty)
            {
                operand_one += "0";
                operand_two = operand_one;
                operation = '*';
                execute_Click(sender, e);
                return;
            }
            else
            {
                operand_two = operand_one;
                operation = '*';
                execute_Click(sender, e);
                return;
            }
        }

        private void square_root_Click(object sender, EventArgs e)
        {
            if(operand_one == string.Empty)
            {
                operand_one += "0";
                operation = 's';
                execute_Click(sender, e);
                return;
            }
            else
            {
                operation = 's';
                execute_Click(sender, e);
                return;
            }
        }

        private void negative_Click(object sender, EventArgs e)
        {
            if (operand_two != string.Empty && operation != ' ')
            {
                if(operand_two.Substring(0, 1) == "-")
                {
                    operand_two = operand_two.Remove(0, 1);
                    this.textBox1.Text = "";
                    input = input.Remove(operand_one.Length + 1, 1);
                    this.textBox1.Text += input;
                    return;
                }
                else
                {
                    operand_two = operand_two.Insert(0, "-");
                    this.textBox1.Text = "";
                    input = input.Insert(operand_one.Length + 1, "-");
                    this.textBox1.Text += input;
                    return;
                }
            }
            else if(operand_one != string.Empty && operation == ' ' && operand_two == string.Empty)
            {
                if (operand_one.Substring(0, 1) == "-")
                {
                    operand_one = operand_one.Remove(0, 1);
                    this.textBox1.Text = "";
                    input = input.Remove(0, 1);
                    this.textBox1.Text += input;
                    return;
                }
                else
                {
                    operand_one = operand_one.Insert(0, "-");
                    this.textBox1.Text = "";
                    input = input.Insert(0, "-");
                    this.textBox1.Text += input;
                    return;
                }
            }
        }

        private void backspace_Click(object sender, EventArgs e)
        {

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
            if (operand_one != string.Empty && operation == ' ' && operand_two == string.Empty)
            {
                input = string.Empty;
                this.textBox1.Text = "";
                input += operand_one;
                this.textBox1.Text = input;
                return;
            }
            if (operand_one != string.Empty && operation != ' ' && operand_two == string.Empty)
            {
                operand_two = operand_one;
                return;
            }

            has_executed = true;
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
                case 's':
                    result = Math.Sqrt(num_one);
                    break;
                default:
                    break;
            }

            history_list(result, num_one, num_two, operation);
            this.textBox2.Text = "";
            foreach (string queue in history)
            {
                this.textBox2.AppendText(queue);
                this.textBox2.AppendText(Environment.NewLine);
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
                return;
            }
            else
            {
                this.textBox1.Text = "";
                input += result.ToString();
                this.textBox1.Text = input;
                return;
            }
        }
        private void history_list(double result, double num_one, double num_two, char op)
        {
            if (operation == 's')
            {
                string queue_string = $"{(char)0x221A}{num_one}={result}";
                history.Enqueue(queue_string);
                return;
            }
            else
            {
                string queue_string = $"{num_one}{op}{num_two}={result}";
                history.Enqueue(queue_string);
                return;
            }
        }
    }
}