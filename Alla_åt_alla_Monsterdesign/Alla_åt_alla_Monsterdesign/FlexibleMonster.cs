using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alla_åt_alla_Monsterdesign
{
    class FlexibleMonster : Monster
    {
        public override int Attack()
        {
            int i = generator.Next(1, 11);

            if(i <= 3)
            {
                return i = base.Attack() * 2;
            }
            else
            {
                return base.Attack();
            }
        }
    }
}
