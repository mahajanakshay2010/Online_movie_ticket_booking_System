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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Class1 cs = new Class1();
            cs.deleteData(comboBox1.Text);
           
          //  cs.deleteUpData(textBox1.Text);
            
                MessageBox.Show("Remove Movie Successfully");
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            AdminControl a = new AdminControl();
            a.Show();
            this.SetVisibleCore(false);

        }

        private void Delete_Load(object sender, EventArgs e)
        {
            List<string> moviename = Class1.binddata();
            foreach (string MovieName in moviename)
            {
                comboBox1.Items.Add(MovieName);
            }
            List<string> moviename1 = Class1.bindUpdata();
            foreach (string MovieName in moviename1)
            {
                comboBox2.Items.Add(MovieName);
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class1 cs = new Class1();
          
            cs.deleteUpData(comboBox2.Text);

            MessageBox.Show("Remove Movie Successfully");
        }
    }
}
