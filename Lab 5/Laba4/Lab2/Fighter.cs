using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Fighter:War
    {
        private bool bomb;
        private bool gun;

        private Color colorFight;

		public void setcolorFight(Color d)
		{
			colorFight = d;
		}

		public Fighter(int maxSpeed, int fuel,int maxHeight, int weight, Color color, bool bomb,bool gun,Color colorFight):base(maxSpeed, fuel, maxHeight,weight, color)
        {
            this.bomb = bomb;
            this.gun = gun;
            this.colorFight = colorFight;
        }

		public Fighter(string info) : base(info)
		{
			string[] strs = info.Split(';');
			if (strs.Length == 8)
			{
				this.maxSpeed = Convert.ToInt32(strs[0]);
				this.fuel = Convert.ToInt32(strs[1]);
				this.weight = Convert.ToInt32(strs[2]);
				this.colorBody = Color.FromName(strs[3]);
				this.maxHeight = Convert.ToInt32(strs[4]);
				this.bomb = Convert.ToBoolean(strs[5]);
				this.gun = Convert.ToBoolean(strs[6]);
				this.colorFight = Color.FromName(strs[7]);
			}

		}
        protected override void drawWarPlane(Graphics g)
        {
			base.drawWarPlane(g);

			if (bomb)
            {
				Pen p = new Pen(colorFight);
				g.DrawEllipse(p, startX, startY + 10, 15, 10);

				Brush b = new SolidBrush(colorFight);
				g.FillEllipse(b, startX, startY + 10, 15, 10);

            }
            if (gun)
            {
                Pen p = new Pen(colorFight);
                g.DrawRectangle(p, startX+30, startY + 35, 30, 5);

                Brush b = new SolidBrush(colorFight);
                g.FillRectangle(b, startX+30, startY + 35, 30, 5);
            }

            
        }
		public override string getInfo()
		{
			return maxSpeed + ";" + fuel + ";" + weight + ";" + colorBody.Name + ";" + maxHeight+";"+bomb+";"+gun+";"+colorFight.Name;
		}
	}
}
