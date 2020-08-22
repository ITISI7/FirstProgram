using System;
using System.Collections.Generic;
using System.Text;

namespace Zombie
{
    class RedZombie : Zombie
    {
        public float health = 100;
        
        public override void TakeDamage(float damagePoints)
        {

            health -= damagePoints;

        }

    }
}
