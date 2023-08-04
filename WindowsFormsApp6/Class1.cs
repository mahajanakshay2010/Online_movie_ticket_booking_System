using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace WindowsFormsApp6
{
    internal class Class1
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Akshay Mahajan\Documents\localDB.mdf;Integrated Security=True;Connect Timeout=300");
        SqlCommand cmd;
        SqlCommandBuilder bld;
        SqlDataAdapter adpt;
        SqlDataReader dr;
        DataTable dt;
        DataTable dt2;
        DataTable dt3;

        public DataTable topMovies()
        {
            String qry = "select MovieName from Movie";
            con.Open();
            adpt = new SqlDataAdapter(qry, con);
            bld = new SqlCommandBuilder(adpt);
            dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }
        public int add_data(String MovieName, int Price)
        {

            String qry = "Insert into Movie values('" + MovieName + "'," + Price + ")";
            con.Open();
            cmd = new SqlCommand(qry, con);
            int no = cmd.ExecuteNonQuery();
            con.Close();
            return no;

        }

        public DataTable upcommingMovies()
        {
            String qry = "select * from UpcommingMovies";
            con.Open();
            adpt = new SqlDataAdapter(qry, con);
            bld = new SqlCommandBuilder(adpt);
            dt2 = new DataTable();
            adpt.Fill(dt2);
            con.Close();
            return dt2;
        }

        public int addUpcommingMovies(String MovieName, DateTime date)
        {
            String qry = "Insert into UpcommingMovies values('" + MovieName + "','" + date + "')";
            con.Open();
            cmd = new SqlCommand(qry, con);
            int no = cmd.ExecuteNonQuery();
            con.Close();
            return no;

        }
       
        public int addBookNow(String MovieName,String name,String contactNo,String seat,DateTime date,int payment)
        {
            
            String qry = "Insert into Details values('" + MovieName + "','" + name + "','" + contactNo + "','" + seat + "','" + date + "','" + payment + "')";

            con.Open();
            cmd = new SqlCommand(qry, con);
            int no = cmd.ExecuteNonQuery();
            con.Close();
            return no;

            


          }
        public  static List<string> binddata()
        {
            List<string> moviename = new List<string>();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Akshay Mahajan\Documents\localDB.mdf;Integrated Security=True;Connect Timeout=30");
           SqlCommand cmd = new SqlCommand("select MovieName from Movie ", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                moviename.Add(dr["MovieName"].ToString());
            }
            con.Close();
            return moviename;
        }
        public static List<string> bindUpdata()
        {
            List<string> moviename1 = new List<string>();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Akshay Mahajan\Documents\localDB.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("select MovieName from UpcommingMovies ", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                moviename1.Add(dr["MovieName"].ToString());
            }
            con.Close();
            return moviename1;
        }

        public void deleteData(String MovieName)
        {
            String qry = "delete from Movie where MovieName = '" + MovieName + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(qry,con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void deleteUpData(String MovieName)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from UpcommingMovies where MovieName = '" + MovieName + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
       /* public void priceShow(String MovieName)
        {
           
            SqlCommand cmd = new SqlCommand("Select * from Movie where MovieName = '" + MovieName + "'", con);
            con.Open();
            SqlDataReader dr;
            if (dr.Read())
            {
                MovieName=
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }*/

    }
}


