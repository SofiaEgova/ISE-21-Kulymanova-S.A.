using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public abstract class Plane:ITransport
    {


        protected float startX;
        protected float startY;

		public virtual int maxSpeed { protected set; get; }
        public virtual int weight { protected set; get; }
		public virtual int maxHeight { protected set; get; }
        public virtual int fuel { protected set; get; }

        public Color colorBody { protected set; get; }

        public abstract void move(Graphics g);
        public abstract void draw(Graphics g);

        public void setPosition(int x,int y)
        {
            startX = x;
            startY = y;
        }
        
        public virtual void setMainColor(Color c)
		{
			colorBody = c;
		}


    }
}
