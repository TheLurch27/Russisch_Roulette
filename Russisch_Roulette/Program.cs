using System.Drawing;
using System.Numerics;

namespace Russisch_Roulette
{

    internal class RussianRoulette
    {
        static public Gun computerGun;
        static public Gun playerGun;

        static public Player player = new Player();
        static public Player computer = new Player();

        static int round = 0;
        public static void Main()
        {


            Console.WriteLine("Willkommen zum kürzesten Spiel deines Lebens...");

            int size = 1; // Console.Write "Bitte gib eine Chamber größe ein ...


            computerGun = new Gun(size);
            playerGun = new Gun(size);

            Console.WriteLine("Gebe an wieviele Patronen-Kammern die Pistolen haben.");
            size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Der Computer beginnt: ");

            do
            {
                if (computerGun.Shoot(computer))
                {
                    Console.WriteLine("Bang - Der Computer ist Tot, du gewinnst in Runde: " + round);
                }
                else if (playerGun.Shoot(player))
                {
                    Console.WriteLine("Click - Der Computer hat überlebt!");
                    Console.WriteLine("Bang - Du bist tot: " + round);
                }
                else
                {
                    Console.WriteLine("Click - Ihr beide habt Runde " + round + " Überlebt!");
                    round++;
                }
            } while (player.IsAlive && computer.IsAlive);
        }
    }
}
