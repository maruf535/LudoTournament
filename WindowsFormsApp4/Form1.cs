
using DatabaseProject;
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

namespace WindowsFormsApp4
{

    public partial class frmRegister : Form
    {
        DBAccess newobj = new DBAccess();
        DataTable dtReg = new DataTable();
        public frmRegister()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        DBAccess con = new DBAccess();
        private void button1_Click(object sender, EventArgs e)
        {

            string variables = "dRid,dRname,dRintake,dRsection,dRpassword"; /*Database Column Name*/
            string values = "'" + lgIdInp.Text + "','" + lgNameInp.Text + "','" + lgIntakeInp.Text + "','" + lgSectionInp.Text + "','" + lgPasswordInp.Text + "'"; //TextBox

            con.dataSend("INSERT INTO Info(" + variables + ")  values ( " + values + " )");


            MessageBox.Show("Record Saved Successfully");
            ClearData();
            LoadData();

        }
        private void ClearData()
        {
            lgNameInp.Clear();
            lgIdInp.Clear();
            lgIntakeInp.Clear();
            lgSectionInp.Clear();
            lgPasswordInp.Clear();

        }
        private void LoadData()
        {
            con.dataGet("Select * from [Info]");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["dgSL"].Value = n + 1;
                dataGridView1.Rows[n].Cells["dgStdId"].Value = row["dRid"].ToString();
                dataGridView1.Rows[n].Cells["dgName"].Value = row["dRname"].ToString();
                dataGridView1.Rows[n].Cells["dgIntake"].Value = row["dRintake"].ToString();
                dataGridView1.Rows[n].Cells["dgSection"].Value = row["dRsection"].ToString();
                dataGridView1.Rows[n].Cells["dgPassword"].Value = row["dRsection"].ToString();

            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form2 login = new Form2();
            login.Show();
            this.Hide();
        }
        private void frmRegister_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lgIdInp.Text = dataGridView1.SelectedRows[0].Cells["dgStdId"].Value.ToString();
            lgNameInp.Text = dataGridView1.SelectedRows[0].Cells["dgName"].Value.ToString();
            lgIntakeInp.Text = dataGridView1.SelectedRows[0].Cells["dgIntake"].Value.ToString();
            lgSectionInp.Text = dataGridView1.SelectedRows[0].Cells["dgSection"].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Update", "Update", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                con.dataSend("UPDATE Info SET dRid ='" + lgIdInp.Text + "', dRname ='" + lgNameInp.Text + "', dRintake ='" + lgIntakeInp.Text + "',dRsection='" + lgSectionInp.Text + "',dRpassword='" + lgPasswordInp.Text + "' where dRid='" + lgIdInp.Text + "'");
                MessageBox.Show("Update Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Delete", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                con.dataSend("Delete from Info where dRid='" + lgIdInp.Text + "'");
                MessageBox.Show("Delete Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();

            }
        }
    }
}