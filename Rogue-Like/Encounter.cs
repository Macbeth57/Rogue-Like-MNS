using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rogue_Like
{
    public abstract class Encounter
    {
        public string Name { get; set; }
        public virtual void Meet(Adventurer adventurer) { }
    }

}
