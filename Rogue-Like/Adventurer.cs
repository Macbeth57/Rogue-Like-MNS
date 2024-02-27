using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rogue_Like
{
    public class Adventurer 
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public Characteristics Characteristics { get; set; }
        public List<ITriggerable> Triggers { get; set; }

        public Adventurer(string name, Characteristics characteristics) 
        {
            Name = name;
            Level = 1;
            Characteristics = characteristics;
            Triggers = new List<ITriggerable>();
            RemoveAttack removeAttack = new RemoveAttack();
            Triggers.Add(removeAttack);
            AddHP addHP = new AddHP();
            Triggers.Add(addHP);
            RemoveHP removeHP = new RemoveHP();
            Triggers.Add(removeHP);
        }

        public void Trigger(Characteristics characteristicsHero, Characteristics characteristicsOpposant)
        {
            Thread.Sleep(10);
            Random random = new Random();
            int randomSkill = random.Next(0, 3);
            Triggers[randomSkill].Trigger(Characteristics,characteristicsOpposant);
        }
        public void LevelUp()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine(Name + " gagne un niveau.");
            Console.WriteLine(Name + " gagne 1 d'attaque, 10 de vie et 1 de vitesse.");
            Characteristics.Attack += 1;
            Characteristics.Speed += 1;
            Characteristics.MaxHealth += 10;
            Characteristics.Health += 10;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
