using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Olimpiada
{
    public partial class Form1 : Form
    {

        connection conn = new connection();

        public Form1()
        {
            InitializeComponent();
        }

        public void teacher_user(DataTable dataTable) 
        {
            int sotrud_id = Convert.ToInt16(dataTable.Rows[0]["Номер_Сотрудника"].ToString());
            string vacation = dataTable.Rows[0]["Должность"].ToString();
            string num_group_sotridnika = dataTable.Rows[0]["Номер_Группы_FK"].ToString();
            string first_name = dataTable.Rows[0]["Фамилия"].ToString();
            string last_name = dataTable.Rows[0]["Имя"].ToString();
            user_name.Vacation = vacation;
            user_name.Sotrud_ID = sotrud_id;
            user_name.Num_group_sotruknika = num_group_sotridnika;
            user_name.First_name = first_name;
            user_name.Last_name = last_name;
            Console.WriteLine("guna2Button1_Click: Stage 4 - teacher_user\n");
        }

        public void student_user(DataTable dataTable)
        {
            // Получаем номер студента из базы данных
            int student_id = Convert.ToInt16(dataTable.Rows[0]["Номер_студента"].ToString());
            string first_name = dataTable.Rows[0]["Фамилия"].ToString();
            string last_name = dataTable.Rows[0]["Имя"].ToString();
            user_name.Student_ID = student_id;
            user_name.First_name = first_name;
            user_name.Last_name = last_name;
            Console.WriteLine($"student_id - {student_id}");
        }

        public void query_student(String Login, String Password, String Role)
        {
            Console.WriteLine("query_student: Stage 3");
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            string querystring = $"SELECT Номер_студента, Фамилия, Имя, Логин, Пароль FROM Студенты WHERE Логин = '{Login}' and Пароль = '{Password}'";
            SqlCommand command = new SqlCommand(querystring, conn.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                student_user(dataTable);

                MessageBox.Show($"Добро пожаловать {Login}", $"Вы - {Role}");
                this.Hide();
                var F_Student = new F_Student();
                F_Student.Closed += (s, args) => this.Close();
                F_Student.Show();
            }
            Console.WriteLine("guna2Button1_Click: Stage 2 - query_student");
        }

        public void query_sotrud(String Login, String Password, String Role)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            string querystring = $"SELECT Номер_Сотрудника, Должность, Номер_Группы_FK, Фамилия, Имя, Логин, Пароль FROM Сотрудники WHERE Логин = '{Login}' and Пароль = '{Password}'";
            SqlCommand command = new SqlCommand(querystring, conn.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            // Если найден сотрудник, то переходим к определению роли...
            if (dataTable.Rows.Count == 1)
            {
                string roleFromDb = dataTable.Rows[0]["Должность"].ToString(); // Получаем роль из базы данных

                if (roleFromDb == "Преподаватель" && Role == "Преподаватель")
                {
                    teacher_user(dataTable);

                    MessageBox.Show($"Добро пожаловать {Login}", $"Вы - {Role}");
                    this.Hide();
                    var F_Teacher = new F_Teacher();
                    F_Teacher.Closed += (s, args) => this.Close();
                    F_Teacher.Show();
                }
                else if (roleFromDb == "Заведующий отделением" && Role == "Заведующий отделением")
                {
                    MessageBox.Show($"Добро пожаловать {Login}", $"Вы - {Role}");
                    this.Hide();
                    var F_Otdet = new F_Otdet();
                    F_Otdet.Closed += (s, args) => this.Close();
                    F_Otdet.Show();
                }
            }
            Console.WriteLine("guna2Button1_Click: Stage 3 - query_sotrud");
        }

        public void query_secretar(String Login, String Role)
        {
            MessageBox.Show($"Добро пожаловать {Login}", $"Вы - {Role}");
            this.Hide();
            var F_Secretory = new F_Secretory();
            F_Secretory.Closed += (s, args) => this.Close();
            F_Secretory.Show();
            Console.WriteLine("\nguna2Button1_Click: Stage 1 - query_secretar");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Проверим введены ли значения в textBox
            if (guna2TextBox1.Text.Length >= 5 && guna2TextBox2.Text.Length >= 5)
            {
                var Login = guna2TextBox1.Text;
                var Password = guna2TextBox2.Text;
                var Role = guna2ComboBox1.Text;

                if (Role == "Секретарь" && Login == "secretary" && Password == "Ctrh3nfh)")
                {
                    query_secretar(Login, Role);
                }
                else if (Role == "Студент")
                {
                    query_student(Login, Password, Role);
                }

                else if (Role == "Заведующий отделением" || Role == "Преподаватель")
                {
                    query_sotrud(Login, Password, Role);
                }
                else
                {
                    Console.WriteLine($"guna2Button1_Click - \nlogin = {Login}\npassword = {Password}\nrole = {Role}");
                    MessageBox.Show($"Введены неверный логин или пароль.", "Попробуйте снова.");
                }
            }
            else
            {
                MessageBox.Show($"Логин и пароль должны состоять из не менее 5 символов.", "Попробуйте снова.");
            }
        }
    }
}
