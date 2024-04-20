using System;
using System.Windows.Forms;

namespace Olimpiada
{
    public partial class Studenti : UserControl
    {
        public Studenti()
        {
            InitializeComponent();
        }   

        private void Studenti_Load(object sender, EventArgs e)
        {
            int student_id = user_name.Student_ID;
            string first_name = user_name.First_name;
            string last_name = user_name.Last_name;

            this.оценкиTableAdapter.Fill(this.dB_olimpDataSet1.Оценки);
            Console.WriteLine($"{student_id}");
            оценкиBindingSource.Filter = string.Format($"Номер_Студента_FK = {student_id}");
            label2.Text = first_name + " " + last_name;
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Studenti_Load(sender, e);
        }
    }
}
