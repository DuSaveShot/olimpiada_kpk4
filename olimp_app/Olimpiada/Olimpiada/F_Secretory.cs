using System;
using System.Windows.Forms;

namespace Olimpiada
{
    public partial class F_Secretory : Form
    {
        public F_Secretory()
        {
            InitializeComponent();
        }

        private void F_Secretory_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_olimpDataSet1.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.dB_olimpDataSet1.Студенты);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            студентыBindingSource.EndEdit();
            студентыTableAdapter.Update(dB_olimpDataSet1.Студенты);
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form1 = new Form1();
            Form1.Closed += (s, args) => this.Close();
            Form1.Show();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            F_Secretory_Load(sender, e);
        }
    }
}
