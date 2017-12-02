using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

		public bool saveData(string filename)
		{
			if (File.Exists(filename)) File.Delete(filename);

			using(FileStream fs = new FileStream(filename, FileMode.Create))
			{
				using(BufferedStream bs = new BufferedStream(fs))
				{
					byte[] info = new UTF8Encoding(true).GetBytes("countLevels:" + aerodromeStages.Count + Environment.NewLine);
					fs.Write(info, 0, info.Length);
					foreach(var level in aerodromeStages)
					{
						info = new UTF8Encoding(true).GetBytes("level" + Environment.NewLine);
						fs.Write(info, 0, info.Length);
						for(int i = 0; i < countPlaces; i++)
						{
							var plane = level[i];
							if (plane != null)
							{
								if (plane.GetType().Name == "War")
								{
									info = new UTF8Encoding(true).GetBytes("War:");
									fs.Write(info, 0, info.Length);
								}
								if (plane.GetType().Name == "Fighter")
								{
									info = new UTF8Encoding(true).GetBytes("Fighter:");
									fs.Write(info, 0, info.Length);
								}
								info = new UTF8Encoding(true).GetBytes(plane.getInfo() + Environment.NewLine);
								fs.Write(info, 0, info.Length);
							}
						}
					}
				}
			}
			return true;
		}

		public bool loadData(string filename)
		{
			if (!File.Exists(filename)) return false;

			using(FileStream fs = new FileStream(filename, FileMode.Open))
			{
				string s = "";
				using(BufferedStream bs = new BufferedStream(fs))
				{
					byte[]b= new byte[fs.Length];
					UTF8Encoding temp = new UTF8Encoding(true);
					while (bs.Read(b, 0, b.Length) > 0){
						s += temp.GetString(b);
					}
				}
				s = s.Replace("\r", "");
				var strs = s.Split('\n');
				if (strs[0].Contains("countLevels:"))
				{
					int count = Convert.ToInt32(strs[0].Split(':')[1]);
					if (aerodromeStages != null) aerodromeStages.Clear();
					aerodromeStages = new List<ClassArray<ITransport>>(count);
				}
				else  {
					
					return false;
				}
				int counter = -1;
				for(int i = 1; i < strs.Length; ++i)
				{
					if (strs[i] == "level")
					{
						counter++;
						aerodromeStages.Add(new ClassArray<ITransport>(countPlaces, null));
					}
					else if (strs[i].Split(':')[0] == "War")
					{
						ITransport plane = new War(strs[i].Split(':')[1]);
						int number = aerodromeStages[counter] + plane;
						if (number == -1) return false;
					}
					else if(strs[i].Split(':')[0] == "Fighter")
					{
						ITransport plane = new Fighter(strs[i].Split(':')[1]);
						int number = aerodromeStages[counter] + plane;
						if (number == -1) return false;
					}
				}
			}

			return true;
		}

	}
}
