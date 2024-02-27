using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rogue_Like
{
    public class Item : Encounter
    {
        public Item() { }
        public override void Meet(Adventurer adventurer)
        {
            Random random = new Random();
            int randomEffect = random.Next(1, 4);

            Console.WriteLine("Vous trouvez une potion au sol.");

            switch (randomEffect)
            {
                case 1:
                    Console.WriteLine("Vous vous soignez de 10 hp !");
                    adventurer.Characteristics.Health += 10;
                    break;
                case 2:
                    Console.WriteLine("Vous gagnez 1 de vitesse !");
                    adventurer.Characteristics.Speed += 1;
                    break;
                case 3:
                    Console.WriteLine("Vous gagnez 5 d'attaque !");
                    adventurer.Characteristics.Attack += 5;
                    break;
                default:
                    break;
            }
        }
    }
}
