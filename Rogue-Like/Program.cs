namespace Rogue_Like
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dungeon dungeon = new Dungeon();
            Adventurer adventurer = new Adventurer("Louis", new Characteristics(10,100,100,4));
            dungeon.Game(adventurer);
        }
    }
}
