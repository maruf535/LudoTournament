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
    public partial class welcomePage : Form
    {
        public welcomePage()
        {
            InitializeComponent();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            Homepage homePage = new Homepage();
            homePage.Show();
            //jekhane r back ashar dorkar hobe na shetake hide na kore 
            //direct close kore dile bhalo, memory kom use hobe
            //nah first page e close korle jhamela hoitese 
            this.Hide();
        }

        private void welcomePage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
