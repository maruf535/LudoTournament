﻿using System;
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
    public partial class tournamentNamePage : Form
    {
        public Homepage goBack;
        public tournamentNamePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 player1 = new Form5();
            player1.Show();
            this.Hide();
        }

        private void tournamentNamePage_Load(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            goBack.Show();
        }
    }
}
