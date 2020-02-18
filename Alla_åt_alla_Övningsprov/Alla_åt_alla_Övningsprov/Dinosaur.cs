using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alla_åt_alla_Övningsprov
{
    class Dinosaur :Base
    {
        public Dinosaur()
        {
            intelligence = generator.Next(4, 6); //1 - 2
            strength = generator.Next(1, 6); // 4 - 5
            endurance = generator.Next(1, 3); // 4 - 5
        }
    }
}
