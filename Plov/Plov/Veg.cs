using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plov
{
    class Veg
    {

        private bool dirty=true;
        private bool cut = true;
        private bool ready = false;

        public bool isDirty
        {
            set
            {
                dirty = value;
            }

            get
            {
                return dirty;
            }
        }

        public bool needCut
        {
            set
            {
                cut = value;
            }

            get
            {
                return cut;
            }
        }


        public bool isReady
        {
            get
            {
                return ready;
            }
        }

        public void heat()
        {
            ready = true;
        }
    }
}
