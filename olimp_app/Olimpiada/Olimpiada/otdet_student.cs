using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Olimpiada
{
    public partial class otdet_student : UserControl
    {
        connection conn = new connection();
        String filter = null;
        private bool isCalculatingAverage = false;

        public otdet_student()
        {
            InitializeComponent();
        }

        private void otdet_student_Load(object sender, EventArgs e)
        {
            try 
            {
                this.студентыTableAdapter.Fill(this.dB_olimpDataSet1.Студенты);
                this.оценкиTableAdapter.Fill(this.dB_olimpDataSet1.Оценки);
                average_score();
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            }
        }

        public void average_score ()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            string querystring = $"SELECT AVG(Оценка) FROM Оценки";
            SqlCommand command = new SqlCommand(querystring, conn.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            // Получаем результат из DataTable
            double average_score = 0;
            if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
            {
                average_score = Convert.ToDouble(dt.Rows[0][0]);
            }

            label3.Text = $"Общая средняя = {average_score:F2}";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var student_id = textBox1.Text;
            оценкиBindingSource.Filter = string.Format($"Номер_Студента_FK = {student_id}");
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isCalculatingAverage)
            {
                isCalculatingAverage = true;

                var group_id = guna2ComboBox1.Text;
                студентыBindingSource.Filter = string.Format($"Зачислен_Группа_FK = {group_id}");
                guna2Button2_Click(sender, e);

                // Вычисляем среднее арифметическое оценок выбранной группы
                average_score_one_group(group_id);

                isCalculatingAverage = false;
            }
        }

        public void average_score_one_group(String group_id)
        {
            double averageScore = 0;
            int count = 0;

            // Получаем индекс столбца "Оценка"
            int columnIndex = -1;
            foreach (DataGridViewColumn column in guna2DataGridView1.Columns)
            {
                if (column.HeaderText == "Оценка")
                {
                    columnIndex = column.Index;
                    break;
                }
            }

            if (columnIndex != -1) // Проверяем, был ли найден столбец "Оценка"
            {
                foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                {
                    if (!row.IsNewRow && row.Cells[columnIndex].Value != null && double.TryParse(row.Cells[columnIndex].Value.ToString(), out double score))
                    {
                        averageScore += score;
                        count++;
                    }
                }

                if (count > 0)
                {
                    averageScore /= count;
                    label2.Text = $"Средняя группы ({group_id}) = {averageScore:F2}"; // Отображаем среднее с двумя знаками после запятой
                }
                else
                {
                    label2.Text = $"Средняя группы ({group_id}) = Нет данных"; // Если нет данных, выводим сообщение об этом
                }
            }
            else
            {
                label2.Text = $"Средняя группы ({group_id}) = Невозможно найти столбец 'Оценка'"; // Если столбец "Оценка" не найден, выводим сообщение об этом
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            студентыBindingSource.Filter = null;
            оценкиBindingSource.Filter = null;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            List<int> student_id_list = new List<int>();
            foreach (DataGridViewRow row in guna2DataGridView2.Rows)
            {
                if (!row.IsNewRow && row.Cells[0].Value != null && int.TryParse(row.Cells[0].Value.ToString(), out int id)) // Проверка на новую строку, наличие значения и конвертацию в int
                {
                    student_id_list.Add(id); // Добавляем Номер_студента в список
                }
            }

            if (student_id_list.Any())
            {
                string filter = string.Join(",", student_id_list.Select(id => id.ToString()));
                оценкиBindingSource.Filter = $"Номер_Студента_FK IN ({filter})";
            }
            else
            {
                оценкиBindingSource.Filter = null; // Очищаем фильтр, если список пуст
            }
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            otdet_student_Load(sender, e);
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh_vid_job();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            оценкиBindingSource.Filter = $"{filter}";
        }

        public void refresh_vid_job()
        {
            try
            {
                var exam = guna2ComboBox2.Text;
                filter = оценкиBindingSource.Filter; // Получаем текущий фильтр

                // Проверяем, есть ли уже какой-то фильтр
                if (!string.IsNullOrEmpty(filter))
                {
                    // Если уже есть фильтр, убираем его и заменяем новым фильтром только по Виду_Работы
                    int indexOfLastFilter = filter.LastIndexOf(" AND ");
                    if (indexOfLastFilter >= 0)
                    {
                        filter = filter.Substring(0, indexOfLastFilter); // Убираем последнее условие
                    }
                }

                оценкиBindingSource.Filter = $"{filter} AND Вид_Работы = '{exam}'";
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
    }
}
