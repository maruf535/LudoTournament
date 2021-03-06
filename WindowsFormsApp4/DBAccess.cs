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
    public class DBAccess
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter sda;
        public string pkk;

        public void connection()
        {
            con = new SqlConnection(@"Data Source=localhost;Initial Catalog=Ludo_tounament_database;Integrated Security=True");
            con.Open();
        }
        public static string connectionDatabase()
        {
            return "Data Source=localhost;Initial Catalog=Ludo_tounament_database;Integrated Security=True";

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


//using DatabaseProject;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Data;
//using System.Data.SqlClient;


//namespace Practicewith412
//{

//    public partial class frmRegister : Form
//    {
//        DBAccess newobj = new DBAccess();
//        DataTable dtReg = new DataTable();
//        public frmRegister()
//        {
//            InitializeComponent();
//        }

//        private void label1_Click(object sender, EventArgs e)
//        {

//        }

//        private void label2_Click(object sender, EventArgs e)
//        {

//        }
//        DBAccess con = new DBAccess();
//        private void button1_Click(object sender, EventArgs e)
//        {

//            string variables = "dRid,dRname,dRintake,dRsection,dRpassword"; /*Database Column Name*/
//            string values = "'" + textId.Text + "','" + textName.Text + "','" + textIntake.Text + "','" + textSection.Text + "','" + txtPassword.Text + "'"; //TextBox

//            con.dataSend("INSERT INTO Info(" + variables + ")  values ( " + values + " )");


//            MessageBox.Show("Record Saved Successfully");
//            ClearData();
//            LoadData();

//        }
//        private void ClearData()
//        {
//            textId.Clear();
//            textName.Clear();
//            textIntake.Clear();
//            textSection.Clear();
//            txtPassword.Clear();

//        }
//        private void LoadData()
//        {
//            con.dataGet("Select * from [Info]");
//            DataTable dt = new DataTable();
//            con.sda.Fill(dt);
//            dataGridView1.Rows.Clear();

//            foreach (DataRow row in dt.Rows)
//            {
//                int n = dataGridView1.Rows.Add();
//                dataGridView1.Rows[n].Cells["dgSL"].Value = n + 1;
//                dataGridView1.Rows[n].Cells["dgStdId"].Value = row["dRid"].ToString();
//                dataGridView1.Rows[n].Cells["dgName"].Value = row["dRname"].ToString();
//                dataGridView1.Rows[n].Cells["dgIntake"].Value = row["dRintake"].ToString();
//                dataGridView1.Rows[n].Cells["dgSection"].Value = row["dRsection"].ToString();
//                dataGridView1.Rows[n].Cells["dgPassword"].Value = row["dRsection"].ToString();

//            }
//        }

//        private void button2_Click(object sender, EventArgs e)
//        {
//            Form1 login = new Form1();
//            login.Show();
//            this.Hide();
//        }

//        private void frmRegister_Load(object sender, EventArgs e)
//        {
//            LoadData();
//        }

//        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
//        {
//            textId.Text = dataGridView1.SelectedRows[0].Cells["dgStdId"].Value.ToString();
//            textName.Text = dataGridView1.SelectedRows[0].Cells["dgName"].Value.ToString();
//            textIntake.Text = dataGridView1.SelectedRows[0].Cells["dgIntake"].Value.ToString();
//            textSection.Text = dataGridView1.SelectedRows[0].Cells["dgSection"].Value.ToString();

//        }

//        private void btnUpdate_Click(object sender, EventArgs e)
//        {
//            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Update", "Update", MessageBoxButtons.YesNo);
//            if (dialogResult == DialogResult.Yes)
//            {
//                con.dataSend("UPDATE Info SET dRid ='" + textId.Text + "', dRname ='" + textName.Text + "', dRintake ='" + textIntake.Text + "',dRsection='" + textSection.Text + "',dRpassword='" + txtPassword.Text + "' where dRid='" + textId.Text + "'");
//                MessageBox.Show("Update Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                LoadData();

//            }
//        }

//        private void btnDelete_Click(object sender, EventArgs e)
//        {
//            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Delete", "Delete", MessageBoxButtons.YesNo);
//            if (dialogResult == DialogResult.Yes)
//            {
//                con.dataSend("Delete from Info where dRid='" + textId.Text + "'");
//                MessageBox.Show("Delete Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                LoadData();

//            }
//        }
//    }
//}
