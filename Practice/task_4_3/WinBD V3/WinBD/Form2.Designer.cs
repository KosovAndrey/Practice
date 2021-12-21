namespace WinBD
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SortTextBox = new System.Windows.Forms.TextBox();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.городDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winbdDataSet1 = new WinBD.winbdDataSet();
            this.dataSet11 = new WinBD.DataSet1();
            this.заказчикTableAdapter1 = new WinBD.winbdDataSetTableAdapters.ЗаказчикTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winbdDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT * FROM Заказчик";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\winbd.accdb";
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO `Заказчик` (`Фамилия`, `Имя`) VALUES (?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Фамилия", System.Data.OleDb.OleDbType.VarWChar, 0, "Фамилия"),
            new System.Data.OleDb.OleDbParameter("Имя", System.Data.OleDb.OleDbType.VarWChar, 0, "Имя")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = "UPDATE `Заказчик` SET `Фамилия` = ?, `Имя` = ? WHERE ((`Код` = ?) AND ((? = 1 AND" +
    " `Фамилия` IS NULL) OR (`Фамилия` = ?)) AND ((? = 1 AND `Имя` IS NULL) OR (`Имя`" +
    " = ?)))";
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Фамилия", System.Data.OleDb.OleDbType.VarWChar, 0, "Фамилия"),
            new System.Data.OleDb.OleDbParameter("Имя", System.Data.OleDb.OleDbType.VarWChar, 0, "Имя"),
            new System.Data.OleDb.OleDbParameter("Original_Код", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Код", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Фамилия", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Фамилия", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Фамилия", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Фамилия", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Имя", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Имя", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Имя", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Имя", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = "DELETE FROM `Заказчик` WHERE ((`Код` = ?) AND ((? = 1 AND `Фамилия` IS NULL) OR (" +
    "`Фамилия` = ?)) AND ((? = 1 AND `Имя` IS NULL) OR (`Имя` = ?)))";
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Код", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Код", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Фамилия", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Фамилия", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Фамилия", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Фамилия", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Имя", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Имя", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Имя", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Имя", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Заказчик", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Код", "Код"),
                        new System.Data.Common.DataColumnMapping("Фамилия", "Фамилия"),
                        new System.Data.Common.DataColumnMapping("Имя", "Имя")})});
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Update Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Сортировка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фильтрация";
            // 
            // SortTextBox
            // 
            this.SortTextBox.Location = new System.Drawing.Point(210, 34);
            this.SortTextBox.Name = "SortTextBox";
            this.SortTextBox.Size = new System.Drawing.Size(100, 20);
            this.SortTextBox.TabIndex = 5;
            this.SortTextBox.Text = "Фамилия";
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Location = new System.Drawing.Point(342, 34);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(100, 20);
            this.FilterTextBox.TabIndex = 6;
            this.FilterTextBox.Text = "Город = \'Пушкин\'";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.городDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "Заказчик";
            this.dataGridView1.DataSource = this.winbdDataSet1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(454, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // городDataGridViewTextBoxColumn
            // 
            this.городDataGridViewTextBoxColumn.DataPropertyName = "Город";
            this.городDataGridViewTextBoxColumn.HeaderText = "Город";
            this.городDataGridViewTextBoxColumn.Name = "городDataGridViewTextBoxColumn";
            // 
            // winbdDataSet1
            // 
            this.winbdDataSet1.DataSetName = "winbdDataSet";
            this.winbdDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказчикTableAdapter1
            // 
            this.заказчикTableAdapter1.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(342, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Фильтрация";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 261);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.FilterTextBox);
            this.Controls.Add(this.SortTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winbdDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SortTextBox;
        private System.Windows.Forms.TextBox FilterTextBox;
        private winbdDataSetTableAdapters.ЗаказчикTableAdapter заказчикTableAdapter1;
        private winbdDataSet winbdDataSet1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn городDataGridViewTextBoxColumn;
    }
}