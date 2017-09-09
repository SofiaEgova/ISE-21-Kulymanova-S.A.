using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
	class Water
	{
		private int t = 0;

		public int temp
		{
			set
			{
				t = value;
			}
			get
			{
				return t;
			}
		}

		public void heat()
		{
			if (t < 100) t++;
		}

	}
}
