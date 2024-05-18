using System;
using System.Windows.Forms;
using System.Drawing;

namespace Task1
{
    public partial class Form1 : Form
    {
        private int openDocuments = 0;

        // Создание новых элементов StatusStrip и ToolStripStatusLabel
        StatusStrip statusStrip = new StatusStrip();
        ToolStripStatusLabel spWin = new ToolStripStatusLabel();
        ToolStripStatusLabel spData = new ToolStripStatusLabel();

        public Form1()
        {
            InitializeComponent();

            // Установка этой формы как контейнера MDI
            this.IsMdiContainer = true;

            // Создание нового элемента ToolStrip
            ToolStrip toolStrip = new ToolStrip();

            // Создание новых кнопок для ToolStrip
            ToolStripButton toolStripButton1 = new ToolStripButton();
            toolStripButton1.Tag = "NewDoc";
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Image.FromFile("C:\\Users\\USER\\Desktop\\36ТП\\3 курс\\Практика Толочко\\Ivanov_Practice24\\Practice24\\Task1\\bin\\Debug\\net6.0-windows\\DSC_60455.JPG");
            toolStripButton1.ToolTipText = "Create new document";

            ToolStripButton toolStripButton2 = new ToolStripButton();
            toolStripButton2.Tag = "Cascade";
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Image.FromFile("C:\\Users\\USER\\Desktop\\36ТП\\3 курс\\Практика Толочко\\Ivanov_Practice24\\Practice24\\Task1\\bin\\Debug\\net6.0-windows\\DSC_60455.JPG");
            toolStripButton2.ToolTipText = "Windows cascade";

            ToolStripButton toolStripButton3 = new ToolStripButton();
            toolStripButton3.Tag = "Title";
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = Image.FromFile("C:\\Users\\USER\\Desktop\\36ТП\\3 курс\\Практика Толочко\\Ivanov_Practice24\\Practice24\\Task1\\bin\\Debug\\net6.0-windows\\DSC_60455.JPG");
            toolStripButton3.ToolTipText = "Windows title";

            // Добавление кнопок и разделителя в ToolStrip
            toolStrip.Items.Add(toolStripButton1);
            toolStrip.Items.Add(new ToolStripSeparator());
            toolStrip.Items.Add(toolStripButton2);
            toolStrip.Items.Add(toolStripButton3);

            // Добавление ToolStrip на форму
            this.Controls.Add(toolStrip);

            // Добавление обработчика событий для ToolStrip
            toolStrip.ItemClicked += new ToolStripItemClickedEventHandler(toolStrip1_ItemClicked);

            // Настройка элементов StatusStrip
            spWin.Text = "Status";
            spWin.Name = "spWin";
            spData.Text = "Data";
            spData.Name = "spData";

            // Добавление элементов StatusStrip на форму
            statusStrip.Items.Add(spWin);
            statusStrip.Items.Add(spData);
            this.Controls.Add(statusStrip);

            // Установка текущей даты для spData
            spData.Text = DateTime.Today.ToLongDateString();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Tag.ToString())
            {
                case "NewDoc":
                    Form newForm = new Form();
                    newForm.MdiParent = this;
                    newForm.Show();
                    newForm.Text = "New Document " + ++openDocuments;
                    break;
                case "Cascade":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
                    spWin.Text = "Windows is cascade";
                    break;
                case "Title":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
                    spWin.Text = "Windows is horizontal";
                    break;
            }
        }
    }
}
