using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Rogue_Like
{
    public class Dungeon
    {
        public List<Room> roomsList = new List<Room>();

        public Dungeon() 
        {
            for (int i = 1; i <= 20; i++)
            {
                Random random = new Random();
                int randomEncounter = random.Next(1,4);
                switch (randomEncounter)
                {
                    case 1:
                        roomsList.Add(new Room(i, new Trap()));
                        break;
                    case 2:
                        roomsList.Add(new Room(i, new Item()));
                        break;
                    case 3:
                        roomsList.Add(new Room(i, new Monster(new Characteristics(2+i,10+i*2,10+i*2,1+(i/2)))));
                        break;
                    default:
                        break;
                    
                }
                Thread.Sleep(50);
            }
        }
        public void Game(Adventurer adventurer)
        {
            foreach (Room room in roomsList)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[ROOM " + room.Number +"]");
                Console.WriteLine();
                Console.ForegroundColor= ConsoleColor.White;
                room.Encounter.Meet(adventurer);
                if(!doesHeroStillAlive(adventurer))
                {
                    break;
                }
                Console.WriteLine("HP restants : " + adventurer.Characteristics.Health);
                
                Console.WriteLine();
            }
            if (doesHeroStillAlive(adventurer))
            {
                Console.WriteLine("Félicitation vous avez vaincu le donjon !");
            }
            else
            {
                Console.WriteLine("Perdu ! Vous êtes mort :(");
            }
        }
        public bool doesHeroStillAlive(Adventurer adventurer)
        {
            return adventurer.Characteristics.Health > 0 ? true : false;
        }
    }
}
