using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
	class Veg
	{

		public bool isDirty { set; get; }
		public bool needCut { set; get; }
		


		private int ready = 0;
		

		public int hasReady
		{
			get
			{
				return ready;
			}
		}

		public void heat()
		{
			if (ready < 10) ready++;
		}

	}
}
