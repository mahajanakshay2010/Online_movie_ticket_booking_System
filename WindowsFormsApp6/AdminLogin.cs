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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user = textBox1.Text;
            String pass = textBox2.Text;
            if (user == "Akshay" && pass == "akki")
            {
                MessageBox.Show("Wel-Come");
                AdminControl a = new AdminControl();
                a.Show();
                this.SetVisibleCore(false);
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Details");

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.SetVisibleCore(false);
        }
    }
}
