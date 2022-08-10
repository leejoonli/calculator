namespace Calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void clickme_Click(object sender, EventArgs e)
        {
            input += "hello world";
            this.textbox.Text = input;
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}