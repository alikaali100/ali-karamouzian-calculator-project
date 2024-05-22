using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double num1 = 0;
        char op;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void btnnumber(object sender, EventArgs e)
        {
            if (txtscreen.Text == "0")
                txtscreen.Text = ((Button)sender).Text;
            else
                txtscreen.Text += ((Button)sender).Text;
        }

        private void c(object sender, EventArgs e)
        {
            txtscreen.Text = "0";
        }

        private void tzjm(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtscreen.Text);
            op = Convert.ToChar(((Button)sender).Text);
            txtscreen.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double num2 = 0;
            num2 = Convert.ToDouble(txtscreen.Text);
            switch (op)
            {
                case '+':
                    num1 = num1 + num2;
                    break;
                case '-':
                    num1 = num1 - num2;
                    break;
                case '*':
                    num1 = num1 * num2;
                    break;
                case '/':
                    num1 = num1 / num2;
                    break;
            }
            txtscreen.Text=num1.ToString();
        }
    }
}
