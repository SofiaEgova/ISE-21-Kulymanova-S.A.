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
	public partial class FormAerodrome : Form
	{
		Aerodrome aerodrome;


		public FormAerodrome()
		{
			InitializeComponent();
			aerodrome = new Aerodrome();
			draw();
		}

		public void draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxAerodrome.Width, pictureBoxAerodrome.Height);
			Graphics gr = Graphics.FromImage(bmp);
			aerodrome.draw(gr, pictureBoxAerodrome.Width, pictureBoxAerodrome.Height);
			pictureBoxAerodrome.Image = bmp;
		}



		private void butSetPlane_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				var plane = new War(1000, 100, 30, 30, dialog.Color);
				int place = aerodrome.putPlaneInAerodrome(plane);
				draw();
				MessageBox.Show("Вашеместо: " + place);

			}
		}

		private void butSetFigther_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				ColorDialog dialogDop = new ColorDialog();
				if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					var plane = new Fighter(1000, 100, 30, 30, dialog.Color, true, true, dialogDop.Color);
					int place = aerodrome.putPlaneInAerodrome(plane);
					draw();
					MessageBox.Show("Вашеместо: " + place);

				}
			}
		}
		
		private void butTake_Click(object sender, EventArgs e)
		{
			if (maskedTextBox1.Text != "")
			{
				var plane = aerodrome.getPlaneInAerodrome(Convert.ToInt32(maskedTextBox1.Text));
				Bitmap bmp = new Bitmap(pictureBoxTakePlane.Width, pictureBoxTakePlane.Height);
				Graphics gr = Graphics.FromImage(bmp);
				plane.setPosition(5, 5);
				plane.draw(gr);
				pictureBoxTakePlane.Image = bmp;
				draw();
			}
		}

	}
}
