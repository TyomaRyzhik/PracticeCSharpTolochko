namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            double z = double.Parse(textBox3.Text);

            double res = (Math.Pow(2, Math.Pow(y, x))) + (Math.Pow(Math.Pow(3, x), y)) - (y * (Math.Atan(z) - Math.PI / 6)) / (Math.Abs(x) + (1 / Math.Pow(y, 2) + 1));

            textBox4.Text = res.ToString();
        }
    }
}
