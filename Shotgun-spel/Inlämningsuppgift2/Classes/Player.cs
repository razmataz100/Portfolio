using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Devices;

namespace Inlämningsuppgift2.Classes
{
    public abstract class Player
    {
        public int Ammo { get; set; }
        public PlayerAction Action { get; set; }
        public int Wins { get; set; }

        public Player()
        {
            Ammo = 0;
        }

        public virtual void Reload()
        {
            Ammo++;
        }

        public virtual void Block()
        {

        }

        public virtual void Shoot() 
        {
            
            if (Ammo >  0)
            {
                Ammo--;
            }
        }

        public virtual void Shotgun()
        {
            ClearAmmo();
        }

        public virtual bool CanShotgun()
        {
            return Ammo >= 3;
        }

        public virtual bool CanShoot()
        {
            return Ammo > 0;
        }

        public void ClearAmmo()
        {
            Ammo = 0;           
        }


        public enum PlayerAction
        {
            Reload,
            Block,
            Shoot,
            Shotgun
        }
    }
}
