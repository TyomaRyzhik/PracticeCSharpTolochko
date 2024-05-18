using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Task3
{

    public class GradientProgressBar : ProgressBar
    {
        public GradientProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush brush = null;
            Rectangle rec = new Rectangle(0, 0, this.Width, this.Height);

            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, rec);

            rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 4;
            rec.Height = rec.Height - 4;
            if (rec.Width != 0)
            {
                brush = new LinearGradientBrush(rec, this.ForeColor, this.BackColor, LinearGradientMode.ForwardDiagonal);
                e.Graphics.FillRectangle(brush, 2, 2, rec.Width, rec.Height);
            }

            using (Font f = new Font(FontFamily.GenericSansSerif, 10))
            {
                string percent = ((double)Value / Maximum).ToString("P0");
                SizeF size = e.Graphics.MeasureString(percent, f);
                PointF location = new PointF((Width - size.Width) / 2, (Height - size.Height) / 2);
                e.Graphics.DrawString(percent, f, Brushes.Black, location);
            }
        }
    }
    public partial class Form1 : Form
    {
        private Label label;
        private GradientProgressBar progressBar;
        private CheckBox checkBox1;
        private CheckBox checkBox2;

        public Form1()
        {
            InitializeComponent();

            label = new Label();
            label.Location = new Point(50, 10);
            label.Width = 300;
            label.Text = "Процент готовности задания";
            this.Controls.Add(label);

            progressBar = new GradientProgressBar();
            progressBar.Location = new Point(50, 50);
            progressBar.Width = 200;
            this.Controls.Add(progressBar);

            checkBox1 = new CheckBox();
            checkBox1.Text = "Задание 1";
            checkBox1.Location = new Point(50, 100);
            checkBox1.CheckedChanged += CheckBox_CheckedChanged;
            this.Controls.Add(checkBox1);

            checkBox2 = new CheckBox();
            checkBox2.Text = "Задание 2";
            checkBox2.Location = new Point(50, 130);
            checkBox2.CheckedChanged += CheckBox_CheckedChanged;
            this.Controls.Add(checkBox2);
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int progress = 0;
            if (checkBox1.Checked) progress += 50;
            if (checkBox2.Checked) progress += 50;
            progressBar.Value = progress;
        }
    }

}
