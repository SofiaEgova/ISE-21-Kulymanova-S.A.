using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
	public partial class FormSelectPlane : Form
	{
		public delegate void myDel(ITransport plane);
		ITransport plane = null;

		public ITransport getPlane { get { return plane; } }

		private event myDel eventAddPlane;

		public FormSelectPlane()
		{
			InitializeComponent();
			btnNo.Click += (object sender, EventArgs e) => { Close(); };
		}

		public void addEvent(myDel ev)
		{
			if(eventAddPlane == null)
			{
				eventAddPlane = new myDel(ev);
			}
			else
			{
				eventAddPlane += ev;
			}
		}

		private void labelPlane_MouseDown(object sender, MouseEventArgs e)
		{
			labelPlane.DoDragDrop(labelPlane.Text, DragDropEffects.Move | DragDropEffects.Copy);
		}

		private void panelPlane_DragDrop(object sender, DragEventArgs e)
		{
			switch (e.Data.GetData(DataFormats.Text).ToString())
			{
				case "Plane":
					plane = new War(100, 10, 100, 100, Color.White);
					break;
				case "Fighter":
					plane = new Fighter(100, 10, 100, 100, Color.White, true, true, Color.Black);
					break;
			}
			drawPlane();
		}

		private void panelPlane_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.Text))
				e.Effect = DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;
		}

		public void drawPlane()
		{
			if (plane != null)
			{
				Bitmap bmp = new Bitmap(pictureBoxSelectPlane.Width, pictureBoxSelectPlane.Height);
				Graphics gr = Graphics.FromImage(bmp);
				plane.setPosition(5, 5);
				plane.draw(gr);
				pictureBoxSelectPlane.Image = bmp;
			}
		}

		private void labelMainColor_DragDrop(object sender, DragEventArgs e)
		{
			if (plane != null)
			{
                labelMainColor.BackColor = (Color)e.Data.GetData(typeof(Color));
                plane.setMainColor((Color)e.Data.GetData(typeof(Color)));
				drawPlane();
			}
		}

		private void labelMainColor_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(Color)))
				e.Effect = DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;
		}

		private void panelColor_MouseDown(object sender, MouseEventArgs e)
		{
			(sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
		}

		private void labelDopColor_DragDrop(object sender, DragEventArgs e)
		{
			if (plane != null)
			{
				if (plane is Fighter) {
                    labelDopColor.BackColor = (Color)e.Data.GetData(typeof(Color));
                    (plane as Fighter).setcolorFight((Color)e.Data.GetData(typeof(Color)));
					drawPlane();
				}
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (eventAddPlane != null) { eventAddPlane(plane); }
			Close();
		}

		private void labelFighter_MouseDown(object sender, MouseEventArgs e)
		{
			labelFighter.DoDragDrop(labelFighter.Text, DragDropEffects.Move | DragDropEffects.Copy);
		}
		
	}
}
