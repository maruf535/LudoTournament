using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using processHelper;

namespace WindowsFormsApp4
{
    public class gameFunctions
    {
        //properties starts
        public bool injector = true;
        public int rank = 1;
        public Panel theBoard = new Panel();
        Random rnd = new Random();//random number generate korar object
        public Panel gameRankPage = new Panel();
        public playersObj[] playersArray = new playersObj[5];
        public PictureBox[] playerRollBtns = new PictureBox[5];//array of roll buttins of 4 players,[1]=red,[2]=green,[3]=yellow,[4]=blue
        public PictureBox[] diceBoxes = new PictureBox[7];//array of diceBox objects
        public int[] diceBoxVals = new int[7];//contains the values of six dice boxes' values
        public int selectedDice = -1;//jei diceBox select korbe tar number
        public int diceNumber = 1;//jei dice box currently khali ache result boshanor jonno
        public int playerTurn = 1; //kon plater er turn ekhon
        public bool playerMove = false;
        public int shot=0;//joto shot ashe roll korar por
        public processData prData = new processData();
        public MainPage backPage;
        //properties end



        public void initPlayers()
        {
            initPlayerArray();
            prData.dbs.dataGet("select * from tournament_players where T_id = '" + prData.tourID + "'");
            DataTable dt = new DataTable();
            prData.dbs.sda.Fill(dt);


            foreach (DataRow row in dt.Rows)
            {
                int index = int.Parse(row["P_color"].ToString());
                int tRank = int.Parse(row["P_tour_rank"].ToString());
                int playerId = int.Parse(row["P_id"].ToString());

                playersArray[index].playerId = playerId;
                playersArray[index].playerColor = index;
                if (tRank < prData.tourID)
                {
                    playersArray[index].playerRank = 0;
                }
                else
                {
                    playersArray[index].playerRank = tRank;
                }

                DataTable playerTable = new DataTable();
                prData.dbs.dataGet("select * from players where P_id = " + playerId);
                prData.dbs.sda.Fill(playerTable);

                foreach(DataRow plyr in playerTable.Rows)
                {
                    playersArray[index].playerName = plyr["P_name"].ToString();
                    playersArray[index].playerGender = int.Parse(plyr["P_gender"].ToString());
                }
            }
        }

        public System.Drawing.Bitmap getPotrait(int g)
        {
            //potrait image set korar jonno ei function use hobe
            if (g == 1)
            {
                return global::WindowsFormsApp4.Properties.Resources.malePotrait;
            }
            else
                return global::WindowsFormsApp4.Properties.Resources.femalePotrait;
        }

        public System.Drawing.Bitmap getDiceImage(int d)
        {
            //dice box e nirdisto shot er jonno nirdishto image set korte ei function use hobe
            switch(d)
            {
                case 0:
                    return global::WindowsFormsApp4.Properties.Resources.dice0;
                case 1:
                    return global::WindowsFormsApp4.Properties.Resources.dice1;
                case 2:
                    return global::WindowsFormsApp4.Properties.Resources.dice2;
                case 3:
                    return global::WindowsFormsApp4.Properties.Resources.dice3;
                case 4:
                    return global::WindowsFormsApp4.Properties.Resources.dice4;
                case 5:
                    return global::WindowsFormsApp4.Properties.Resources.dice5;
                case 6:
                    return global::WindowsFormsApp4.Properties.Resources.dice6;
                default:
                    return global::WindowsFormsApp4.Properties.Resources.diceRoll;//dice with question mark
            }
        }

        public void showPlayerRollBtn()
        {
            for(int i = 1; i < 5; i++)//shob player er roll button hide kore dibe
            {
                playerRollBtns[i].Hide();
            }
            playerRollBtns[playerTurn].Show();//shudhu jei player er ekhon turn tar ta show korbe
            playerRollBtns[playerTurn].Image = getDiceImage(0);
        }

        public bool atleastOneTokenAtHome()
        {
            for(int i = 1; i <= 4; i++)
            {
                if (playersArray[playerTurn].PlayerTokens[i].tokenState == 0)
                    return true;
            }
            return false;
        }

