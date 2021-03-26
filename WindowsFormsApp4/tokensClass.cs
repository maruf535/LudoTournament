using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public class tokensObj
    {
        //public int startingX;//home theke jekhan theke start hobe tar x-axis point
        //public int startingY;//home theke jekhan theke start hobe tar y-axis point
        //public int endingX;//goal e gele jekhane thakbe shei point er tar x-axis point
        //public int endingY;//home theke jekhan theke start hobe tar y-axis point
        //public int currentX;//current position er x-axis er point
        //public int currentY;//current position er y-axis er point
        //ei shob gular jonno just duita array rakhbo
        public int[] positionsX = new int[5];
        public int[] positionsY = new int[5];
        public int tokenState=0;//token home e thakle 0, running mode e thakle 1, goal e chole gele 2
        public int[,] movesX = new int[15,15];//kono position e thakle okhan theke kothay x-axis borabor kothay jete parbe
        public int[,] movesY = new int[15,15];//kono position e thakle okhan theke kothay y-axis borabor kothay jete parbe
        public int color;
        //form objects
        public PictureBox tokenPicture = new PictureBox();

        //methods
        public void setAll(PictureBox token, int color)
        {
            tokenPicture = token;
            tokenState = 0;
            positionsX[0] = token.Location.X;
            positionsY[0] = token.Location.Y;
            switch (color)
            {
                case 1:
                    setRedToken();
                    break;
                case 2:
                    setGreenToken();
                    break;
                case 3:
                    setYellowToken();
                    break;
                default:
                    setBlueToken();
                    break;
            }
        }

        private void setRedToken()
        {
            color = 1;
            positionsX[1] = 1;
            positionsY[1] = 6;
            movesX= new int[,]{ { 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0 },
                                { 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0,-1,-1,-1,-1,-1, 0, 0, 0,-1,-1,-1,-1,-1,-1 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },   
                                { 0, 0, 0, 0, 0, 0, 0,-1,-1, 0, 0, 0, 0, 0, 0 }};

            movesY = new int[,]{{ 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0,-1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                                {-1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 0, 0, 0, 0, 0, 0, 0 }};
        }
        private void setGreenToken()
        {
            color = 2;
            positionsX[1] = 8;
            positionsY[1] = 1;
            movesX = new int[,]{{ 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0,-1,-1,-1,-1,-1, 0, 0, 0,-1,-1,-1,-1,-1,-1 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0,-1,-1, 0, 0, 0, 0, 0, 0 }};

            movesY = new int[,]{{ 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 1, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 1, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 1, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 1, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 1, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0,-1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                                {-1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                                {-1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 0, 0, 0, 0, 0, 0, 0 }};
        }
        private void setYellowToken()
        {
            color = 3;
            positionsX[1] = 13;
            positionsY[1] = 8;
            movesX = new int[,]{{ 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0,-1,-1,-1,-1,-1,-1 },
                                { 0,-1,-1,-1,-1,-1, 0, 0, 0,-1,-1,-1,-1,-1, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0,-1,-1, 0, 0, 0, 0, 0, 0 }};

            movesY = new int[,]{{ 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0,-1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                                {-1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                {-1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 0, 0, 0, 0, 0, 0, 0 }};
        }
        private void setBlueToken()
        {
            color = 4;
            positionsX[1] = 6;
            positionsY[1] = 13;
            movesX = new int[,]{{ 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0,-1,-1,-1,-1,-1, 0, 0, 0,-1,-1,-1,-1,-1,-1 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0,-1, 0, 0, 0, 0, 0, 0 }};

            movesY = new int[,]{{ 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0,-1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                                {-1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                                {-1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1,-1, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1,-1, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1,-1, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1,-1, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0,-1,-1, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0,-1, 0, 0, 0, 0, 0, 0, 0 }};
        }

        public int getXpoint(int x)
        {
            int refineFactor = 8 + (x / 3);
            return x * 33 + refineFactor;
        }

        public int getYpoint(int y)
        {
            int refineFactor = 3 + (y / 3);
            return y * 33 + refineFactor;
        }

        public void moveIt(int index)
        {
            tokenPicture.Location = new System.Drawing.Point(getXpoint(positionsX[index]), getYpoint(positionsY[index]));
        }

        public void StartingPosition()
        {
            tokenState = 1;
            positionsX[2] = positionsX[1];
            positionsY[2] = positionsY[1];
        }

        public bool moveFromCurrentPos(int diceVal)
        {
            bool possible = false;
            int x = positionsX[2];
            int y = positionsY[2];
            while (diceVal>0)
            {
                int plusX = movesX[y, x];
                int plusY = movesY[y, x];


                if (plusX == 0 && plusY == 0)
                    break;

                x += plusX;
                y += plusY;
                diceVal--;
            }

            if (diceVal == 0)
            {
                possible = true;
                positionsX[2] = x;
                positionsY[2] = y;

                if(movesX[y,x]==0 && movesY[y, x] == 0)
                {
                    tokenState = 2;
                }
            }

            return possible;
        }
        public bool checkMoveFromCurrentPos(int diceVal)
        {
            bool possible = false;
            int x = positionsX[2];
            int y = positionsY[2];
            while (diceVal>0)
            {
                int plusX = movesX[y, x];
                int plusY = movesY[y, x];


                if (plusX == 0 && plusY == 0)
                    break;

                x += plusX;
                y += plusY;
                diceVal--;
            }

            if (diceVal == 0)
            {
                possible = true;
            }

            return possible;
        }

        public void gotoHome()
        {
            tokenState = 0;
            positionsX[2] = 0;
            positionsY[2] = 0;
            tokenPicture.Location = new System.Drawing.Point(positionsX[0], positionsY[0]);
        }

        public void shiftX(int shiftBy)
        {
            int nowX = tokenPicture.Location.X;
            int nowY = tokenPicture.Location.Y;
            //tokenPicture.Scale(1.5);
            nowX = shiftBy;
            tokenPicture.Location = new System.Drawing.Point(nowX, nowY);
        }
    }
}
