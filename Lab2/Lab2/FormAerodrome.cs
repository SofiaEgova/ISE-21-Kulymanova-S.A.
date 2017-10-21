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
			aerodrome = new Aerodrome(5);
			for (int i = 1; i < 6; i++)
			{
				listBoxLevels.Items.Add("Уровень " + i);
			}
			listBoxLevels.SelectedIndex = aerodrome.getCurrentLevel;
			
			draw();
		}

		public void draw()
		{
			if (listBoxLevels.SelectedIndex > -1)
			{
				Bitmap bmp = new Bitmap(pictureBoxAerodrome.Width, pictureBoxAerodrome.Height);
				Graphics gr = Graphics.FromImage(bmp);
				aerodrome.draw(gr, pictureBoxAerodrome.Width, pictureBoxAerodrome.Height);
				pictureBoxAerodrome.Image = bmp;
			}
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
			if (listBoxLevels.SelectedIndex > -1)
			{
				string level = listBoxLevels.Items[listBoxLevels.SelectedIndex].ToString();

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

		private void btnLevelDown_Click(object sender, EventArgs e)
		{
			aerodrome.levelDown();
			listBoxLevels.SelectedIndex = aerodrome.getCurrentLevel;
			draw();

		}

		private void btnLevelUp_Click(object sender, EventArgs e)
		{
			aerodrome.levelUp();
			listBoxLevels.SelectedIndex = aerodrome.getCurrentLevel;
			draw();

		}
	}
}
