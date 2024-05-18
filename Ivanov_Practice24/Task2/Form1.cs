using System;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection.Emit;

namespace WinButNum
{
    public class ClickButton : Button
    {
        int mClicks;

        public int Clicks
        {
            get { return mClicks; }
        }

        protected override void OnClick(EventArgs e)
        {
            mClicks++;
            base.OnClick(e);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics g = pevent.Graphics;
            SizeF stringsize;
            stringsize = g.MeasureString(Clicks.ToString(), Font, Width);
            g.DrawString(Clicks.ToString(), Font, SystemBrushes.ControlText, Width - stringsize.Width - 3, Height - stringsize.Height - 3);
        }
    }
}

namespace Task2
{
    public partial class Form1 : Form
    {
        // Создание нового элемента управления Label и Timer
        System.Windows.Forms.Label timeLabel = new System.Windows.Forms.Label();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public Form1()
        {
            // Настройка элемента управления Label
            timeLabel.Font = new System.Drawing.Font("Arial", 24F);
            timeLabel.Width = 200;
            timeLabel.Height = 100;
            timeLabel.Location = new System.Drawing.Point(10, 10);

            // Настройка элемента управления Timer
            timer.Interval = 1000; // Установка интервала в 1 секунду
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_Tick);

            // Добавление элементов управления на UserControl
            this.Controls.Add(timeLabel);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Обновление текста элемента управления Label текущим временем
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        public bool TimeEnabled
        {
            get { return timer.Enabled; }
            set { timer.Enabled = value; }
        }
    }
}
