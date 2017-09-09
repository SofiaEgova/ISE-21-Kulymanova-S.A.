using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
	class Pan
	{
		private Rice rice;
		private Meat[] meat;
		private Veg[] veg;
		private Spice spice;
		private Water water;

		public void init(int countMeat,int countVeg)
		{
			meat = new Meat[countMeat];
			veg = new Veg[countVeg];
		}

		public void addSpice (Spice s)
		{
			spice = s;
		}

		public void addMeat(Meat m)
		{
			for (int i = 0; i < meat.Length; i++)
			{
				if (meat[i] == null)
				{
					meat[i] = m;
					return;
				}
			}
		}

		private bool checkMeat()
		{
			for(int i = 0; i < meat.Length; i++)
			{
				if (meat[i].needCut) return false;
			}
			return true;
		}

		private bool checkVeg()
		{
			for(int i = 0; i < veg.Length; i++)
			{
				if (veg[i].isDirty) return false;
				if (veg[i].needCut) return false;
				
			}
			return true;
		}

		private bool checkRice()
		{
			if (rice.isDirty) return false;
			return true;
		}


		public void heatMeat()
		{
			if (checkMeat())
			{
				if (water.temp < 100)
				{
					water.heat();
				}
				else {
					for (int i = 0; i < meat.Length; i++)
					{
						meat[i].heat();

					}
					
				}
				
			}
		}

		public bool meatIsReady()
		{
			for (int i = 0; i < meat.Length; i++)
			{
				if (meat[i].hasReady < 10) return false;
				

			}
			return true;
		}

		public void heatVeg()
		{
			if (checkVeg())
			{
				if (water.temp < 100)
				{
					water.heat();
				}
				else
				{
					for (int i = 0; i < veg.Length; i++)
					{
						veg[i].heat();
					}
				}
			}
		}

		public bool vegIsReady()
		{
			for (int i = 0; i < veg.Length; i++)
			{
				if (veg[i].hasReady < 10) return false;

			}
			return true;
		}

		public void heatRice()
		{
			if (checkRice())
			{
				water.heat();
				rice.heat();
			}
		}


		public bool isReady()
		{
			if((water.temp<100)&&(!rice.isReady())) return false;
			return true;
		}



	}
}
