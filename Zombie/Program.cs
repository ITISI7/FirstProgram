using Microsoft.VisualBasic;
using System;

namespace Zombie
{
    class Program
    {
        static void Main(string[] args)
        {
            // introduction text
            Console.WriteLine("Welcome to the Zombie Arena");

            // controls whether battle should continue
            bool isBattleOver = false; ;
            //  instantiate
            Player player = new Player();
            Zombie zombie = new Zombie();
            ArmoredZombie armored = new ArmoredZombie();
            RedZombie red = new RedZombie();
            Healing heal = new Healing();

            // battle loop
            while (!isBattleOver)
            {
                // prompt the player for input
                Console.WriteLine("What would you like to do?");
                string playerInput = Console.ReadLine();
                // player action
                if(playerInput == "help")
                {
                    Console.WriteLine("your option are \n attack \n check_health" +
                        " \n check_if_alive \n heal \n quit");
                }
                if(playerInput == "quit")
                {
                    isBattleOver = true;
                }
                if (playerInput == "check_health")
                {
                    Console.WriteLine(player.healthPoints);
                }
                if (playerInput == "check_if_alive")
                {
                    Console.WriteLine("You are alive");
                }
                if (playerInput == "attack")
                {
                   float damageDealth = player.Attack();
                    zombie.TakeDamage(damageDealth);
                    Console.WriteLine("player dealth " + damageDealth + " points of damage");
                    Console.WriteLine("zombie has " + zombie.health + " points of health left. ");
                    //Zombie action\
                    float zombieAttack = zombie.Attack();
                    player.TakeDamage(zombieAttack);
                    Console.WriteLine("Zombie dealth " + zombieAttack + " damage, you have " 
                        + player.healthPoints + " health left.");
                   
                }
                if(playerInput == "heal" && heal.healLeft > 0)
                {
                    player.healthPoints += heal.healthGain;
                    --heal.healLeft;
                    Console.WriteLine("You gain " + heal.healthGain + " health point. you now have " + player.healthPoints + " and you have " 
                        + heal.healLeft + " heal left"); 
                    //Zombie action
                    float zombieAttack = zombie.Attack();
                    player.TakeDamage(zombieAttack);
                    Console.WriteLine("Zombie dealth " + zombieAttack + " damage, you have "
                        + player.healthPoints + " health left.");
                }
                // dead condition
                if (player.lose() == true)
                {
                    isBattleOver = true;
                    Console.WriteLine("you dead");
                }
                if(zombie.lose() == true)
                {
                    Console.WriteLine("The zombie is dead");
                    isBattleOver = true;
                    
                }
            }
            

            // good-bye text
            Console.WriteLine("Thanks for playing! Press ENTER to exit.");
            Console.ReadLine();

            return;
        }
    }
}