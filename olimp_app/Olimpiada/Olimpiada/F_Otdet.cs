using System;
using System.Windows.Forms;

namespace Olimpiada
{
    public partial class F_Otdet : Form
    {
        public F_Otdet()
        {
            InitializeComponent();
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
