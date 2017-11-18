using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public class War:Plane
    {

        public War(int maxSpeed,int fuel, int maxHeight,int weight,Color color)
        {
            this.maxSpeed = maxSpeed;
            this.fuel = fuel;
            this.weight = weight;
            this.colorBody = color;
			this.maxHeight = maxHeight;

			startX = 10;
			startY = 100;


        }
public War(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 5)
            {
                this.maxSpeed = Convert.ToInt32(strs[0]);
                this.fuel = Convert.ToInt32(strs[1]);
                this.weight = Convert.ToInt32(strs[2]);
                this.colorBody = Color.FromName(strs[3]);
                this.maxHeight = Convert.ToInt32(strs[4]);
            }
            startX = 10;
            startY = 100;
        }



        public override int maxSpeed
        {
            get
            {
                return base.maxSpeed;
            }
            protected set
            {
                if (value > 0 && value < 2500) base.maxSpeed = value;
                else base.maxSpeed = 2000;
            }
        }

        public override int weight
        {
            get
            {
                return base.weight;
            }

            protected set
            {
                if (value > 16000 && value < 35000) base.weight = value;
                else base.weight = 30000;
            }
        }

		public override int maxHeight
		{
			get
			{
				return base.maxHeight;

			}
			protected set
			{
				if (value > 0 && value < 100) base.maxHeight = value;
				else base.maxHeight = 5;
			}
		
		}

		public override void move(Graphics g)
        {

			
            if (this.fuel>0)
            {
                if (startY > maxHeight)
                    startY -= 3;
			
                startX += 10;
                this.fuel -= 10;
            }
            else
            {
                MessageBox.Show("Нету топлива", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

			draw(g);
            
        }

        public override void draw(Graphics g)
        {
            drawWarPlane(g);
            
        }

        protected virtual void drawWarPlane(Graphics g)
        {
            Pen p = new Pen(colorBody);
            g.DrawEllipse(p, startX+10, startY, 20, 50);
			g.DrawEllipse(p, startX, startY+20, 60, 20);


			Brush b = new SolidBrush(colorBody);
			g.FillEllipse(b, startX+10, startY, 20, 50);
			g.FillEllipse(b, startX, startY + 20, 60, 20);


		}
public override string getInfo()
        {
            return maxSpeed + ";" + fuel + ";" + weight + ";" + colorBody.Name + ";" + maxHeight;
        }


    }
}
