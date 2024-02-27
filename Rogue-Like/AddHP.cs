using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rogue_Like
{
    public class AddHP : ITriggerable
    {
        public void Trigger(Characteristics characteristicsHero, Characteristics characteristicsOpposant)
        {
            if (characteristicsHero.Health >= characteristicsHero.MaxHealth)
            {
                Console.WriteLine("Le héro tente de se healer mais a déjà ses PV au max.");
            }
            else if (characteristicsHero.Health >= characteristicsHero.MaxHealth - characteristicsHero.MaxHealth / 8 && characteristicsHero.Health < characteristicsHero.MaxHealth)
            {
                Console.WriteLine("Le Héro se rend " + characteristicsHero.MaxHealth / 8 + " hp.");
                characteristicsHero.Health = characteristicsHero.MaxHealth;
            }
            else
            {
                characteristicsHero.Health += characteristicsHero.MaxHealth/8;
                Console.WriteLine("Le Héro se rend " + characteristicsHero.MaxHealth / 8 + " hp.");
            }
            
        }
    }
}
