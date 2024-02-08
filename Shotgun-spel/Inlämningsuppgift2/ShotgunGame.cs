using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inlämningsuppgift2.Classes;

namespace Inlämningsuppgift2
{
    public partial class ShotgunGame : Form
    {
        private GameLogic gameLogic;
        private HumanPlayer human;
        private ComputerPlayer computer;

        public ShotgunGame()
        {
            InitializeComponent();
            human = new HumanPlayer();
            computer = new ComputerPlayer();
            gameLogic = new GameLogic(human, computer);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            gameLogic.PlayerReload();
            UpdateUI();
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            gameLogic.PlayerBlock();
            UpdateUI();
        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            gameLogic.PlayerShoot();
            UpdateUI();
        }

        private void btnShotgun_Click(object sender, EventArgs e)
        {
            gameLogic.PlayerUseShotgun();
            UpdateUI();
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to restart?", "Restart game", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                human.ClearAmmo();
                computer.ClearAmmo();
                gameLogic.humanWinCount = 0;
                gameLogic.computerWinCount = 0;
                UpdateUI();
                lblHumanLastAction.Text = "";
                lblComputerLastAction.Text = "";
                lblLastOutcome.Text = "";
                MessageBox.Show("Game restarted");
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Quit Game", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void UpdateUI()
        {
            txtHumanAmmo.Text = human.Ammo.ToString();
            txtHumanWins.Text = gameLogic.humanWinCount.ToString();
            txtComputerAmmo.Text = computer.Ammo.ToString();
            txtComputerWins.Text = gameLogic.computerWinCount.ToString();
            lblHumanLastAction.Text = human.Action.ToString();
            lblComputerLastAction.Text = computer.Action.ToString();
            lblLastOutcome.Text = gameLogic.lastOutcome;
        }
    }
}
