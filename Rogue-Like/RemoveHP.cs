using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rogue_Like
{
    public class RemoveHP : ITriggerable
    {
        public void Trigger(Characteristics characteristicsHero, Characteristics characteristicsOpposant)
        {
            characteristicsOpposant.Health -= characteristicsHero.Attack;
            Console.WriteLine("La cible perd " + characteristicsHero.Attack + " pv!");
        }
    }
}
