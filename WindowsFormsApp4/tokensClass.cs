using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    class tokensObj
    {
        public int startingX;//home theke jekhan theke start hobe tar x-axis point
        public int startingY;//home theke jekhan theke start hobe tar y-axis point
        public int endingX;//goal e gele jekhane thakbe shei point er tar x-axis point
        public int endingY;//home theke jekhan theke start hobe tar y-axis point
        public int currentX;//current position er x-axis er point
        public int currentY;//current position er y-axis er point
        public int tokenState;//token home e thakle 0, running mode e thakle 1, goal er kache thakle 2, goal e chole gele 3
        public int[,] movesX = new int[16,16];//kono position e thakle okhan theke kothay x-axis borabor kothay jete parbe
        public int[,] movesY = new int[16,16];//kono position e thakle okhan theke kothay y-axis borabor kothay jete parbe

        //form objects
        public PictureBox tokenPicture = new PictureBox();
    }
}
