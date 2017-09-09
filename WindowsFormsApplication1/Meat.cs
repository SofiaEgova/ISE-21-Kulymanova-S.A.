using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
	class Meat
	{
		private int ready = 0;

		public bool needCut { get; set; }

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
