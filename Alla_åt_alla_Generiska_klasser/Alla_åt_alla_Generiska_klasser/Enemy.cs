using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alla_åt_alla_Generiska_klasser
{
    class Enemy
    {
        private int hp;

        protected static Random generator = new Random();

        public Enemy()
        {
            hp = generator.Next(10, 21); //10 - 20
        }

        public int GetHp()
        {
            return hp;
        }
    }
}
