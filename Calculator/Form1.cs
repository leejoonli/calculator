namespace Calculator
{
    public partial class Form1 : Form
    {
        Queue<string> history = new Queue<string>();
        string input = string.Empty;
        string operand_input = string.Empty;
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
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void input_string(object sender)
        {
            Button temp = sender as Button;
            if (this.textBox3.Text == "Cannot divide by 0")
            {
                operand_one = temp.Text;
                operand_two = string.Empty;
                operation = ' ';
                operand_input += temp.Text;
                input = string.Empty;
                this.textBox1.Text = "";
                this.textBox3.Text = operand_one;
                this.add.Enabled = true;
                this.subtract.Enabled = true;
                this.multiply.Enabled = true;
                this.divide.Enabled = true;
                this.negative.Enabled = true;
                this.square.Enabled = true;
                this.square_root.Enabled = true;
                this.dot.Enabled = true;
                this.divide_into_one.Enabled = true;
                return;
            }
            else if (operation == '+' || operation == '-' || operation == '*' || operation == '/')
            {
                this.textBox3.Text = "";
                operand_input = string.Empty;
                operand_two += temp.Text;
                operand_input = operand_two;
                this.textBox3.Text = operand_input;
                return;
            }
            else if (operand_one == result.ToString())
            {
                this.textBox3.Text = "";
                operand_one = temp.Text;
                operand_input = operand_one;
                this.textBox3.Text = operand_input;
            }
            else
            {
                this.textBox3.Text = "";
                operand_one += temp.Text;
                operand_input += temp.Text;
                this.textBox3.Text = operand_input;
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
            operand_input = string.Empty;
            operation = ' ';
            this.textBox1.Text = input;
            this.textBox2.Text = input;
            this.textBox3.Text = input;
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
            input = string.Empty;
            input += operand_one + "+";
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
            input = string.Empty;
            input += operand_one + "-";
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
            input = string.Empty;
            input += operand_one +  "*";
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
            input = string.Empty;
            input += operand_one + "/";
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
            //if (operand_input.Length != 0 && operand_one == string.Empty)
            //{
            //    this.textBox3.Text = "";
            //    operand_one = operand_one.Remove(operand_one.Length - 1);
            //    operand_input = operand_one;
            //    this.textBox3.Text = operand_input;
            //}
            //else if (operand_input.Length != 0 && operand_one != string.Empty && operation != ' ')
            //{
            //    this.textBox3.Text = "";
            //    operand_two = operand_two.Remove(operand_two.Length - 1);
            //    operand_input = operand_two;
            //    this.textBox3.Text = operand_input;
            //}
            //return;
        }

        private void execute_Click(object sender, EventArgs e)
        {
            if (this.textBox3.Text == "Cannot divide by 0")
            {
                operand_one = string.Empty;
                operand_two = string.Empty;
                operation = ' ';
                operand_input = string.Empty;
                input = string.Empty;
                this.textBox1.Text = "";
                this.textBox3.Text = operand_one;
                this.add.Enabled = true;
                this.subtract.Enabled = true;
                this.multiply.Enabled = true;
                this.divide.Enabled = true;
                this.negative.Enabled = true;
                this.square.Enabled = true;
                this.square_root.Enabled = true;
                this.dot.Enabled = true;
                this.divide_into_one.Enabled = true;
                return;
            }
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

            result = 0;
            double num_one = Convert.ToDouble(operand_one);
            double num_two = Convert.ToDouble(operand_two);
            char temp_op = operation;

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
                    if (num_two == 0)
                    {
                        this.textBox3.Text = "";
                        this.textBox3.Text = "Cannot divide by 0";
                        this.add.Enabled = false;
                        this.subtract.Enabled = false;
                        this.multiply.Enabled = false;
                        this.divide.Enabled = false;
                        this.negative.Enabled = false;
                        this.square.Enabled = false;
                        this.square_root.Enabled = false;
                        this.dot.Enabled = false;
                        this.divide_into_one.Enabled = false;
                        return;
                    }
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
            operation = ' ';

            this.textBox3.Text = "";
            this.textBox1.Text = "";
            input = $"{num_one}{temp_op}{num_two}=";
            this.textBox1.Text = input;
            input = string.Empty;
            this.textBox3.Text = operand_one;
            return;
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