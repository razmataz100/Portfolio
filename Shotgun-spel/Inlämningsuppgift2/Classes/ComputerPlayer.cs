using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Devices;

namespace Inlämningsuppgift2.Classes
{
    public sealed class ComputerPlayer : Player
    {
        private Random random;

        public ComputerPlayer()
        {
            random = new Random();
        }

        public void SimulateComputerChoice()
        {
            int computerChoice = 0;

            if (!CanShoot() && !CanShotgun())
            {
                computerChoice = random.Next(2);
            }
            else if (CanShoot() && !CanShotgun())
            {
                computerChoice = random.Next(3);
            }
            else if (CanShoot() && CanShotgun())
            {
                computerChoice = random.Next(4);
            }
            Action = (PlayerAction)computerChoice;

        }
    }
}
