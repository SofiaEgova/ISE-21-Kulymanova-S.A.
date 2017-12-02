using NLog;
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
		FormSelectPlane formSelect;
		private Logger log;


		public FormAerodrome()
		{
			InitializeComponent();
			log = LogManager.GetCurrentClassLogger();
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
				log.Info("Поставили самолет на место " + place);
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
					log.Info("Поставили истребитель на место " + place);
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
					try
					{
						var plane = aerodrome.getPlaneInAerodrome(Convert.ToInt32(maskedTextBox1.Text));
						Bitmap bmp = new Bitmap(pictureBoxTakePlane.Width, pictureBoxTakePlane.Height);
						Graphics gr = Graphics.FromImage(bmp);
						plane.setPosition(5, 5);
						plane.draw(gr);
						pictureBoxTakePlane.Image = bmp;
						draw();
						log.Info("Забрали самолет с места" + maskedTextBox1.Text);
					}
					catch (AerodromeIndexOutOfRangeException ex)
					{
						MessageBox.Show(ex.Message, "Неверный номер", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Общая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void btnLevelDown_Click(object sender, EventArgs e)
		{
			aerodrome.levelDown();
			listBoxLevels.SelectedIndex = aerodrome.getCurrentLevel;
			draw();
			log.Info("Спустились на уровень ниже, сечас мы на " + aerodrome.getCurrentLevel);
		}

		private void btnLevelUp_Click(object sender, EventArgs e)
		{
			aerodrome.levelUp();
			listBoxLevels.SelectedIndex = aerodrome.getCurrentLevel;
			draw();
			log.Info("Поднялись на уровень выше, сечас мы на " + aerodrome.getCurrentLevel);
		}

		private void btnGetPlane_Click(object sender, EventArgs e)
		{
			formSelect = new FormSelectPlane();
			formSelect.addEvent(addPlane);
			formSelect.Show();
			
		}
		
		private void addPlane(ITransport plane)
		{
			if (plane != null)
			{
				try
				{
					int place = aerodrome.putPlaneInAerodrome(plane);
					if (place > -1)
					{
						draw();
						MessageBox.Show("Ваше место " + place);
						log.Info("Добавили самолет на место " + place);
					}
				}
				catch (AerodromeOverflowException ex) {
					MessageBox.Show(ex.Message, "Самолет поставить не удалось", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Общая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				
			}
		}

		private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				if (aerodrome.saveData(saveFileDialog1.FileName))
				{
					MessageBox.Show("Сохранение прошло успешно", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					log.Info("Сохранили аэродром в файл " + saveFileDialog1.FileName);
				}
				else
				{
					MessageBox.Show("Не сохранилось", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(openFileDialog1.ShowDialog()== System.Windows.Forms.DialogResult.OK)
			{
				MessageBox.Show("open","", MessageBoxButtons.OK, MessageBoxIcon.Information);
				if (aerodrome.loadData(openFileDialog1.FileName))
				{
					MessageBox.Show("load", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					if (aerodrome.loadData(openFileDialog1.FileName))
					{
						MessageBox.Show("Загрузили", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
						log.Info("Загрузили аэродром из файла " + openFileDialog1.FileName);
					}
					else
					{
						MessageBox.Show("Не загрузили", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			draw();
		}
	}
}
