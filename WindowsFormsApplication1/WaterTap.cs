using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
	class WaterTap
	{
		public bool isOpen { set; get; }

		public void washRice(Rice r)
		{
			if (r.isDirty)
			{
				r.isDirty = false;
				r.wInRice = 10;
			}
		}

		public void washVeg(Veg v)
		{
			if (v.isDirty) v.isDirty = false;
		}

		/*public Water getWater()
		{
			if (isOpen)
			{
				return new Water();
			}
			else return null;
		} */
	}
}
