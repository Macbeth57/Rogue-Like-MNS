using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rogue_Like
{
    public interface ITriggerable
    {
        public void Trigger(Characteristics characteristicsHero, Characteristics characteristicsOpposant);
    }
}
