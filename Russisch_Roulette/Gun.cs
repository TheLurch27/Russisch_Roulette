using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Russisch_Roulette
{
    internal class Gun
    {
        private int[] chamber;
        private int chamberPull = 0;

        public Gun(int _chamberSize)
        {
            Random rnd = new Random();

            chamber = new int[_chamberSize];

            chamberPull = rnd.Next(0, chamber.Length);
            chamber[rnd.Next(0, chamber.Length - 1)] = 1;
        }

        public bool Shoot(Player _player)
        {
            if (chamber[chamberPull] == 1)
            {
                _player.KillPlayer();
                chamberPull++;
                return true;
            }
            else
            {
                chamberPull++;
                return false;
            }
        }
    }
}
