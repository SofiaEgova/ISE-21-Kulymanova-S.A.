using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plov
{
    class Knife
    {
        public void cutMeat(Meat m)
        {
            if (m.needCut) m.needCut=false;
        }

        public void cutVag(Veg v)
        {
            if (v.needCut) v.needCut=false;
        }
    }
}
