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

        public Fighter(int maxSpeed, int fuel,int maxHeight, int weight, Color color, bool bomb,bool gun,Color colorFight):base(maxSpeed, fuel, maxHeight,weight, color)
        {
            this.bomb = bomb;
            this.gun = gun;
            this.colorFight = colorFight;
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
    }
}
