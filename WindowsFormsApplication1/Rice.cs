using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
	class Rice
	{
		public bool isDirty { set; get; }
		private int water = 0;
		public bool isOn { set; get; }

		public int wInRice
		{
			set
			{
				if (value > -1 && value < 11) water = value;
			}
			get
			{
				return water;
			}
		}

		public void heat()
		{
			if (water > 0)
			{
				water--;
			}
		}

		public bool isReady()
		{
			if (water > 0) return false;
			return true;
		}

	}
}
