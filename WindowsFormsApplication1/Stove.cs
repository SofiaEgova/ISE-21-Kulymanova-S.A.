using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
	class Stove
	{

		private Pan pan;
		public bool isOn { set; get; }

		public Pan ppan
		{
			set
			{
				pan = value;
			}
			get
			{
				return pan;
			}
		}

		public void heat()
		{
			if (isOn)
			{
				while (!pan.meatIsReady())
				{
					pan.heatMeat();
				}
				while (!pan.vegIsReady())
				{
					pan.heatVeg();
				}
				while (!pan.isReady())
				{
					pan.heatRice();
				}
			}
		}

	}
}
