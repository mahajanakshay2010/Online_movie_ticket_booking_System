using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Class1 cs = new Class1();
            DataTable dt = new DataTable();
            dt = cs.topMovies();
            dataGridView1.DataSource = dt;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AdminLogin b = new AdminLogin();
            b.Show();
            this.SetVisibleCore(false);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BookNow bn = new BookNow();
            bn.Show();
            this.SetVisibleCore(false);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //this.pictureBox1.Image=((System.Drawing.Image)(resources)

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Movies m = new Movies();
            m.Show();
            this.SetVisibleCore(false);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
            this.SetVisibleCore(false);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
        }
    }
}
