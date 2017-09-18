using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plov
{
    class Pan
    {
        private Rice rice;
        private Meat[] meat;
        private Veg[] veg;
        private Spice spice;


        public void init(int countMeat, int countVeg)
        {
            meat = new Meat[countMeat];
            veg = new Veg[countVeg];
        }


        public void addSpice(Spice s)
        {
            spice = s;
        }

        public void addMeat(Meat[] m)
        {
            for (int i = 0; i < meat.Length; i++)
            {
                if (meat[i] == null)
                {
                    meat[i] = m[i];
                }
            }
        }

        public void addVeg(Veg[] v)
        {
            for (int i = 0; i < veg.Length; i++)
            {
                if (veg[i] == null)
                {
                    veg[i] = v[i];
                }
            }
        }

        public void addRice(Rice r)
        {
            rice = r;
        }

        public bool meatIsReadyToGo()
        {
            for (int i = 0; i < meat.Length; i++)
            {
                if (meat[i] == null) return false;
            }
            for (int i = 0; i < veg.Length; i++)
            {
                if (veg[i] == null) return false;
            }
            if (spice == null) return false;

            return true;
        }



        public bool plovIsReadyToGo()
        {
            for (int i = 0; i < meat.Length; i++)
            {
                if (meat[i] == null) return false;
            }
            for (int i = 0; i < veg.Length; i++)
            {
                if (veg[i] == null) return false;
            }
            if (spice == null) return false;

            if (rice == null) return false;

            return true;
        }


        public void heat()
        {
            for (int i = 0; i < meat.Length; i++)
            {
                meat[i].heat();
            }
            for (int i = 0; i < veg.Length; i++)
            {
                veg[i].heat();
            }
            if (rice != null)
            {
                rice.heat();
            }
        }
    }
}
