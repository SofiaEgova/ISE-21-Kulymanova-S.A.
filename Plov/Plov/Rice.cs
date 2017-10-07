using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plov
{
    class Rice
    {
        private bool dirty = true;
        private bool ready;

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

        public bool getReay
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
