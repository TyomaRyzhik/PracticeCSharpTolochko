namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox4.Text);
            double y = Convert.ToDouble(textBox1.Text);
            double z = Convert.ToDouble(textBox2.Text);

            double funcResult = 0;
            double result;

            if (radioButton1.Checked)
            {
                funcResult = Math.Sinh(x);
            }
                
            else if (radioButton2.Checked)
            {
                funcResult = Math.Pow(x, 2);
            }
            else if (radioButton3.Checked)
            {
                funcResult = Math.Pow(Math.E, x);
            }

            result = Math.Min(funcResult + y, y - z) / Math.Max(funcResult, y);

            textBox3.Text = result.ToString();            

        }
    }
}
