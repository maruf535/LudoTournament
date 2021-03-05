using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public class playersObj
    {
        public tokensObj[] PlayerTokens = new tokensObj[5];//4 ta token er jonno 4 ta array
        public int playerId;//from database
        public int playerName;//from database
        public int playerColor;//1 for red, 2 for green, 3 for yellow, 4 for blue
        public int playerRank=0;//it will be 0 zero initially, jodi tar game complete hoye jay, take rank die deoa hobe
        //rank 0 thaklei she turn pabe, nahole tar turn skip hoye jabe

        //form objects
        public PictureBox playerPotrait;
        public Label playerNameLabel;

        public void initTokenArray()
        {
            for(int i = 1; i < 5; i++)
            {
                PlayerTokens[i] = new tokensObj();
            }
        }
    }
}
