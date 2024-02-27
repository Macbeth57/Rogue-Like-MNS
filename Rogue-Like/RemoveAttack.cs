using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Rogue_Like
{
    public class RemoveAttack : ITriggerable
    {
        public void Trigger(Characteristics characteristicsHero, Characteristics characteristicsOpposant)
        {
            
            if (characteristicsOpposant.Attack == characteristicsOpposant.Attack / 3)
            {
                characteristicsOpposant.Attack = (characteristicsOpposant.Attack / 3) - 1;
            }
            else if(characteristicsOpposant.Attack < (characteristicsOpposant.Attack / 3) - 1)
            {
                Console.WriteLine("Le monstre est déjà diminué au maximum.");
            }
            else
            {
                characteristicsOpposant.Attack -= characteristicsOpposant.Attack / 3;
                Console.WriteLine("La cible perd "+ characteristicsOpposant.Attack / 3 + " points d'attaque.");
            }
            
        }
    }
}
