using System;
using System.Collections.Generic;
using System.Text;

namespace Zombie
{
    class Zombie
    {
        public float health = 50;

        // Accepts an attack with the given number of damage points
        public virtual void TakeDamage(float damagePoints)
        {
            health -= damagePoints;
            
            // TODO: given an amount of damage points, modify the zombie's health
        }

        // Returns the damage points dealt by this attack
        public virtual float Attack()
        {
            // TODO: calculate the number of points of damage to deal and return it
            return 40;
        }

        public bool lose()
        {
            bool defeated = false;
            if (health <= 0)
            {
                defeated = true;
            }
            return defeated;
        }
    }
}
