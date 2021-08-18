using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W7_T1_Doubler
{
    public partial class Form1 : Form, IView
    {
        public string Number { set => lblNumber.Text = value; }
        public string MultiCmdCount { set => lblMultiCmdCount.Text = value; }

        public Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();

            Presenter presenter = new Presenter(new Model(rnd.Next(20, 250)), this);
            btnReset.Click += delegate { presenter.ResetClick(); };
            btnAdd.Click += delegate { presenter.AddClick(); };
            btnMulti.Click += delegate { presenter.MultiClick(); };
            btnCancel.Click += delegate { presenter.CancelClick(); };
        }
    }
}
