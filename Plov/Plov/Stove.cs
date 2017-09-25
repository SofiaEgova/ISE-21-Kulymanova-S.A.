using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plov
{
    class Stove
    {
        private bool state;


        public bool isOn
        {
            set
            {
                state = value;
            }

            get
            {
                return state;
            }
        }
        

        public Pan cook(Pan pan)
        {
            pan.heat();
            return pan;
        }
    }
}
