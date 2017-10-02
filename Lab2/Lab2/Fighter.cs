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

        private Color color1;

        public Fighter(int maxSpeed, int fuel,int maxHeight, int weight, Color color, bool bomb,bool gun,Color color1):base(maxSpeed, fuel, maxHeight,weight, color)
        {
            this.bomb = bomb;
            this.gun = gun;
            this.color1 = color1;
        }

        protected override void drawWarPlane(Graphics g)
        {
			base.drawWarPlane(g);

			if (bomb)
            {
				Pen p = new Pen(color1);
				g.DrawEllipse(p, startX, startY + 10, 15, 10);

				Brush b = new SolidBrush(color1);
				g.FillEllipse(b, startX, startY + 10, 15, 10);

            }
            if (gun)
            {
                Pen p = new Pen(color1);
                g.DrawRectangle(p, startX+30, startY + 35, 30, 5);

                Brush b = new SolidBrush(color1);
                g.FillRectangle(b, startX+30, startY + 35, 30, 5);
            }

            
        }
    }
}
