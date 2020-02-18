using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alla_åt_alla_Generiska_klasser
{
    class Hero
    {
        private int hp = 100;

        private int xp = 0;

        public int Hp
        {
            get
            {
                return hp;
            }
            private set
            {
                hp = Math.Max(value, 0);
            }
        }

        public int Level
        {
            get
            {
                return (xp / 10) + 1;
            }
            private set { }         
        }

        public int Xp
        {
            get
            {
                return xp;
            }
            private set{}
        }


    }
}
