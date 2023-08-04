using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp6
{
    public partial class BookNow : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Akshay Mahajan\Documents\localDB.mdf;Integrated Security=True;Connect Timeout=30");
        public BookNow()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Akshay Mahajan\Documents\localDB.mdf;Integrated Security=True;Connect Timeout=30");
           // con.Open();
           /* SqlCommand cmd = new SqlCommand("select * from Movie where MovieName='" + comboBox1.Text + "'");
           
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            
            foreach(DataRow dr in dt.Rows)
            {
                textBox3.Text = dr["price"].ToString();
            }
            con.Close();*/


            con.Open(); 
            SqlCommand cmd = con.CreateCommand(); 
            cmd.CommandType = CommandType.Text; 
            cmd.CommandText = "select * from Movie where MovieName ='" + comboBox1.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery(); DataTable dt = new DataTable(); SqlDataAdapter da = new SqlDataAdapter(cmd); 
            da.Fill(dt); foreach (DataRow dr in dt.Rows) 
            {
                textBox3.Text = dr["price"].ToString(); 
            }
            con.Close();











        }

        private void button2_Click(object sender, EventArgs e)
        {

            int payment = Convert.ToInt32(textBox3.Text);
            

            Class1 cs = new Class1();
            int no=cs.addBookNow(comboBox1.Text,textBox1.Text,textBox2.Text,comboBox2.Text,dateTimePicker1.Value,payment);
            

            if (no > 0)
            {
                MessageBox.Show("You have succesfully booked your show...!");
            }
            else
            {
                MessageBox.Show("Error");
            }

            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox2.Text = "";
            textBox3.Text = "";
       
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.SetVisibleCore(false);
        }

        private void BookNow_Load(object sender, EventArgs e)
        {

            List<string> moviename = Class1.binddata();
            foreach (string MovieName in moviename)
            {
                comboBox1.Items.Add(MovieName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox1.Text = "";
            comboBox2.Text = "";
            
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
