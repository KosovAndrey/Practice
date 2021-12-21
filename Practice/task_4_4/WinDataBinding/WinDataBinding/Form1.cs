using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDataBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private BindingSource sotrBindingSource;

        private void Form1_Load(object sender, EventArgs e)
        {
            сотрудникиTableAdapter1.Fill(winbdDataSet1.Сотрудники);
            sotrBindingSource = new BindingSource(winbdDataSet1, "Сотрудники");
            FamtextBox.DataBindings.Add("Text", sotrBindingSource, "Фамилия");
            NametextBox.DataBindings.Add("Text", sotrBindingSource, "Имя");
            SectiontextBox3.DataBindings.Add("Text", sotrBindingSource, "Отдел");
        }

        private void Previousbutton_Click(object sender, EventArgs e)
        {
            sotrBindingSource.MovePrevious();
        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            sotrBindingSource.MoveNext();
        }
    }
}
