using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using processHelper;
using DatabaseProject;

namespace WindowsFormsApp4
{
    public partial class MainPage : Form
    {
        processData prData = new processData();
        Panel goBack;
        public MainPage()
        {
            InitializeComponent();

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            hideAll();
            hideTopButtons();
            welcPanel.Show();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            hideAll();
            showHome();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            hideAll();
            goBack.Show();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            HomePanel.Show();
            welcPanel.Hide();
        }

        private void newTourBtn_Click(object sender, EventArgs e)
        {
            goBack = HomePanel;
            hideAll();
            tourNamePanel.Show();
            showTopButtons();
            prData.tourType = 1;
        }

        private void tourCreateBtn_Click(object sender, EventArgs e)
        {
            //take the tounament name input
            //check if this name already exists
            //if does, then promt an alert
            //and take another input
            //otherwise insert it into database
            //and move to the next panel, that is first player info

            string tourName = tourNameInp.Text;
            //first check korte hobe ei naam e kono tournament already ache kina
            //thakle abr input dite bolte hobe, insert hobe na, retrun kore dibo function
            //then eta ke insert  kore dibo
            prData.dbs.dataSend("insert into tournament values('" + tourName + "' , 3)");
            prData.dbs.dataGet("select * from tournament where T_name = '" + tourName + "'");
            DataTable dt = new DataTable();
            prData.dbs.sda.Fill(dt);

            foreach (DataRow row in dt.Rows)//jehetu username unique to ektai row pabe, no tension
            {
                prData.tourID = int.Parse(row["T_id"].ToString());
            }

            //MessageBox.Show(prData.tourID.ToString()); //check kortesi
            prData.tourState = 4;//jehetu new tournament, to quaterfinal state e thakbe

            prData.playerSerial = 1;
            //ekhon prData playerchoice e pass kore dibo
            hideAll();
            goBack = tourNamePanel;
            showPlayerChoice();

        }
        public void showPlayerChoice()
        {
            //jemon ta ekhane korsi
            PlayerTitle.Text = "PLAYER " + prData.playerSerial;//erokom oh accha accha ami kortesi tumi dekho
            PlayerChoicePanel.Show();

        }


        private void lgnChcBtn_Click(object sender, EventArgs e)
        {
            hideAll();
            goBack = PlayerChoicePanel;
            //ekhon oi function ta ekhan theke  call kore dibo
            playerLoginPanelShow();
        }
        public void playerLoginPanelShow()
        {
            //ekhane theke player login panel ta show hocche
            //tai amra ekhanei oi title ta change korbo
            //kintu jehetu ei player login panel amra aro koek jayga theke show korte pari
            //tai etake playerLoginPanelShow naame ekta function e rekhe dibo
            //shudhu playerCnt disilam, sathe"Player " eta add kore dite hobe shurute
            lgnPageTitle.Text ="PLAYER " + prData.playerSerial.ToString();//text ta jehetu string, tai etake .toString() die dite hobe
            PlayerOneLoginPanel.Show();
        }

        private void regChcBtn_Click(object sender, EventArgs e)
        {
            hideAll();
            goBack = PlayerOneLoginPanel;
            playerRegisterPanelShow();
        }

        public void playerRegisterPanelShow()
        {
            regPageTitle.Text = "PLAYER " + prData.playerSerial.ToString();
            PlayerOneRegisterPanel.Show();
        }
        private void ongTourBtn_Click(object sender, EventArgs e)
        {
            hideAll();
            goBack = HomePanel;
            OngoingTournamentPanel.Show();
            showTopButtons();
        }

        private void playerRegBtn_Click(object sender, EventArgs e)
        {
            //data entry korte hbe
            string userName = regUserName.Text;
            string pass = regPassword.Text;
            string gender = "";

            if (regMale.Checked)
                gender = "1";
            else if (regFemale.Checked)
                gender = "2";

            if (pass != regRePassword.Text)
            {
                MessageBox.Show("passwords don't match !!");
                return;
            }

            if(getIdFromTable("players", userName,"P_name","P_id")!=-1)
            {
                MessageBox.Show("This user name is taken, Enter a new one !");
                return;
            }

            prData.dbs.dataSend("insert into players values('" + userName + "', '" + gender + "', '" + pass + "', " + 0 + ")");

            int playerId = getIdFromTable("players", userName, "P_name","P_id");
            goToNextPlayer();
        }

       public int getIdFromTable(string TableName, string toMatch, string colName, string idCol)
        {

            prData.dbs.dataGet("select * from " + TableName + " where " + colName + " = '" + toMatch + "'");
            DataTable dt = new DataTable();
            prData.dbs.sda.Fill(dt);

            int id = -1;
            foreach(DataRow row in dt.Rows)
            {
                id =int.Parse(row[idCol].ToString());
            }

            return id;

        }

        private void plyrLgnBtn_Click(object sender, EventArgs e)
        {
            //data entry korte hbe
            goToNextPlayer();
        }

        private void FixurePanel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button8_Click(object sender, EventArgs e)
        {
            hideAll();
            goBack = OngoingTournamentPanel;
            FixurePanel.Show();
        }

        private void ongTourNextBtn_Click(object sender, EventArgs e)
        {

        }

        public void goToNextPlayer()
        {

            //MessageBox.Show("All ok");
            if (prData.playerSerial < prData.tourState)
            {
                hideAll();
                prData.playerSerial++;
                //PlayerChoicePanel.Show();
                if (prData.tourType == 1)
                    showPlayerChoice();
                else if (prData.tourType == 2)
                    playerLoginPanelShow();
            }
            else
            {
                if(prData.tourType == 1)
                {
                    game quaterFinal = new game();
                    quaterFinal.gmf.prdata = prData;
                    this.Hide();
                    quaterFinal.Show();
                }
            }
        }
        public void hideAll()
        {
            welcPanel.Hide();
            HomePanel.Hide();
            tourNamePanel.Hide();
            PlayerChoicePanel.Hide();
            PlayerOneLoginPanel.Hide();
            PlayerOneRegisterPanel.Hide();
            ChooseColourPanel.Hide();
            OngoingTournamentPanel.Hide();
            DecisionPagePanel.Hide();
            FixurePanel.Hide();
        }
        public void hideTopButtons()
        {
            backBtn.Hide();
            homeBtn.Hide();
        }
        public void showTopButtons()
        {
            backBtn.Show();
            homeBtn.Show();
        }
        public void showHome()
        {
            hideTopButtons();
            HomePanel.Show();
        }
    }
}
