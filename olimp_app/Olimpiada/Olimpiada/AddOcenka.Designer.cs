namespace Olimpiada
{
    partial class AddOcenka
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dB_olimpDataSet = new Olimpiada.DB_olimpDataSet();
            this.оценкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.оценкиTableAdapter = new Olimpiada.DB_olimpDataSetTableAdapters.ОценкиTableAdapter();
            this.номерОценкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерСтудентаFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерДисциплиныFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видРаботыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оценкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датасдачиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_olimpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оценкиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерОценкиDataGridViewTextBoxColumn,
            this.номерСтудентаFKDataGridViewTextBoxColumn,
            this.номерДисциплиныFKDataGridViewTextBoxColumn,
            this.видРаботыDataGridViewTextBoxColumn,
            this.оценкаDataGridViewTextBoxColumn,
            this.датасдачиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.оценкиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(804, 331);
            this.dataGridView1.TabIndex = 0;
            // 
            // dB_olimpDataSet
            // 
            this.dB_olimpDataSet.DataSetName = "DB_olimpDataSet";
            this.dB_olimpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // оценкиBindingSource
            // 
            this.оценкиBindingSource.DataMember = "Оценки";
            this.оценкиBindingSource.DataSource = this.dB_olimpDataSet;
            // 
            // оценкиTableAdapter
            // 
            this.оценкиTableAdapter.ClearBeforeFill = true;
            // 
            // номерОценкиDataGridViewTextBoxColumn
            // 
            this.номерОценкиDataGridViewTextBoxColumn.DataPropertyName = "Номер_Оценки";
            this.номерОценкиDataGridViewTextBoxColumn.HeaderText = "Номер_Оценки";
            this.номерОценкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерОценкиDataGridViewTextBoxColumn.Name = "номерОценкиDataGridViewTextBoxColumn";
            this.номерОценкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // номерСтудентаFKDataGridViewTextBoxColumn
            // 
            this.номерСтудентаFKDataGridViewTextBoxColumn.DataPropertyName = "Номер_Студента_FK";
            this.номерСтудентаFKDataGridViewTextBoxColumn.HeaderText = "Номер_Студента_FK";
            this.номерСтудентаFKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерСтудентаFKDataGridViewTextBoxColumn.Name = "номерСтудентаFKDataGridViewTextBoxColumn";
            this.номерСтудентаFKDataGridViewTextBoxColumn.Width = 125;
            // 
            // номерДисциплиныFKDataGridViewTextBoxColumn
            // 
            this.номерДисциплиныFKDataGridViewTextBoxColumn.DataPropertyName = "Номер_Дисциплины_FK";
            this.номерДисциплиныFKDataGridViewTextBoxColumn.HeaderText = "Номер_Дисциплины_FK";
            this.номерДисциплиныFKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерДисциплиныFKDataGridViewTextBoxColumn.Name = "номерДисциплиныFKDataGridViewTextBoxColumn";
            this.номерДисциплиныFKDataGridViewTextBoxColumn.Width = 125;
            // 
            // видРаботыDataGridViewTextBoxColumn
            // 
            this.видРаботыDataGridViewTextBoxColumn.DataPropertyName = "Вид_Работы";
            this.видРаботыDataGridViewTextBoxColumn.HeaderText = "Вид_Работы";
            this.видРаботыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.видРаботыDataGridViewTextBoxColumn.Name = "видРаботыDataGridViewTextBoxColumn";
            this.видРаботыDataGridViewTextBoxColumn.Width = 125;
            // 
            // оценкаDataGridViewTextBoxColumn
            // 
            this.оценкаDataGridViewTextBoxColumn.DataPropertyName = "Оценка";
            this.оценкаDataGridViewTextBoxColumn.HeaderText = "Оценка";
            this.оценкаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.оценкаDataGridViewTextBoxColumn.Name = "оценкаDataGridViewTextBoxColumn";
            this.оценкаDataGridViewTextBoxColumn.Width = 125;
            // 
            // датасдачиDataGridViewTextBoxColumn
            // 
            this.датасдачиDataGridViewTextBoxColumn.DataPropertyName = "Дата_сдачи";
            this.датасдачиDataGridViewTextBoxColumn.HeaderText = "Дата_сдачи";
            this.датасдачиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датасдачиDataGridViewTextBoxColumn.Name = "датасдачиDataGridViewTextBoxColumn";
            this.датасдачиDataGridViewTextBoxColumn.Width = 125;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(15, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(281, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Оценка";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(313, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(281, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(15, 74);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(281, 24);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.Text = "Дисциплина";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(313, 13);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(281, 24);
            this.comboBox3.TabIndex = 4;
            this.comboBox3.Text = "Вид работы";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(15, 13);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(281, 24);
            this.comboBox4.TabIndex = 5;
            this.comboBox4.Text = "Студент";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Поставить оценку";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(764, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "->";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(621, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 27);
            this.button3.TabIndex = 8;
            this.button3.Text = "Удалить оценку";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // AddOcenka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddOcenka";
            this.Size = new System.Drawing.Size(832, 467);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_olimpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оценкиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерОценкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерСтудентаFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерДисциплиныFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видРаботыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оценкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датасдачиDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource оценкиBindingSource;
        private DB_olimpDataSet dB_olimpDataSet;
        private DB_olimpDataSetTableAdapters.ОценкиTableAdapter оценкиTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
