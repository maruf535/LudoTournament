using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatabaseProject
{
    class DBAccess
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter sda;
        public string pkk;

        public void connection()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-SSEFC8E\SQLEXPRESS;Initial Catalog=Info;Integrated Security=True");
            con.Open();
        }
        public static string connectionDatabase()
        {
            return "Data Source=DESKTOP-SSEFC8E\\SQLEXPRESS;Initial Catalog=Info;Integrated Security=True";

        }

        public void dataSend(string SQL)
        {
            try
            {
                connection();
                cmd = new SqlCommand(SQL, con);
                var flag = cmd.ExecuteNonQuery();
                pkk = "";
            }
            catch (Exception ex)
            {

                pkk = ex.Message;
                MessageBox.Show(pkk);
            }
            con.Close();
        }
        public void dataGet(string SQL)
        {
            try
            {
                connection();
                sda = new SqlDataAdapter(SQL, con);
            }
            catch (Exception)
            {


            }

        }

    }
}
