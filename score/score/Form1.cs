using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using MySql.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace score
{
    public partial class Form1 : Form
    {
        double gametimer = 0;
        Stopwatch stopwatch = null;
        Random random = new Random();
        int timeToStart = 0;
        string playername = "";
        Databasehandler databasehandler = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            databasehandler.SetOrCreateNewUsername(tbxPlayername.Text);
            gametimer = 0;
            timeToStart = random.Next(52, 81);
            lblCountdownText.Text = "Press the spacebar when all lights are off.";
            cbxHighscore.Checked = false;
            btnInfo.Enabled = false;
            btnStartGame.Enabled = false;
            lbxHighscore.Enabled = false;
            cbxHighscore.Enabled = false;
            tbxPlayername.Enabled = false;
            tmrCountdown.Enabled = true;

            this.Focus();
            stopwatch = new Stopwatch();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This test is to check how fast you are compaired to F1 drivers. " +
                "When ready you can press the spacebar to start the lights to go on one by one. " +
                "When all lights are all on the will turn black. Press the spacebar as fast as possible when all lights are off to see how fast you were. ", "Game explanation");
        }

        private void tmrCountdown_Tick(object sender, EventArgs e)
        {
            if (gametimer == 10)
            {
                pnlOne.BackColor = Color.Red;
            }
            else if (gametimer == 20)
            {
                pnlTwo.BackColor = Color.Red;
            }
            else if (gametimer == 30)
            {
                pnlThree.BackColor = Color.Red;
            }
            else if (gametimer == 40)
            {
                pnlFour.BackColor = Color.Red;
            }
            else if (gametimer == 50)
            {
                pnlFive.BackColor = Color.Red;
            }
            else if (gametimer == timeToStart)
            {
                foreach (Panel item in this.Controls.OfType<Panel>())
                {
                    item.BackColor = Color.Black;
                }
                stopwatch.Start();
            }
            gametimer++;
        }

        public void CheckAndUpdateTime()
        {
            stopwatch.Stop();

            TimeSpan reactionTime = stopwatch.Elapsed;

            lblCountdownText.Text = "Current time: " + reactionTime.ToString(@"s\.fff");

            databasehandler.AddNewScore(reactionTime, playername);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
            {
                if (gametimer >= timeToStart)
                {
                    CheckAndUpdateTime();
                }
                else
                {
                    lblCountdownText.Text = "You had a false start! Try again.";
                }
                ResetGame();
            }
        }

        public void ResetGame()
        {
            tmrCountdown.Stop();
            btnInfo.Enabled = true;
            btnStartGame.Enabled = true;
            tbxPlayername.Enabled = true;
            cbxHighscore.Enabled = true;
            lbxHighscore.Enabled = true;
            foreach (Panel coloredPanels in this.Controls.OfType<Panel>())
            {
                coloredPanels.BackColor = Color.Black;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = pnlFive.Right + 20;
            btnStartGame.Enabled = false;
            databasehandler = new Databasehandler();
        }

        private void tbxPlayername_TextChanged(object sender, EventArgs e)
        {
            playername = tbxPlayername.Text.TrimStart(' ');

            if (playername != "")
            {
                lblCountdownText.Text = "Press the start button to start the game";

                btnStartGame.Enabled = true;
            } 
            else
            {
                lblCountdownText.Text = "Fill in your player name to start";
                btnStartGame.Enabled = false;
            }
        }

        private void cbxHighscore_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHighscore.Checked)
            {
                databasehandler.ShowHighscore(lbxHighscore);
                this.Width = lbxHighscore.Right + 20;
            }
            else
            {
                this.Width = pnlFive.Right + 20;
            }
        }
    }
}
