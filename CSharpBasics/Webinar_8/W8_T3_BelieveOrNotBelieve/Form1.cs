using System;
using System.Windows.Forms;

namespace W8_T3_BelieveOrNotBelieve
{
    /*
     Работа Долгова Константина

    Вебинар 8. Задание 3.
    а) Создать приложение, показанное на уроке, добавив в него защиту 
    от возможных ошибок (не создана база данных, обращение к несуществующему 
    вопросу, открытие слишком большого файла и т.д.).
    б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов 
    и добавив другие «косметические» улучшения на свое усмотрение.
    в) Добавить в приложение меню «О программе» с информацией о программе 
    (автор, версия, авторские права и др.).
     */
    public partial class Form1 : Form
    {
        TrueFalse database;
        public Form1()
        {
            InitializeComponent();
            ClickEventHandler();
        }

        private void ClickEventHandler()
        {
            miNew.Click += MiNew_Click;
            miOpen.Click += MiOpen_Click;
            miSave.Click += MiSave_Click;
            miExit.Click += delegate { this.Close(); };

            nudNumber.ValueChanged += NudNumber_ValueChanged;

            btnAdd.Click += BtnAdd_Click;
            btnDelete.Click += BtnDelete_Click;
            btnSaveQuest.Click += BtnSaveQuest_Click;

            aboutProgram.Click += AboutProgram_Click;
            aboutAuthor.Click += AboutAuthor_Click;
        }

        private void AboutAuthor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author: GeekBrains\nCopyPaste by Konstantin Dolgov", "Author");
        }

        private void AboutProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Some program... \nSo...\nThis is the last home work", "Program");
        }

        private void BtnSaveQuest_Click(object sender, EventArgs e)
        {
            database[(int)nudNumber.Value - 1].text = tboxQuestion.Text;
            database[(int)nudNumber.Value - 1].trueFalse = cboxTrue.Checked;
        }

        private void MiOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    database = new TrueFalse(ofd.FileName);
                    database.LoadJson();
                    nudNumber.Minimum = 1;
                    nudNumber.Maximum = database.Count;
                    nudNumber.Value = 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка открытия файла!" +
                                    $"\n\n{ex.Message}");
                }
            }
        }

        private void MiSave_Click(object sender, EventArgs e)
        {
            if (database != null) database.SaveJson();
            else MessageBox.Show("База данных не создана");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (nudNumber.Maximum == 1 || database == null) return;
            database.Remove((int)nudNumber.Value);
            nudNumber.Maximum--;
            if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            database.Add((database.Count + 1).ToString(), true);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }

        private void NudNumber_ValueChanged(object sender, EventArgs e)
        {
            tboxQuestion.Text = database[(int)nudNumber.Value - 1].text;
            cboxTrue.Checked = database[(int)nudNumber.Value - 1].trueFalse;
        }

        private void MiNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    database = new TrueFalse(sfd.FileName);
                    database.Add("123", true);
                    database.SaveJson();
                    nudNumber.Minimum = 1;
                    nudNumber.Maximum = 1;
                    nudNumber.Value = 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка создания базы данных!" +
                                    $"\n\n{ex.Message}");
                }
            };
        }
    }
}
