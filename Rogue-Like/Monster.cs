using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rogue_Like
{
    public class Monster : Encounter
    {
        public Characteristics Characteristics {  get; set; }

        public Monster(Characteristics characteristics) 
        {
            Name = "Monster";
            Characteristics = characteristics;
        }
        public override void Meet(Adventurer adventurer)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("["+adventurer.Name+"][LVL:"+adventurer.Level+"]");
            Console.WriteLine("[ATTAQUE:" +  adventurer.Characteristics.Attack + "]");
            Console.WriteLine("[SPEED:" + adventurer.Characteristics.Speed + "]");
            Console.WriteLine("[VITALITY][" + adventurer.Characteristics.Health + "/" + adventurer.Characteristics.MaxHealth + "]");
            Console.WriteLine();
            Console.WriteLine("[" + Name + "]");
            Console.WriteLine("[ATTAQUE:" + Characteristics.Attack + "]");
            Console.WriteLine("[SPEED:" + Characteristics.Speed + "]");
            Console.WriteLine("[VITALITY][" + Characteristics.Health + "/" + Characteristics.MaxHealth + "]");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

            while (Characteristics.Health > 0 && adventurer.Characteristics.Health > 0)
            {
                if(adventurer.Characteristics.Speed >= Characteristics.Speed)
                {
                    Console.WriteLine("Le héro fait un sort !");
                    adventurer.Trigger(adventurer.Characteristics, Characteristics);
                    if(Characteristics.Health <= 0)
                    {
                        break;
                    }
                    Console.WriteLine("Le Monstre attaque " + adventurer.Name);
                    adventurer.Characteristics.Health -= Characteristics.Attack;
                    Console.WriteLine(adventurer.Name + " perd " + Characteristics.Attack + "pv.");
                }
                else
                {
                    Console.WriteLine("Le Monstre attaque " + adventurer.Name);
                    adventurer.Characteristics.Health -= Characteristics.Attack;
                    Console.WriteLine(adventurer.Name + " perd " + Characteristics.Attack + "pv.");
                    if (adventurer.Characteristics.Health <= 0)
                    {
                        break;
                    }
                    Console.WriteLine("Le héro fait un sort !");
                    adventurer.Trigger(adventurer.Characteristics, Characteristics);
                }
                Console.WriteLine("["+adventurer.Name+"]["+adventurer.Characteristics.Health+"] - ["+Name+"]["+Characteristics.Health+"]");
            }
            if(adventurer.Characteristics.Health <= 0)
            {
                Console.WriteLine(adventurer.Name + " est mort ! PERDU !");
            }
            else
            {
                Console.WriteLine("Vous avez vaincu le " + Name + ". BRAVO !");
                adventurer.Level++;
                adventurer.LevelUp();
            }
        }
    }
}
