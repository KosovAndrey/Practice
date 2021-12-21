using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinBD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        DataView ЗаказчикDataView;

        private void button1_Click(object sender, EventArgs e)
        {
            заказчикTableAdapter1.Fill(winbdDataSet1.Заказчик);
            ЗаказчикDataView = new DataView(winbdDataSet1.Заказчик);
            dataGridView1.DataSource = ЗаказчикDataView;
            ЗаказчикDataView.Sort = "Фамилия";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oleDbDataAdapter1.Update(dataSet11);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ЗаказчикDataView.Sort = SortTextBox.Text;
            ЗаказчикDataView.RowFilter = FilterTextBox.Text;
        }
    }
}
