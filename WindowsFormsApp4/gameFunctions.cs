using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    class gameFunctions
    {
        public PictureBox[] playerRollBtns = new PictureBox[5];
        public PictureBox[] diceBoxes = new PictureBox[7];
        public int playerTurn = 1;
        public int shot;
        public int diceNumber = 1;
        public System.Drawing.Bitmap getPotrait(int g)
        {
            if (g == 1)
            {
                return global::WindowsFormsApp4.Properties.Resources.malePotrait;
            }
            else
                return global::WindowsFormsApp4.Properties.Resources.femalePotrait;
        }

        public System.Drawing.Bitmap getDiceImage(int d)
        {
            switch(d)
            {
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
                    return global::WindowsFormsApp4.Properties.Resources.dice0;
            }
        }

        public void showPlayerRollBtn()
        {
            for(int i = 1; i < 5; i++)
            {
                playerRollBtns[i].Hide();
            }
            playerRollBtns[playerTurn].Show();
        }

        public void setDice()
        {
            diceBoxes[diceNumber].Show();
            diceBoxes[diceNumber].Image = getDiceImage(shot);
            diceNumber++;
        }

        public void hideAllDiceBoxes()
        {
            for(int i = 1; i <= 6; i++)
            {
                diceBoxes[i].Hide();
            }
        }

        public void changeTurn()
        {
            if (playerTurn < 4)
                playerTurn++;
            else
                playerTurn = 1;
            showPlayerRollBtn();
            diceNumber = 1;
            hideAllDiceBoxes();
        }
    }
}
