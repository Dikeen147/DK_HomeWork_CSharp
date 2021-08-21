using System.Windows.Forms;

namespace W8_T2_TextBoxAndNumericUpDown
{
    /*
     Работа Долгова Константина

    Вебинар 8. Задача 2.
    Создайте простую форму на котором свяжите свойство 
    Text элемента TextBox со свойством Value элемента NumericUpDown
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            numericUpDown1.ValueChanged += delegate
            {
                textBox1.Text = numericUpDown1.Value.ToString();
            };
        }
    }
}
