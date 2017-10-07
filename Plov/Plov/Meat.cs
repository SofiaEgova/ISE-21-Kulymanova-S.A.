using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plov
{
    class Meat
    {
        private int ready=0;

        public bool needCut { set; get; }

        public int hasReady
        {

            get
            {
                return ready;
            }
        }

        public void heat()
        {
            while (ready < 10) ready++;
        }
    }
}
