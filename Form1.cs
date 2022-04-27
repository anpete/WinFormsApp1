namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            int? number1 = null, number2 = null;

            try
            {
                // Convert text to numbers

                number1 = Convert.ToInt32(textBox1.Text);
                number2 = Convert.ToInt32(textBox2.Text);
            }
            catch (Exception)
            {
                label4.Text = "Please enter a valid number!";
            }

            if (number1 != null && number2 != null)
            {
                // Perform calculation

                label4.Text = "";

                var discount = checkBox1.Checked;
                var result = number1 * number2;

                if (discount)
                {
                    result = (int)(result * 0.90);
                }

                textBox3.Text = result.ToString();

                // Write to file to the current directory

                File.WriteAllText("./output.txt", textBox3.Text);
            }
        }
    }
}