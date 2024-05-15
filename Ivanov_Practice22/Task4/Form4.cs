using System.Windows.Forms;

namespace Task4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { Name, Surname, MiddleName, Email, PhoneNumber };
            ComboBox[] comboBoxes = { LocationCity, CallOperator };
            RadioButton[] radioButtons = { Male, Female };
            RadioButton[] workExpRadioButtons = { NotWorking, LessThanOneYear, FromOneToFiveYears, FromFiveToNineYears, MoreThanTenYears };
            CheckBox[] categoryCheckboxes = { DriverCategoryA, DriverCategoryB, DriverCategoryC, DriverCategoryD };
            RadioButton[] workGraphicRadioButtons = { FullTime, PartTime, WorkAtHome, TimeWork };
            NumericUpDown[] numericUpDowns = { MinSalary, MaxSalary };

            string GetSelectedRadioButtonText(RadioButton[] radioButtons)
            {
                foreach (RadioButton radioButton in radioButtons)
                {
                    if (radioButton.Checked)
                    {
                        return radioButton.Text;
                    }
                }
                return "";
            }

            string GetSelectedCheckBoxText(CheckBox[] checkBoxes)
            {
                string result = "";
                foreach (CheckBox checkBox in checkBoxes)
                {
                    if (checkBox.Checked)
                    {
                        result += checkBox.Text;
                    }
                }
                return result;
            }

            string[] textBoxValues = textBoxes.Select(textBox => textBox.Text).ToArray();

            string[] comboBoxValues = comboBoxes.Select(comboBox => comboBox.Text).ToArray();

            string sex = GetSelectedRadioButtonText(radioButtons);
            string dateOfBirth = DateBirth.Text;

            string workExp = GetSelectedRadioButtonText(workExpRadioButtons);
            if (workExp == "")
            {
                MessageBox.Show("�� ������ ���� ������");
                return;
            }

            string driveCategory = GetSelectedCheckBoxText(categoryCheckboxes);

            string workGraphic = GetSelectedRadioButtonText(workGraphicRadioButtons);
            if (workGraphic == "")
            {
                MessageBox.Show("�������� ������ ������");
                return;
            }

            string salaryFrom = Convert.ToString(MinSalary.Value);
            string salaryTo = Convert.ToString(MaxSalary.Value);
                    
            AboutMe.AppendText($"�������: {textBoxValues[1]}\n");
            AboutMe.AppendText($"���: {textBoxValues[0]}\n");
            AboutMe.AppendText($"��������: {textBoxValues[2]}\n");
            AboutMe.AppendText($"���: {sex}\n");
            AboutMe.AppendText($"���� ��������: {dateOfBirth}\n");
            AboutMe.AppendText($"����� ����������: {comboBoxValues[0]}\n");
            AboutMe.AppendText($"����������� �����: {textBoxValues[3]}\n");
            AboutMe.AppendText($"�������: {textBoxValues[4]}\n");
            AboutMe.AppendText($"�������� �����: {comboBoxValues[1]}\n");
            AboutMe.AppendText($"���� ������: {workExp}\n");
            AboutMe.AppendText($"������ ����������: {(HaveAPersonalCar.Checked ? "��" : "���")}\n");
            AboutMe.AppendText($"������������ �������������: {(DriverLicense.Checked ? "��" : "���")}\n");
            AboutMe.AppendText($"��������� ������������ ����: {driveCategory}\n");
            AboutMe.AppendText($"�������� ��: {salaryFrom}\n");
            AboutMe.AppendText($"�������� ��: {salaryTo}\n");
            AboutMe.AppendText($"������ ������: {workGraphic}\n");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { Name, Surname, MiddleName, Email, PhoneNumber };
            ComboBox[] comboBoxes = { LocationCity, CallOperator };
            RadioButton[] radioButtons = { Male, Female };
            RadioButton[] workExpRadioButtons = { NotWorking, LessThanOneYear, FromOneToFiveYears, FromFiveToNineYears, MoreThanTenYears };
            CheckBox[] categoryCheckboxes = { DriverCategoryA, DriverCategoryB, DriverCategoryC, DriverCategoryD };
            RadioButton[] workGraphicRadioButtons = { FullTime, PartTime, WorkAtHome, TimeWork };
            NumericUpDown[] numericUpDowns = { MinSalary, MaxSalary };

            foreach (TextBox textBox in textBoxes)
            {
                textBox.Text = "";
            }

            foreach (ComboBox comboBox in comboBoxes)
            {
                comboBox.SelectedIndex = -1;
            }

            foreach (RadioButton radioButton in radioButtons)
            {
                radioButton.Checked = false;
            }

            foreach (CheckBox checkBox in categoryCheckboxes)
            {
                checkBox.Checked = false;
            }

            foreach (NumericUpDown numericUpDown in numericUpDowns)
            {
                numericUpDown.Value = numericUpDown.Minimum;
            }

            AboutMe.Clear();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
