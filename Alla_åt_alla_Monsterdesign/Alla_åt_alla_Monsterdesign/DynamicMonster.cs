using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alla_åt_alla_Monsterdesign
{
    class DynamicMonster : Monster
    {
        public override int Attack()
        {         
            int amount = generator.Next(2, 5);
            hp = hp + amount;
            return base.Attack();
        }

        public override void Hurt(int amount)
        {
            amount = amount + generator.Next(2, 5);
           base.Hurt(amount); 
        }
    }
}
