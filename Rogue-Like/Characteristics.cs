using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rogue_Like
{
    public class Characteristics
    {
        public int Attack {  get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int Speed { get; set; }

        public Characteristics(int attack, int health, int maxHealth, int speed) 
        {
            Attack = attack;
            Health = health;
            MaxHealth = maxHealth;
            Speed = speed;
        }    
    }
}
