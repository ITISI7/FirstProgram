using System;
using System.Collections.Generic;
using System.Text;

namespace Zombie
{
    class ArmoredZombie : Zombie
    {
        public float health;
        public float defensePoints = 10;

        public override void TakeDamage(float damagePoints)
        {
            damagePoints -= defensePoints;
            health -= damagePoints;

        }
    }
}
