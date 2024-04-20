using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Olimpiada
{
    public partial class F_Teacher : Form
    {
        connection conn = new connection();

        public F_Teacher()
        {
            InitializeComponent();
        }

        private void F_Teacher_Load(object sender, EventArgs e)
        {
            int sotrud_id = user_name.Sotrud_ID;
            string vacation = user_name.Vacation;
            string num_group_sotridnika = user_name.Num_group_sotruknika;
            string first_name = user_name.First_name;
            string last_name = user_name.Last_name;

            this.дисциплиныTableAdapter.Fill(this.dB_olimpDataSet1.Дисциплины);
            дисциплиныBindingSource.Filter = string.Format($"Преподаватель_FK = {sotrud_id}");
            label2.Text = first_name + " " + last_name;

            this.студенты_minTableAdapter.Fill(this.dB_olimpDataSet1.Студенты_min);
            студентыminBindingSource.Filter = string.Format($"Зачислен_Группа_FK = {num_group_sotridnika}");

            this.оценкиTableAdapter.Fill(this.dB_olimpDataSet1.Оценки);

            // Получаем значения из первого столбца DataGridView и добавляем их в ComboBox
            comboBox1_discipline();
        }

        public void comboBox1_discipline()
        {
            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                if (!row.IsNewRow) // Проверка на новую строку
                {
                    object cellValue = row.Cells[0].Value; // Значение ячейки первого столбца
                    if (cellValue != null) // Проверка на null, чтобы избежать ошибок
                    {
                        guna2ComboBox1.Items.Add(cellValue.ToString());
                    }
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try 
            {
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(guna2ComboBox1.Text) || string.IsNullOrEmpty(guna2ComboBox2.Text) || guna2RatingStar1.Value != 0)
                {
                    var student_id = textBox1.Text;
                    var discipline = guna2ComboBox1.Text;
                    var vid_rabot = guna2ComboBox2.Text;
                    var score = (int)Math.Ceiling(guna2RatingStar1.Value);
                    var date_score = guna2DateTimePicker1.Value.ToString("yyyy-MM-dd");

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    string querystring = $"INSERT INTO Оценки (Номер_Студента_FK,Номер_Дисциплины_FK,Вид_Работы,Оценка,Дата_сдачи)" +
                        $" VALUES ({student_id}, {discipline}, '{vid_rabot}', {score}, '{date_score}')";
                    SqlCommand command = new SqlCommand(querystring, conn.getConnection());
                    adapter.SelectCommand = command;
                    adapter.Fill(dt);
                    MessageBox.Show($"Ученик номер - ({student_id})\nДисциплина - {discipline}\nВид работы - {vid_rabot}\nОценка - {score}\nДата сдачи - {date_score}", "Оценка добавлена");
                }
                else 
                {
                    MessageBox.Show($"Заполните все поля.", "Действие не выполнено");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form1 = new Form1();
            Form1.Closed += (s, args) => this.Close();
            Form1.Show();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            F_Teacher_Load(sender, e);
        }
    }
}
