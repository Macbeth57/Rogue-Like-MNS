using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rogue_Like
{
    public class Trap : Encounter
    {
        public Trap() { }
        public override void Meet(Adventurer adventurer)
        {
            Console.WriteLine("Piège ! Vous perdez 10pv !");
            adventurer.Characteristics.Health -= 10;
        }
    }
}
