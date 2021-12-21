namespace WinDataBinding
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.winbdDataSet1 = new WinDataBinding.winbdDataSet();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.FamtextBox = new System.Windows.Forms.TextBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.SectiontextBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Previousbutton = new System.Windows.Forms.Button();
            this.Nextbutton = new System.Windows.Forms.Button();
            this.сотрудникиTableAdapter1 = new WinDataBinding.winbdDataSetTableAdapters.СотрудникиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.winbdDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // winbdDataSet1
            // 
            this.winbdDataSet1.DataSetName = "winbdDataSet";
            this.winbdDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"G:\\Практика ПМ 0.1\\Задание 4\\WinDa" +
    "taBinding\\winbd.accdb\"";
            // 
            // FamtextBox
            // 
            this.FamtextBox.Location = new System.Drawing.Point(75, 21);
            this.FamtextBox.Name = "FamtextBox";
            this.FamtextBox.Size = new System.Drawing.Size(197, 20);
            this.FamtextBox.TabIndex = 0;
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(75, 47);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(197, 20);
            this.NametextBox.TabIndex = 1;
            // 
            // SectiontextBox3
            // 
            this.SectiontextBox3.Location = new System.Drawing.Point(75, 74);
            this.SectiontextBox3.Name = "SectiontextBox3";
            this.SectiontextBox3.Size = new System.Drawing.Size(197, 20);
            this.SectiontextBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отдел";
            // 
            // Previousbutton
            // 
            this.Previousbutton.Location = new System.Drawing.Point(75, 110);
            this.Previousbutton.Name = "Previousbutton";
            this.Previousbutton.Size = new System.Drawing.Size(75, 23);
            this.Previousbutton.TabIndex = 6;
            this.Previousbutton.Text = "Previous";
            this.Previousbutton.UseVisualStyleBackColor = true;
            this.Previousbutton.Click += new System.EventHandler(this.Previousbutton_Click);
            // 
            // Nextbutton
            // 
            this.Nextbutton.Location = new System.Drawing.Point(197, 110);
            this.Nextbutton.Name = "Nextbutton";
            this.Nextbutton.Size = new System.Drawing.Size(75, 23);
            this.Nextbutton.TabIndex = 7;
            this.Nextbutton.Text = "Next";
            this.Nextbutton.UseVisualStyleBackColor = true;
            this.Nextbutton.Click += new System.EventHandler(this.Nextbutton_Click);
            // 
            // сотрудникиTableAdapter1
            // 
            this.сотрудникиTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Nextbutton);
            this.Controls.Add(this.Previousbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SectiontextBox3);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.FamtextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.winbdDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private winbdDataSet winbdDataSet1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Windows.Forms.TextBox FamtextBox;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox SectiontextBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Previousbutton;
        private System.Windows.Forms.Button Nextbutton;
        private winbdDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter1;
    }
}

