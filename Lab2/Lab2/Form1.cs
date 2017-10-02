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
    public partial class a : Form
    {

		Color color;
		Color color1;
		int maxSpeed;
		int weight;
		int maxHeight;
        int fuel;



		private Transport interTran;

        public a()
        {
            InitializeComponent();
			color = Color.Red;
			color1 = Color.Black;
			maxSpeed = 2000;
            fuel = 0;
			weight = 30000;
			maxHeight = 5;

			selectColor.BackColor = color;
			selectColor1.BackColor = color1;

        }

		private void drawPlane_Click(object sender, EventArgs e)
		{
			if (checkFields())
			{
				interTran = new War(maxSpeed, fuel, maxHeight, weight, color);
				Bitmap bmp = new Bitmap(drawBox.Width, drawBox.Height);
				Graphics gr = Graphics.FromImage(bmp);
				interTran.draw(gr);
				drawBox.Image = bmp;
			}
		}

		private void selectColor_Click(object sender, EventArgs e)
		{

			if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				color = colorDialog1.Color;
				selectColor.BackColor = color;
			}
			
		}

		private bool checkFields()
		{
			if (!int.TryParse(textMSpeed.Text, out maxSpeed)) return false;
			if (!int.TryParse(textMFuel.Text, out fuel)) return false;
			if (!int.TryParse(textW.Text, out weight)) return false;
			if (!int.TryParse(textMHeight.Text, out maxHeight)) return false;

			return true;
		}

		private void butMove_Click(object sender, EventArgs e)
		{
			if (interTran!=null){

				Bitmap bmp = new Bitmap(drawBox.Width, drawBox.Height);
				Graphics gr = Graphics.FromImage(bmp);
				interTran.move(gr);
				drawBox.Image = bmp;
			}
		}

		private void drawF_Click(object sender, EventArgs e)
		{
			if (checkFields())
			{
				interTran = new Fighter(maxSpeed, fuel, maxHeight, weight, color, checkBomb.Checked, checkGun.Checked, color1);
				Bitmap bmp = new Bitmap(drawBox.Width, drawBox.Height);
				Graphics gr = Graphics.FromImage(bmp);
				interTran.draw(gr);
				drawBox.Image = bmp;
			}
		}

		private void selectColor1_Click(object sender, EventArgs e)
		{
			if (colorDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				color1 = colorDialog2.Color;
				selectColor1.BackColor = color1;
			}
		}
	}
}
	


