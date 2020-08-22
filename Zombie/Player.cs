using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Zombie
{
    class Player
    {
        public float healthPoints = 100;

        // Accepts an attack with the given number of damage points
        public void TakeDamage(float damagePoints)
        {
            // TODO: given an amount of damage points, modify the player's health
            healthPoints -= damagePoints;
        }

        // Returns the damage points dealt by this attack
        public float Attack()
        {
            return 25;
            // TODO: calculate the number of points of damage to deal and return it
        }
        public bool lose()
        {
            bool defeated = false; 
            if(healthPoints <= 0)
            {
                
                defeated = true;
                
            }
            return defeated;
        }
      
    }
}
