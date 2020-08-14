using System;
using System.Threading;

namespace IfStatementExerices
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playerAlive = true;
            int invulnerabilityTimer = 1;
            // Check if the player is alive
            if (playerAlive)
            {
                Console.WriteLine("The player is alive");
            }
            else
            {
                Console.WriteLine("The player is dead");
            }
            // Invulnerability
            if(invulnerabilityTimer > 0)
            {
                if (playerAlive)
                {
                    invulnerabilityTimer--;
                }

                Console.WriteLine("The player is invulnerable");

            }
            else if(invulnerabilityTimer == 0)
            {
                Console.WriteLine("The player is vulnerable");
            }
            else if(invulnerabilityTimer < 0)
            {
                invulnerabilityTimer = 0;
            }

        }
    }
}
