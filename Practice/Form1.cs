using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private delegate int AsyncSumm(int a, int b);

        private int Summ(int a, int b)
        {
            System.Threading.Thread.Sleep(9000);
            return a + b;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = Int32.Parse(txbA.Text);
                b = Int32.Parse(txbB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("При выполнение преоброзования типов возникла ошибка");
                txbA.Text = txbB.Text = "";
                return;
            }

            AsyncSumm summdelegate = new AsyncSumm(Summ);
            AsyncCallback cb = new AsyncCallback(CallBackMethod);
            summdelegate.BeginInvoke(a, b, cb, summdelegate);
        }

        private void CallBackMethod(IAsyncResult ar)
        {
            string str;
            AsyncSumm summdelegate = (AsyncSumm)ar.AsyncState;
            str = String.Format("Сумма введенных чисел равна {0}", summdelegate.EndInvoke(ar));
            MessageBox.Show(str, "Результат операции");
            private void TimeConsumingMethod(int seconds)
            {
                for (int j = 1; j <= seconds; j++)
                {
                    System.Threading.Thread.Sleep(1000);
                    SetProgress((int)(j * 100) / seconds);
                    if (Cancel)
                        break;
                    if (Cancel)
                    {
                        System.Windows.Forms.MessageBox.Show("Cancelled");
                        Cancel = false;
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Complete");
                    }
                }
            }

        private delegate void TimeConsumingMethodEventHandler(int seconds);

        public delegate void SetProgressDelegate(int val);
        public void SetProgress(int val)
        {
            if (progressBar1.InvokeRequired)
            {
                SetProgressDelegate del = new SetProgressDelegate(SetProgress);
                this.Invoke(del, new object[] { val });
            }
            else
            {
                progressBar1.Value = val;
            }
        }
        bool Cancel;

        private void btnWork_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работа кипит!!!");
            private void button1_Click(object sender, EventArgs e)
            {
                TimeConsumingMethodDelegate del = new TimeConsumingMethodDelegate(TimeConsumingMethod);
                del.BeginInvoke(int.Parse(textBox1.Text), null, null);
            }
        }
    }