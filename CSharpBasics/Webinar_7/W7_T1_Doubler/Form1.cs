using System;
using System.Windows.Forms;

namespace W7_T1_Doubler
{
    public partial class Form1 : Form, IView
    {
        public string Number { set => lblNumber.Text = value; }
        public string MultiCmdCount { set => lblMultiCmdCount.Text = value; }
        public string Steps { get => lblStepCount.Text; set => lblStepCount.Text = value; }
        public string Random { set => lblRandomNumber.Text = value; }
        public string StepText { set => lblSteps.Text = value; }

        public Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            lblRandomNumber.Text = string.Empty;
            lblStepCount.Visible = false;
            lblSteps.Text = string.Empty;

            Presenter presenter = new Presenter(this);

            // Кнопка сброс
            btnReset.Click += delegate 
            { 
                presenter.ResetClick();
                lblStepCount.Visible = false;
            };
            // кнопка сложения
            btnAdd.Click += delegate 
            { 
                presenter.AddClick();
                btnMulti.Enabled = presenter.isEnabledMulti(presenter.Number);
                btnCancel.Enabled = presenter.isEnabledCancel(presenter.Stack.Count);
            };
            // кнопка умножения
            btnMulti.Click += delegate 
            {
                presenter.MultiClick();
            };
            // кнопка отмены
            btnCancel.Click += delegate 
            { 
                presenter.CancelClick();
                btnMulti.Enabled = presenter.isEnabledMulti(presenter.Number);
                btnCancel.Enabled = presenter.isEnabledCancel(presenter.Stack.Count);
            };
            // пункт меню играть
            menuItemPlay.Click += delegate 
            {
                int randNumber = new GenerateNumber().GetRandNumber();
                presenter.ResetClick();
                presenter.RandonNumber = randNumber;
                Steps = presenter.StepCount(randNumber).ToString();
                presenter.Steps = int.Parse(Steps);
                btnMulti.Enabled = false;
                btnCancel.Enabled = false;
                lblStepCount.Visible = true;

                lblRandomNumber.Text = $"Получите число: {randNumber}\nза мин. кол-во ходов";
                lblSteps.Text = $"Осталось ходов:";
            };
            lblNumber.TextChanged += delegate
            {
                if (int.Parse(lblNumber.Text) == presenter.RandonNumber)
                {
                    MessageBox.Show("Great! You win!");
                    presenter.ResetClick();
                    lblStepCount.Visible = false;
                }
            };
        }
    }
}
