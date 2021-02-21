using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseProject; //this contains connection with database
using processHelper;//this namespace cintains the process data

namespace WindowsFormsApp4
{
    public partial class tournamentNamePage : Form
    {
        public Homepage goBack;
        public Homepage home = new Homepage();
        public processData prData;// prevous page theke paboi, to new create korar kono dorkar nai, just declare korlam
        public DBAccess dbs = new DBAccess();

        public tournamentNamePage()
        {
            InitializeComponent();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            string tourName = tourNameInp.Text ;
            //first check korte hobe ei naam e kono tournament already ache kina
            //thakle abr input dite bolte hobe, insert hobe na, retrun kore dibo function
            //then eta ke insert  kore dibo
            dbs.dataSend("insert into tournament values('" + tourName + "' , 3)");
            dbs.dataGet("select * from tournament where T_name = '" + tourName + "'");
            DataTable dt = new DataTable();
            dbs.sda.Fill(dt);

            foreach(DataRow row in dt.Rows)//jehetu username unique to ektai row pabe, no tension
            {
                prData.tourID = int.Parse(row["T_id"].ToString());
            }

            //MessageBox.Show(prData.tourID.ToString()); //check kortesi
            prData.tourState = 3;//jehetu new tournament, to quaterfinal state e thakbe

            playerChoice playerChoice = new playerChoice();
            prData.playerSerial = 1;
            //ekhon prData playerchoice e pass kore dibo
            playerChoice.Show();
            this.Hide();
        }

        private void tournamentNamePage_Load(object sender, EventArgs e)
        {
            

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            goBack.Show();
            this.Hide();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            home.Show();
        }
    }
}
