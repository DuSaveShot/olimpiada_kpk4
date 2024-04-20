using System;
using System.Windows.Forms;

namespace Olimpiada
{
    public partial class F_Student : Form
    {
        public F_Student()
        {
            InitializeComponent();
        }

        private void studenti1_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form1 = new Form1();
            Form1.Closed += (s, args) => this.Close();
            Form1.Show();
        }
    }
}