        public async void rollDice()
        {
            if (playerMove)
                return;
            shot = rnd.Next(1, 7);//generates a number between [1,7), that is 1 is included but 7 is not
            
            if(atleastOneTokenAtHome() && injector)
            {
                shot = 6;
                injector = false;
            }
            
            playerRollBtns[playerTurn].Image = getDiceImage(7);
            await System.Threading.Tasks.Task.Delay(300);
            playerRollBtns[playerTurn].Image = getDiceImage(shot);
            setDice();//sets the result to current dice box 
            selectDiceBox(diceNumber - 1);
            playerMove = shot < 6;

            if (checkForThreeSixes())
            {
                await System.Threading.Tasks.Task.Delay(400);
                changeTurn();
            }
            if (!playerMove)
            {
                playerRollBtns[playerTurn].Image = getDiceImage(0);
            }

            if (diceNumber == 2)
            {
                if (!checkAllPossibleTokenMove())
                {
                    await System.Threading.Tasks.Task.Delay(400);
                    changeTurn();
                }
            }

        }

        private bool checkForThreeSixes()
        {
            if (selectedDice > 2)
            {
                if (diceBoxVals[selectedDice] == 6 && diceBoxVals[selectedDice - 2] == 6 && diceBoxVals[selectedDice - 2] == 6)
                    return true;
            }

            return false;
        }

        private bool checkAllPossibleTokenMove()
        {
            bool possible = false;

            for(int i = 1; i <= 4; i++)
            {
                possible = checkIfPossible(i);
                if (possible)
                    break;
            }

            return possible;
        }

        public void setDice()
        {
            if (diceNumber == 7)
                return;
            diceBoxVals[diceNumber] = shot;//keeping the value of the diceBox
            diceBoxes[diceNumber].Show();//joto number dice ekhon free ache, shetake show korabe
            diceBoxes[diceNumber].Image = getDiceImage(shot);//joto shot, oi shot er image set kore dicchi
            diceNumber++;//next dice k point koracchi, incase jodi oi player er aro turn thake
        }

        public void hideAllDiceBoxes()
        {
            //shob gula dice box clear korchi turn change er shomoy, but pore r eta lagbe na, tokhon jei dice er value e use hoye jabe sheta remove hoye jabe
            for(int i = 1; i <= 6; i++)
            {
                diceBoxes[i].Hide();
                diceBoxVals[i] = 0;
            }
        }

