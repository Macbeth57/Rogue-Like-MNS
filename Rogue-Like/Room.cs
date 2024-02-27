using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rogue_Like
{
    public class Room
    {
        public int Number { get; set; }
        public Encounter Encounter { get; set; }

        public Room (int number, Encounter encounter) 
        {
            Number = number;
            Encounter = encounter;
        }
    }
}
