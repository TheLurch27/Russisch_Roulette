using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russisch_Roulette
{
    internal class Player
    {

        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
        }

        //Wenn isAlive auf false springt, wird die Schleife verlassen und das Spiel beendet.
        private bool isAlive = true;


        public void KillPlayer()
        {
            isAlive = false;
        }
    }
}