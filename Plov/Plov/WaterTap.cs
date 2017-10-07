using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plov
{
    class WaterTap
    {
        private bool open;

        public bool isOpen
        {
            get
            {
                return open;
            }

            set
            {
                open = value;
            }
        }

        public void washRice(Rice r)
        {
            if (r.isDirty) r.isDirty=false;

        }

        public void washVeg(Veg v)
        {
            if (v.isDirty) v.isDirty=false;
        }
    }
}
