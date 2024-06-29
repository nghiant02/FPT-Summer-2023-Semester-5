namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNumber1.Text);
            double num2 = Convert.ToDouble(txtNumber2.Text);
            double result = num1 + num2;
            MessageBox.Show("Result = " + result.ToString());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNumber1.Text);
            double num2 = Convert.ToDouble(txtNumber2.Text);
            double result = num1 - num2;
            MessageBox.Show("Result = " + result.ToString());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNumber1.Text);
            double num2 = Convert.ToDouble(txtNumber2.Text);
            double result = num1 * num2;
            MessageBox.Show("Result = " + result.ToString());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNumber1.Text);
            double num2 = Convert.ToDouble(txtNumber2.Text);
            double result = num1 / num2;
            MessageBox.Show("Result = " + result.ToString());
        }

        private void txtNumber1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}