using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alla_åt_alla_Monsterdesign
{
    class Monster
    {
        public string name;
        public int strength = 10;
        public int hp;
        public int maxHp;
        protected static Random generator = new Random();


        public virtual int Attack()
        {
            return generator.Next(strength / 2, strength + 1);
        }

        public virtual void Hurt(int amount)
        {
            hp = hp - amount;
        }
    }
}
