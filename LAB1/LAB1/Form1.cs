namespace LAB1
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            int number = 0;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "3";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = string.Empty;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "kku";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "2";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "6";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "7";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "8";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "9";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "0";

        }


        string operation;
        string number1 = string.Empty;
        //มันคือปุ่ม+
        private void button14_Click(object sender, EventArgs e)
        {
            number1 = textBoxInput.Text;
            textBoxInput.Text = string.Empty;
            operation = "+";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string number2 = textBoxInput.Text;
            int num1 = int.Parse(number1);
            int num2 = int.Parse(number2);
            if (operation == "+")
            {
                int output = num1 + num2;
                textBoxInput.Text = output.ToString();

            }
            else if (operation == "-")
            {
                int output = num1 - num2;
                textBoxInput.Text = output.ToString();

            }
            else if (operation == "*")
            {
                int output = num1 * num2;
                textBoxInput.Text = output.ToString();

            }
            else if (operation == "/")
            {
                int output = num1 / num2;
                textBoxInput.Text = output.ToString();
            }



        }

        private void button13_Click(object sender, EventArgs e)
        {

            number1 = textBoxInput.Text;
            textBoxInput.Text = string.Empty;
            operation = "-";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            number1 = textBoxInput.Text;
            textBoxInput.Text = string.Empty;
            operation = "*";


        }

        private void button11_Click(object sender, EventArgs e)
        {
            number1 = textBoxInput.Text;
            textBoxInput.Text = string.Empty;
            operation = "/";
        }
    }
}
