using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Devices;

namespace Inlämningsuppgift2.Classes
{
    public class GameLogic
    {
        private HumanPlayer human;
        private ComputerPlayer computer;
        public int humanWinCount;
        public int computerWinCount;
        public string lastOutcome;
        

        public GameLogic(HumanPlayer human, ComputerPlayer computer)
        {
            this.human = human;
            this.computer = computer;           
        }

        public void PlayerReload()
        {
            human.Action = Player.PlayerAction.Reload;
            computer.SimulateComputerChoice();
            DetermineRoundOutcome();
        }

        public void PlayerShoot() 
        {
            if (human.CanShoot())
            {
                human.Action = Player.PlayerAction.Shoot;
                computer.SimulateComputerChoice();
                DetermineRoundOutcome();
            }
            else
            {
                MessageBox.Show("You dont have any bullets");
            }      
        }

        public void PlayerBlock()
        {
            human.Block();
            human.Action = Player.PlayerAction.Block;
            computer.SimulateComputerChoice();
            DetermineRoundOutcome();
        }

        public void PlayerUseShotgun()
        {
            if (human.CanShotgun())
            {
                human.Shotgun();
                human.Action = Player.PlayerAction.Shotgun;
                computer.SimulateComputerChoice();
                DetermineRoundOutcome();
            }
            else
            {
                MessageBox.Show("You dont have enough rounds");
            }
        }

        private void DetermineRoundOutcome()
        {
            Player.PlayerAction humanAction = human.Action;
            Player.PlayerAction computerAction = computer.Action;


            if (humanAction == Player.PlayerAction.Reload && computerAction == Player.PlayerAction.Reload)
            {
                human.Reload();
                computer.Reload();
                lastOutcome = "Both players reloaded";
            }
            else if (humanAction == Player.PlayerAction.Reload && computerAction == Player.PlayerAction.Shoot)
            {
                computerWinCount++;
                human.ClearAmmo();
                computer.ClearAmmo();
                MessageBox.Show("Computer wins! Human tried to reload");
                lastOutcome = "Computer won last round";
            }
            else if (humanAction == Player.PlayerAction.Shoot && computerAction == Player.PlayerAction.Reload)
            {
                humanWinCount++;
                human.ClearAmmo();
                computer.ClearAmmo();
                MessageBox.Show("Human wins! Computer tried to reload");
                lastOutcome = "Human won last round";
            }
            else if (humanAction == Player.PlayerAction.Shoot && computerAction == Player.PlayerAction.Block)
            {
                human.Shoot();
                computer.Block();
                lastOutcome = "Computer blocked human shot";
            }
            else if (humanAction == Player.PlayerAction.Block && computerAction == Player.PlayerAction.Shoot)
            {
                human.Block();
                computer.Shoot();
                lastOutcome = "Human blocked computer shot";
            }
            else if (humanAction == Player.PlayerAction.Shoot && computerAction == Player.PlayerAction.Shoot)
            {
                human.Shoot();
                computer.Shoot();
                lastOutcome = "Both players shot. Both lost a bullet.";
            }
            else if (humanAction == Player.PlayerAction.Reload && computerAction == Player.PlayerAction.Block)
            {
                human.Reload();
                computer.Block();
                lastOutcome = "Human reloaded while computer blocked.";
            }
            else if (humanAction == Player.PlayerAction.Block && computerAction == Player.PlayerAction.Reload)
            {
                human.Block();
                computer.Reload();
                lastOutcome = "Computer reloaded while human blocked.";
            }
            else if (humanAction == Player.PlayerAction.Block && computerAction == Player.PlayerAction.Block)
            {
                human.Block();
                computer.Block();
                lastOutcome = "Both players used block, nothing happened";
            }
            else if (humanAction == Player.PlayerAction.Shotgun && computerAction != Player.PlayerAction.Shotgun)
            {
                humanWinCount++;
                human.ClearAmmo();
                computer.ClearAmmo();
                MessageBox.Show("Human wins with a Shotgun!");
                lastOutcome = "Human won last round with shotgun";
            }
            else if (humanAction != Player.PlayerAction.Shotgun && computerAction == Player.PlayerAction.Shotgun)
            {
                computerWinCount++;
                human.ClearAmmo();
                computer.ClearAmmo();
                MessageBox.Show("Computer wins with a Shotgun!");
                lastOutcome = "Computer won last round with shotgun";
            }
            else if (humanAction == Player.PlayerAction.Shotgun && computerAction == Player.PlayerAction.Shotgun)
            {
                human.ClearAmmo();
                computer.ClearAmmo();
                MessageBox.Show("Both players use Shotgun. It's a draw.");
                lastOutcome = "Both players used Shotgun. Draw.";
            }
        }
    }
}
