using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp4;
using DatabaseProject;

namespace processHelper
{
    //ekta class create korechi processData naam e
    //r namespace hocche processHelper
    //each page e ei namespace add korte hobe
    // r each page e ekta processData nam e object o thakbe;
    //ekhane jei class ta ache, processData,
    //ei class er bhitor kichu info thakbe, ja ek form theke arek form e gele previous form gular data carry korbe
    // and total process ta ekhon kon state e ache egulao carry korbe
    //also, ek form theke arek form e data pass er jonno o eta use kora hobe

    //so this class has to be declared as public too
    public class processData
    {
        //ei data gula transfer hobe form to form
        //shobgula public korte hobe, nahole prottektar jonno alada alada getter setter banate hobe

        public bool newTour;//new tournament khular shomoy eta tru kora thakbe
        public bool ongTour; //ongoing tournament e dhukar shomoy eta tru thakbe
        public int tourType; //1 for new tournament, 2 for ongoing tournament
        public int playerSerial; //koto number player er login/reg info nite hobe ta ekhane thakbe
        public int tourState; //tournament ta ekhon kon state e ache ta ekhane ullekh thakeb
        public int[] playersId = new int[5]; //oi tournament er player der just id ta thakbe ekhane
        public int[] playerColors = new int[5]; //oi tournament er player der just color er number ta thakbe ekhane
        public string[] playerNames = new string[5]; //oi tournament er player der name gula thakbe ekhane
        public int tourID; //tournament er ID
        public DBAccess dbs = new DBAccess();


        }
    }

}
