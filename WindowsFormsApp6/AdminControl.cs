using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class AdminControl : Form
    {

        public AdminControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(textBox2.Text);
            Class1 cs = new Class1();
            int no = cs.add_data(textBox1.Text, price);
            if (no > 0)
            {
                MessageBox.Show("New Movie Added...!");
            }
            else
            {
                MessageBox.Show("Error");
            }

            DataTable dt = new DataTable();
            dt = cs.topMovies();
            dataGridView1.DataSource = dt;
          }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            

              Class1 cs = new Class1();
              int no = cs.addUpcommingMovies(textBox3.Text,dateTimePicker1.Value);
              if (no > 0)
              {
                  MessageBox.Show("New Upcomming Movie Added...!");
              }
              else
              {
                  MessageBox.Show("Error");
              }

              DataTable dt2 = new DataTable();
              dt2 = cs.upcommingMovies();
              dataGridView2.DataSource = dt2;


          }

        private void button5_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.SetVisibleCore(false);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Delete d = new Delete();
            d.Show();
            this.SetVisibleCore(false);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete d = new Delete();
            d.Show();
            this.SetVisibleCore(false);
        }
    }

       
    }

