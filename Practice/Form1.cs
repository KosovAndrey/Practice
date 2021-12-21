using Practice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika
namespace WinAnim

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
            System.Threading.Thread.Sleep(3000);
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
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работа кипит!!!");
        }

        private void help_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider1.HelpNamespace);
            MessageBox.Show("Работа");
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
        private void btn_AW_BLEND_Click(object sender, EventArgs e)
        {
            this.Hide();
            WinAPIClass.AnimateWindow(this, 3000, WinAPIClass.AnimateWindowFlags.AW_ACTIVATE |
                WinAPIClass.AnimateWindowFlags.AW_BLEND);
            this.btnAW_BLEND.Invalidate();
            this.btnHOR_AW_SLIDE.Invalidate();
            this.btnCenter_AW_SLIDE.Invalidate();
        }

        private void btnHOR_AW_SLIDE_Click(object sender, EventArgs e)
        {
            this.Hide();
            WinAPIClass.AnimateWindow(this, 3000, WinAPIClass.AnimateWindowFlags.AW_HOR_POSITIVE |
                WinAPIClass.AnimateWindowFlags.AW_SLIDE);
            this.btnAW_BLEND.Invalidate();
            this.btnHOR_AW_SLIDE.Invalidate();
            this.btnCenter_AW_SLIDE.Invalidate();
        }

        private void btnCenter_AW_SLIDE_Click(object sender, EventArgs e)
        {
            this.Hide();
            WinAPIClass.AnimateWindow(this, 3000, WinAPIClass.AnimateWindowFlags.AW_CENTER |
                WinAPIClass.AnimateWindowFlags.AW_CENTER);
            this.btnAW_BLEND.Invalidate();
            this.btnHOR_AW_SLIDE.Invalidate();
            this.btnCenter_AW_SLIDE.Invalidate();
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Файлы pdf |*.pdf";
            openFileDialog1.ShowDialog();
            axAcroPDF1.LoadFile(openFileDialog1.FileName);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        private void textBox1_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле должно содержать цифры");
            }
        }

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
        private void button1_Click(object sender, EventArgs e)
        {
            TimeConsumingMethodDelegate del = new TimeConsumingMethodDelegate(TimeConsumingMethod);
            del.BeginInvoke(int.Parse(textBox1.Text), null, null);
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int i;
            i = int.Parse(e.Argument.ToString());
            for (int j = 1; j <= i; j++)
            {
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                System.Threading.Thread.Sleep(1000);
                backgroundWorker1.ReportProgress((int)(j * 100 / i));
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!(e.Cancelled))
                System.Windows.Forms.MessageBox.Show("Run Completed");
            else
                System.Windows.Forms.MessageBox.Show("Run Canceled");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text == ""))
            {
                int i = int.Parse(textBox1.Text);
                backgroundWorker1.RunWorkerAsync(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }
    }
}