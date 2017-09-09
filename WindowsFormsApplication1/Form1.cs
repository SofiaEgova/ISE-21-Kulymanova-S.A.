using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class Form1 : Form
	{
		private Rice rice;
		private Meat[] meat;
		private Veg[] veg;
		private Spice spice;
		private WaterTap waterTap;

		private Knife knife;
		private Pan pan;
		private Stove stove;

		private bool ready = false;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			waterTap = new WaterTap();
			knife = new Knife();
			pan = new Pan();
			stove = new Stove();
			rice = new Rice();
		}

		

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton1.Checked)
			{
				waterTap.isOpen = true;
			}
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton2.Checked)
			{
				waterTap.isOpen = false;
			}
		}
		private void button11_Click(object sender, EventArgs e)
		{
			veg = new Veg[Convert.ToInt32(numericUpDown2.Value)];
			for (int i = 0; i < veg.Length; i++)
			{
				veg[i] = new Veg();
			}
			for (int i = 0; i < veg.Length; i++)
			{
				veg[i].isDirty = true;
			}

			meat = new Meat[Convert.ToInt32(numericUpDown1.Value)];
			for (int i = 0; i < meat.Length; i++)
			{
				meat[i] = new Meat();
			}
			for (int i = 0; i < meat.Length; i++)
			{
				meat[i].needCut = true;
			}


			numericUpDown2.Enabled = false;
			numericUpDown1.Enabled = false;
			ready = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (numericUpDown2.Value > 0/*&& numericUpDown2.Value>0*/)
			{
				if (!waterTap.isOpen)
				{
					MessageBox.Show("Кран закрыт, как мыть?", "Ошибкалогики", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				//meat = new Meat[Convert.ToInt32(numericUpDown1.Value)];
				

				pan.init(Convert.ToInt32(numericUpDown1.Value),Convert.ToInt32(numericUpDown2.Value));

				for (int i = 0; i < veg.Length; i++)
				{
					veg[i].needCut = true;
					veg[i].isDirty = false;
				}

				/*for(int i = 0; i < meat.Length; i++)
				{
					meat[i] = new Meat();
				}
				for (int i = 0; i < meat.Length; i++)
				{
					meat[i].needCut = true;
				}*/





				
				//numericUpDown2.Enabled = false;

				radioButton2.Checked = true;
				MessageBox.Show("Овощи помыли, можно резать", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			else
			{
				MessageBox.Show("Овощей нету, что мыть?", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (waterTap.isOpen)
			{
				if (rice.isOn)
				{
					rice.isDirty = false;

					MessageBox.Show("Рис помыли, можно варить", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
					radioButton2.Checked = true;
				}
				else
				{
					MessageBox.Show("Риса нету, что мыть?", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			else MessageBox.Show("Открой кран!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			
			rice.isDirty = true;
			rice.isOn = true;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (numericUpDown1.Value > 0)
			{
				
				for (int i = 0; i < meat.Length; i++)
				{
					meat[i].needCut = false;
				}
				MessageBox.Show("Мясо порезали, можно жарить", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
				
			}
			else
			{
				MessageBox.Show("Мяса нету, что резать?", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			
			if (numericUpDown2.Value > 0)
			{


				{
					for (int i = 0; i < veg.Length; i++)
					{
						if (veg[i].isDirty)
						{
							MessageBox.Show("Овощи грязные, что резать?", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
							return;
						}
						veg[i].needCut = false;
					}
					MessageBox.Show("Овощи порезаны, кидай в мясо", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

				}
			}
			else
			{
				MessageBox.Show("Овощей нету, что резать?", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			stove.isOn = true;
		}

		private void button8_Click(object sender, EventArgs e)
		{

			if (numericUpDown1.Value > 0){
				
				for (int i = 0; i < meat.Length; i++)
				{
					if (meat[i].needCut)
					{
						MessageBox.Show("Порежь мясо!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}

				}
				MessageBox.Show("Мясо добавили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Мяса нету", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			if (numericUpDown2.Value > 0)
			{

				for (int i = 0; i < veg.Length; i++)
				{
					if (veg[i].isDirty)
					{
						MessageBox.Show("Грязные овощи!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}
					if (veg[i].needCut)
					{
						MessageBox.Show("Порежь овощи!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}

				}
				MessageBox.Show("Овощи добавили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Овощей нету", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void button10_Click(object sender, EventArgs e)
		{
			if (rice.isOn)
			{
				if (rice.isDirty)
				{
					MessageBox.Show("рис грязный", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				MessageBox.Show("Рис добавлен", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Риса нету", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