        public void selectDiceBox(int num)
        {
            unSelectAllDiceBox();
            selectedDice = num;
            diceBoxes[num].BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        public void unSelectAllDiceBox()
        {
            for(int i=1;i<=6;i++)
            {
                diceBoxes[i].BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
        }

        public void changeTurn()
        {
            injector = true;
            //player turn change korar shomoy ja ja clear or change kora lage ta ekhane hobe
            if (playerTurn < 4)
                playerTurn++;
            else
                playerTurn = 1;
            if (playersArray[playerTurn].playerRank != 0)
            {
                changeTurn();
                return;
            }
            showPlayerRollBtn();
            diceNumber = 1;
            selectedDice = -1;
            playerMove = false;
            hideAllDiceBoxes();
            for(int i = 1; i < 5; i++)
            {
                playersArray[playerTurn].PlayerTokens[i].tokenPicture.BringToFront();
            }
        }

        public void initPlayerArray()
        {
            for (int i = 1; i < 5; i++)
            {
                playersArray[i] = new playersObj();
                playersArray[i].initTokenArray();
            }
        }

        public bool checkIfPossible(int tokenNum)
        {
            //check korar jonno alada function korte hobe
            bool diceUsed = false;
            tokensObj tokenNow = playersArray[playerTurn].PlayerTokens[tokenNum];
            if (tokenNow.tokenState == 0 && diceBoxVals[selectedDice] == 6)
            {
                diceUsed = true;
            }
            else if (tokenNow.tokenState == 1)
            {
                diceUsed = tokenNow.checkMoveFromCurrentPos(diceBoxVals[selectedDice]);
                //ekhane position change hoye jacche
            }
            return diceUsed;
        }

        public void moveToken(int tokenNum)
        {
            bool diceUsed = false;
            //MessageBox.Show(playerNum.ToString()+", "+ tokenNum.ToString());
            tokensObj tokenNow = playersArray[playerTurn].PlayerTokens[tokenNum];
            
            if (tokenNow.tokenState == 0)
            {
                if (diceBoxVals[selectedDice] == 6)
                {
                    tokenNow.StartingPosition();
                    //ekhane position change hoye jacche
                    diceUsed = true;
                }
            }
            else if (tokenNow.tokenState == 1)
            {
                diceUsed = tokenNow.moveFromCurrentPos(diceBoxVals[selectedDice]);
                //ekhane position change hoye jacche
            }
            
            if (diceUsed)
            {
                multTokInThisPos(tokenNum);
                tokenNow.moveIt(2);
                if (tokenNow.tokenState == 2)
                {
                    playersArray[playerTurn].tokensInGoalCnt++;
                    if (playersArray[playerTurn].tokensInGoalCnt == 4)
                    {
                        playersArray[playerTurn].showRank(rank);
                        rank++;
                        diceNumber = 2;
                    }
                    else
                    {
                        playerMove = false;
                        MessageBox.Show("Roll the dice again !!");
                        playerRollBtns[playerTurn].Image = getDiceImage(0);
                    }

                    if (rank == prData.tourState)
                    {
                        gameOver();
                    }
                }
                removeDice();
                if (diceNumber == 1 && playerMove==true)
                    changeTurn();
            }
            else
            {
                MessageBox.Show("Invalid Move");
            }
        }

        public void multTokInThisPos(int tokenNum)
        {
            bool homePos = isHome(tokenNum);
            tokensObj tokenThis = playersArray[playerTurn].PlayerTokens[tokenNum];
            List<tokensObj> similars = new List<tokensObj>();
            int counter = 0;
            for(int i = 1; i < 5; i++)
            {
                if(i!=playerTurn && !homePos)
                {
                    similars.Clear();
                    counter = 0;
                    for(int j = 1; j < 5; j++)
                    {
                        if (tokenThis.positionsX[2] == playersArray[i].PlayerTokens[j].positionsX[2])
                        {
                            if(tokenThis.positionsY[2] == playersArray[i].PlayerTokens[j].positionsY[2])
                            {
                                counter++;
                                similars.Add(playersArray[i].PlayerTokens[j]);
                            }
                        }
                    }
                    if (counter == 1)
                    {
                        //ektar beshi same color er token okhane thakle oder eliminate korte parbe na
                        //different jekono color er ekta token thaklei take eliminate kore dibe
                        similars[0].gotoHome();
                        playerMove = false;
                        MessageBox.Show("Roll The dice Again !!");
                        playerRollBtns[playerTurn].Image = getDiceImage(0);
                    }
                }
            }

            counter = 0;
            similars.Clear();

            for(int i = 1; i < 5; i++)
            {
                for(int j = 1; j < 5; j++)
                {
                    if (tokenThis.positionsX[2] == playersArray[i].PlayerTokens[j].positionsX[2])
                    {
                        if(tokenThis.positionsY[2] == playersArray[i].PlayerTokens[j].positionsY[2])
                        {
                            counter++;
                            similars.Add(playersArray[i].PlayerTokens[j]);
                        }
                    }
                }
            }

            if (counter > 1)
            {
                alignInSamePos(similars,counter);
            }
        }

        public bool isHome(int tokenNum)
        {

            tokensObj tokenThis, tokenTemp;
            tokenThis = playersArray[playerTurn].PlayerTokens[tokenNum];

            for(int i = 1; i < 5; i++)
            {
                tokenTemp = playersArray[i].PlayerTokens[1];

                if (tokenTemp.positionsX[1] == tokenThis.positionsX[2] && tokenThis.positionsY[2] == tokenTemp.positionsY[1])
                    return true;
            }

            return false; 
        }

        public void alignInSamePos(List<tokensObj> similars, int size)
        {
            int limit = size / 2;
            int shiftBy = limit * 8;

            for(int i=0; i<limit; i++)
            {
                similars[i].shiftX(shiftBy);
                similars[size-1-i].shiftX((-1)*shiftBy);
                shiftBy -= 4;
            }
            if (limit * 2 != size)
                similars[limit + 1].tokenPicture.BringToFront();
        }

        public void removeDice()
        {
            for(int i = selectedDice; i < diceNumber-1; i++)
            {
                diceBoxVals[i] = diceBoxVals[i + 1];
                diceBoxes[i].Image = getDiceImage(diceBoxVals[i]);
            }

            diceNumber--;
            diceBoxes[diceNumber].Hide();
            if (diceNumber > 1)
            {
                selectDiceBox(diceNumber - 1);
            }
        }

        public void gameOver()
        {
            theBoard.Show();
            gameRankPage.Show();

            for(int i = 1; i <= 4; i++)
            {
                gameRankPage.Controls[i].Hide();
            }

            for(int i=1; i <= prData.tourState; i++)
            {
                for(int j = 1; j <= 4; j++)
                {
                    if (playersArray[j].playerRank == i)
                    {
                        gameRankPage.Controls[i].Text = playersArray[j].playerName;
                        gameRankPage.Controls[i].Show();
                        prData.dbs.dataSend("update tournament_players set p_tour_rank = " + playersArray[j].playerRank);
                        prData.dbs.dataSend("insert into game_results values("+prData.tourID+", "+playersArray[j].playerId+", "+prData.tourState+", "+playersArray[j].playerRank+", 0)");
                        break;
                    }
                }
            }

        }
    }
}
