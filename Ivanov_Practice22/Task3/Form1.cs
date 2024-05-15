using System.Diagnostics.CodeAnalysis;

namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double b  = Convert.ToDouble(textBox4.Text);

            richTextBox1.Text = "Работу выполнил уч-ся 36тп Иванов А.А." + Environment.NewLine;

            double x = x0;
            while (x <= (xk + dx / 2))
            {
                double y = 9 * (Math.Pow(x, 3) + Math.Pow(b, 3)) * Math.Tan(x);
                richTextBox1.Text += "x=" + Convert.ToString(x) + "; y=" + Convert.ToString(y) + Environment.NewLine;
            }
        }
    }
}
