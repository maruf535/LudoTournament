using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colourChoicePage cChoicelogin = new colourChoicePage();
            cChoicelogin.Show();
            this.Hide();
        }

        private void playerLgnBtn_Click(object sender, EventArgs e)
        {
            //data entry korte hbe
            //if (playerCnt < tourState)
            //{
            //    playerCnt++;
            //    showPlayerChoice();
            //}
            //eti ekhane lekhso kan mia??
            //    ekhane copy kre rakhchilam bt pore delete krini
            //    to comment kore dilei to ho
            //    onk pera niye nicilam to tai kheyal nai comment er kotha
            //    accha chill
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
