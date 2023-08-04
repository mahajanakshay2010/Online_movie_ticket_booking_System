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
    public partial class Movies : Form
    {
        public Movies()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home m = new Home();
            m.Show();
            this.SetVisibleCore(false);
        }

        private void Movies_Load(object sender, EventArgs e)
        {
            Class1 cs = new Class1();
            DataTable dt = new DataTable();
            dt = cs.topMovies();
            dataGridView1.DataSource = dt;

            DataTable dt1 = new DataTable();
            dt1 = cs.upcommingMovies();
            dataGridView2.DataSource = dt1;
        }
    }
}
