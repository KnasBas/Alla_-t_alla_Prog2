using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alla_åt_alla_Övningsprov
{
    class Zombie :Base
    {
        public Zombie()
        {
            intelligence = generator.Next(1,3); //1 - 2
            strength = generator.Next(1, 6); // 4 - 5
            endurance = generator.Next(4, 6); // 4 - 5
        }
    }
}
