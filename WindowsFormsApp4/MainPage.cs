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
            //ChooseColourPanel.Show();
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
            int ifUnique = getIdFromTable("tournament", tourName, "T_Name", "T_id");
            //thakle abr input dite bolte hobe, insert hobe na, retrun kore dibo function
            if (ifUnique != -1)
            {
                MessageBox.Show("Enter a unique tournament name...");
                return;
            }
            //then eta ke insert  kore dibo
            prData.dbs.dataSend("insert into tournament values('" + tourName + "' , 4)");

            //then etar id ta nibo
            prData.tourID = getIdFromTable("tournament", tourName, "T_Name", "T_id");

            //MessageBox.Show(prData.tourID.ToString()); //check kortesi
            prData.tourState = 4;//jehetu new tournament, to quaterfinal state e thakbe

            prData.playerSerial = 1;

            tourNameInp.Text = "";
            hideAll();
            goBack = tourNamePanel;
            showPlayerChoice();

        }
        public void showPlayerChoice()
        {
            backBtn.Hide();
            //jemon ta ekhane korsi
            PlayerTitle.Text = "PLAYER " + prData.playerSerial;//erokom oh accha accha ami kortesi tumi dekho
            PlayerChoicePanel.Show();

        }


        private void lgnChcBtn_Click(object sender, EventArgs e)
        {
            backBtn.Show();
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
            lgnPageTitle.Text = "PLAYER " + prData.playerSerial.ToString();//text ta jehetu string, tai etake .toString() die dite hobe
            if (prData.tourType == 2)
            {
                lgnPageTitle.Text = prData.tempTable.Rows[prData.playerSerial-1]["P_name"].ToString();
                lgnUserName.Text = prData.tempTable.Rows[prData.playerSerial-1]["P_name"].ToString();
                lgnUserName.Hide();
                lgnUserNameLebel.Hide();
            }
            else
            {
                lgnUserName.Show();
            }
            PlayerOneLoginPanel.Show();
        }

        private void regChcBtn_Click(object sender, EventArgs e)
        {
            backBtn.Show();
            hideAll();
            goBack = PlayerChoicePanel;
            playerRegisterPanelShow();
        }

        public void playerRegisterPanelShow()
        {
            regPageTitle.Text = "PLAYER " + prData.playerSerial.ToString();
            PlayerOneRegisterPanel.Show();
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

            if (getIdFromTable("players", userName, "P_name", "P_id") != -1)
            {
                MessageBox.Show("This user name is taken, Enter a new one !");
                return;
            }

            prData.dbs.dataSend("insert into players values('" + userName + "', '" + gender + "', '" + pass + "', " + 0 + ")");

            clearRegisterPage();

            int playerId = getIdFromTable("players", userName, "P_name", "P_id");
            prData.playersId[prData.playerSerial] = playerId;
            prData.playerNames[prData.playerSerial] = userName;
            goToNextPlayer();
        }
        public void clearRegisterPage()
        {
            regUserName.Text = "";
            regPassword.Text = "";
            regRePassword.Text = "";
            regMale.Checked = false;
            regFemale.Checked = false;
        }

        public int getIdFromTable(string TableName, string toMatch, string colName, string idCol)
        {

            prData.dbs.dataGet("select * from " + TableName + " where " + colName + " = '" + toMatch + "'");
            DataTable dt = new DataTable();
            prData.dbs.sda.Fill(dt);

            int id = -1;
            foreach (DataRow row in dt.Rows)
            {
                id = int.Parse(row[idCol].ToString());
            }

            return id;

        }

        private void plyrLgnBtn_Click(object sender, EventArgs e)
        {
            //first e userName r password nie nei
            string userName = lgnUserName.Text;
            string pass = lgnPassword.Text;

            //aage check korbo ei username ache kina
            int id = getIdFromTable("players", userName, "P_name", "P_id");

            if (id == -1)
            {
                MessageBox.Show("This username does not exist...");
                return;
            }

            prData.dbs.dataGet("select * from players where P_name = '" + userName + "' and P_password = '" + pass + "'");
            DataTable dt = new DataTable();
            prData.dbs.sda.Fill(dt);

            id = -1;
            foreach (DataRow row in dt.Rows)
            {
                id = int.Parse(row["P_id"].ToString());
            }

            if (id == -1)
            {
                MessageBox.Show("Wrong password...");
                return;
            }


            prData.playersId[prData.playerSerial] = id;
            prData.playerNames[prData.playerSerial] = userName;
            clearLoginPage();
            goToNextPlayer();
        }

        public void clearLoginPage()
        {
            lgnUserName.Text = "";
            lgnPassword.Text = "";
        }

        private void ongTourBtn_Click(object sender, EventArgs e)
        {
            prData.tourType = 2;
            prData.dbs.dataGet("select * from tournament");
            prData.dbs.sda.Fill(prData.ongTourTable);
            prData.ongTourPnum = 1;
            showOngTourListPage(prData.ongTourPnum);
            hideAll();
            goBack = HomePanel;
            OngoingTournamentPanel.Show();
            showTopButtons();
        }

        public void showOngTourListPage(int pageNum)
        {
            hideOngTourList();
            int maxSerial = prData.ongTourTable.Rows.Count;
            int maxPage = maxSerial / 5;
            if (maxSerial % 5 != 0)
                maxPage++;
            if (pageNum > maxPage)
                pageNum = maxPage;
            if (pageNum < 1)
                pageNum = 1;
            int pageF = (pageNum - 1) * 5;
            for (int i = 0; i < 5 && i < (maxSerial - pageF); i++)
            {
                ongTourListPanel.Controls[i].Show();
                string tourName = prData.ongTourTable.Rows[pageF + i]["T_name"].ToString();
                string tourId = prData.ongTourTable.Rows[pageF + i]["T_id"].ToString();
                (ongTourListPanel.Controls[i].Controls[0] as Button).Tag = tourId;
                (ongTourListPanel.Controls[i].Controls[1] as Button).Tag = tourId;
                (ongTourListPanel.Controls[i].Controls[2] as Label).Text = tourName;
            }
            prData.ongTourPnum = pageNum;
        }

        public void hideOngTourList()
        {

            for (int i = 0; i < 5; i++)
            {
                ongTourListPanel.Controls[i].Hide();
            }
        }

        private void ongTourNextBtn_Click(object sender, EventArgs e)
        {
            prData.ongTourPnum++;
            showOngTourListPage(prData.ongTourPnum);

        }

        private void ongTourPrevBtn_Click(object sender, EventArgs e)
        {
            prData.ongTourPnum--;
            showOngTourListPage(prData.ongTourPnum);
        }

        private void enterTournament(object sender, EventArgs e)
        {
            string temp = (sender as Button).Tag.ToString();
            int tourId = int.Parse(temp);
            prData.tourID = tourId;
            prData.dbs.dataGet("select tournament.T_id,T_state,T_name,Players.P_id,P_name,P_tour_rank,P_gender,P_color from tournament, tournament_players, players where tournament.T_id = tournament_players.T_id and tournament_players.P_id = players.P_id and tournament.T_id = " + tourId);
            prData.setTempTable();

            if (prData.tempTable.Rows.Count < 4)
            {
                prData.tourType = 1;
                prData.tourState = 4;//jehetu new tournament, to quaterfinal state e thakbe

                int till = prData.tempTable.Rows.Count;
                int i;
                for(i = 1; i <=till; i++)
                {
                    prData.playersId[i] = int.Parse(prData.tempTable.Rows[i]["T_id"].ToString());
                }
                prData.playerSerial = i;

                hideAll();
                goBack = OngoingTournamentPanel;
                showPlayerChoice();
                return;
            }

            prData.setTourDetails();
            hideAll();
            goBack = OngoingTournamentPanel;
            TourHomeTitle.Text = prData.tempTable.Rows[0]["T_name"].ToString();
            tourResumeBtn.Tag = prData.tempTable.Rows[0]["T_id"];
            tourRestartBtn.Tag = prData.tempTable.Rows[0]["T_id"];
            tournamentHomePanel.Show();
        }

        private void deleteTournament(object sender, EventArgs e)
        {
            string temp = (sender as Button).Tag.ToString();
            int tourId = int.Parse(temp);
            DialogResult dialogResult = MessageBox.Show("Are your sure ?","Delete tournament", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                prData.dbs.dataSend("delete from tournament where T_id = " + tourId);
                prData.dbs.dataSend("delete from tournament_players where T_id = " + tourId);
                prData.dbs.dataSend("delete from game_results where T_id = " + tourId);
                MessageBox.Show("Tournament deleted...");
                prData.ongTourTable.Clear();
                prData.dbs.dataGet("select * from tournament");
                prData.dbs.sda.Fill(prData.ongTourTable);
                prData.ongTourPnum = 1;
                showOngTourListPage(prData.ongTourPnum);

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void tourSearchBtn_Click(object sender, EventArgs e)
        {
            prData.ongTourTable.Clear();
            string tourName = tourSrchInp.Text;
            prData.dbs.dataGet("select * from tournament where T_name like '%" + tourName + "%'");
            prData.dbs.sda.Fill(prData.ongTourTable);
            prData.ongTourPnum = 1;
            showOngTourListPage(prData.ongTourPnum);
        }

        private void tourResumeBtn_Click(object sender, EventArgs e)
        {
            string temp = (sender as Button).Tag.ToString();
            int tourId = int.Parse(temp);
            goBack = tournamentHomePanel;
            loadFixture(tourId);
        }

        public void loadFixture(int tourId)
        {
            hideAll();
            string tourName = "";
            foreach (DataRow row in prData.ongTourTable.Select("T_id = " + tourId))
            {
                tourName = row["T_name"].ToString();
            }
            fixureTitle.Text = tourName.ToString();
            resetTourFixture();
            for (int i = 4; i >= prData.tourState; i--)
            {
                setTourFixture(i);
            }

            if (prData.tourState != 1)
            {
                (FixurePanel.Controls[prData.tourState].Controls[prData.tourState] as Button).Show();
            }
            FixurePanel.Show();
        }

        public void setTourFixture(int state)
        {
            if (state == 4)
            {
                for(int i = 0; i < state; i++)
                {
                    (FixurePanel.Controls[state].Controls[i] as Label).Text = prData.tempTable.Rows[i]["P_name"].ToString();
                    if(state == prData.tourState)
                    {
                        (FixurePanel.Controls[state].Controls[i] as Label).BackColor = System.Drawing.Color.LightGreen;
                    }
                }
            }
            else
            {
                DataTable gameTable =  getGameData(state + 1);

                for(int i=0; i<state; i++)
                {
                    for(int j = 0; j < state + 1; j++)
                    {
                        if (int.Parse(gameTable.Rows[j]["P_rank"].ToString()) == i+1)
                        {
                            (FixurePanel.Controls[state].Controls[i] as Label).Text = gameTable.Rows[j]["P_name"].ToString();
                            if (state == prData.tourState)
                            {
                                (FixurePanel.Controls[state].Controls[i] as Label).BackColor = System.Drawing.Color.LightGreen;
                            }
                        }
                    }
                }
            }
        }

        public DataTable getGameData(int state)
        {
            DataTable dt = new DataTable();
            prData.dbs.dataGet("select players.P_Name,game_results.P_rank from players, game_results where players.P_id = game_results.P_id and game_results.T_id = " + prData.tourID + " and game_results.T_state = " + state);
            prData.dbs.sda.Fill(dt);
            return dt;
        }

        private void goToTheGame(object sender, EventArgs e)
        {
            prData.playerSerial = 1;
            playerLoginPanelShow();
        }
        private void goToGame()
        {
            game theGame = new game();
            theGame.gmf.prData = prData;
            this.Hide();
            theGame.Show();
        }

        public void resetTourFixture()
        {
            int i, j;
            for( i = 1; i <= 4; i++)
            {
                for( j = 0; j < i; j++)
                {
                    (FixurePanel.Controls[i].Controls[j] as Label).Text = "?";
                    (FixurePanel.Controls[i].Controls[j] as Label).BackColor = System.Drawing.Color.Yellow;
                }
                if (i > 1)
                {
                    (FixurePanel.Controls[i].Controls[j] as Button).Visible = false;
                }
            }
        }
        public void goToNextPlayer()
        {
            backBtn.Hide();
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
                if (prData.tourType == 1)
                {
                    //colorChocie page load korte hobe;
                    hideAll();
                    showColorChoicePanel();

                }
                else if (prData.tourType == 2)
                {
                    goToGame();
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
            tournamentHomePanel.Hide();
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

        public void showColorChoicePanel()
        {
            backBtn.Hide();
            int childNum = 4;

            for (int i = 1; i <= 4; i++)
            {
                (ChooseColourPanel.Controls[i + childNum] as Label).Text = prData.playerNames[i];
                prData.playerColors[i] = 0;
            }
            hideAll();
            ChooseColourPanel.Show();
        }

        public void colorChoosed(object sender, EventArgs e)
        {
            string tag = (sender as RadioButton).Tag.ToString();
            int tagInt = int.Parse(tag);

            int color = tagInt % 10;
            int player = tagInt / 10;
            int colorTakenBy = checkIfColorTaken(color);

            if (colorTakenBy != -1)
            {
                removeColorFrom(color, colorTakenBy);
            }
            prData.playerColors[player] = color;
        }

        public int checkIfColorTaken(int color)
        {
            for (int i = 1; i < 5; i++)
            {
                if (prData.playerColors[i] == color)
                    return i;
            }
            return -1;
        }

        public void removeColorFrom(int color, int colorTakenBy)
        {
            (ChooseColourPanel.Controls[colorTakenBy - 1].Controls[color - 1] as RadioButton).Checked = false;

            prData.playerColors[colorTakenBy] = 0;
        }

        private void gameStartBtn_Click(object sender, EventArgs e)
        {
            bool allSelected = true;
            for (int i = 1; i <= 4; i++)
            {
                if (prData.playerColors[i] == 0)
                {
                    allSelected = false;
                    break;
                }
            }

            if (!allSelected)
            {
                MessageBox.Show("Please select color for all players....");
                return;
            }

            assignPlayersToTournament();

            goToGame();
        }

        public void assignPlayersToTournament()
        {
            for (int i = 1; i <= 4; i++)
            {
                prData.dbs.dataSend("insert into tournament_players values(" + prData.tourID + ", " + prData.playersId[i] + ", " + prData.playerColors[i] + ", 0, 0)");
            }
        }

        private void MainPage_SizeChanged(object sender, EventArgs e)
        {
            this.mainPanel.Left = this.Width / 4;
            this.mainPanel.Top = this.Height / 8;
        }

        private void tourRestartBtn_Click(object sender, EventArgs e)
        {
            string temp = (sender as Button).Tag.ToString();
            int tourId = int.Parse(temp);
            DialogResult dialogResult = MessageBox.Show("Are your sure ?", "Reset tournament", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                prData.dbs.dataSend("update tournament_players set P_tour_rank=0 where T_id = " + tourId);
                prData.dbs.dataSend("delete from game_results where T_id = " + tourId);
                MessageBox.Show("Tournament reset complete...");
                prData.tourState = 4;
                goBack = tournamentHomePanel;
                loadFixture(tourId);
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void PlayerOneRegisterPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
