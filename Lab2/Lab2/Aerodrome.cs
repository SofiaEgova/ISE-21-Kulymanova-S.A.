using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
	class Aerodrome
	{
		List<ClassArray<ITransport>> aerodromeStages;


		int countPlaces = 20;
		int placeWidth = 210;
		int placeHeight = 80;

		int currentLevel;

		public Aerodrome(int countStages)
		{
			aerodromeStages = new List<ClassArray<ITransport>>(countStages);
			for (int i = 0; i < countStages; i++)
			{
				aerodromeStages.Add(new ClassArray<ITransport>(countPlaces, null));
			}
		}

		public int getCurrentLevel
		{
			get
			{
				return currentLevel;
			}
		}


		public void levelUp()
		{
			if (currentLevel + 1 < aerodromeStages.Count) currentLevel++;
		}

		public void levelDown()
		{
			if (currentLevel > 0) currentLevel--;
		}

		public int putPlaneInAerodrome(ITransport plane)
		{
			return aerodromeStages[currentLevel] + plane;
		}

		public ITransport getPlaneInAerodrome(int index)
		{
			return aerodromeStages[currentLevel] - index;
		}

		public void draw(Graphics g,int width,int height)
		{
			drawMarking(g);
			
				for (int i = 0; i < countPlaces; i++)
				{
					var plane = aerodromeStages[currentLevel][i];
					if (plane != null)
					{
						plane.setPosition(5 + i / 5 * placeWidth + 5, i % 5 * placeHeight + 15);
						plane.draw(g);
					}
				}
			
		}

		public void drawMarking(Graphics g)
		{
			Pen p = new Pen(Color.Black, 3);
			g.DrawRectangle(p, 0, 0, (countPlaces / 5) * placeWidth, 450);
			for(int i = 0; i < countPlaces / 5; i++)
			{
				for(int j = 0; j < 6; j++)
				{
					g.DrawLine(p, i * placeWidth,j* placeHeight,i*placeWidth+110,j*placeHeight);
				}
				g.DrawLine(p, i * placeWidth, 0, i * placeWidth,400);
			}
		}

	}
}
