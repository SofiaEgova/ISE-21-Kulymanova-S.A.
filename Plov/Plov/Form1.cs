using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plov
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

        private bool cook = false;
        private bool isFinish = false;


        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load_1(object sender, EventArgs e)
        {
            waterTap = new WaterTap();
            knife = new Knife();
            pan = new Pan();
            rice = new Rice();
            spice = new Spice();
            stove = new Stove();
        }
        

        private void washVeg_Click(object sender, EventArgs e)
        {
            if (cook)
            {
                if (waterTap.isOpen)
                {
                    for (int i = 0; i < veg.Length; i++)
                    {
                        if (!veg[i].isDirty)
                        {
                            MessageBox.Show("Овощи уже помыты, можно резать", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                           
                            return;
                        }
                        waterTap.washVeg(veg[i]);
                    }
                    MessageBox.Show("Овощи помыты, можно резать", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Открой кран", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }
            }
            else
            {
                MessageBox.Show("Нечего мыть", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }
        }

        private void washRice_Click(object sender, EventArgs e)
        {
            if (waterTap.isOpen)
            {
                if (!rice.isDirty)
                {
                    MessageBox.Show("Рис помыт, готовь", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    return;
                }
                waterTap.washRice(rice);
                MessageBox.Show("Помыли рис", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            else
            {
                MessageBox.Show("Открой кран", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
             
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(countMeat.Value)>0) &&(Convert.ToInt32(countVeg.Value)>0))
            {
                countMeat.Enabled = false;
                countVeg.Enabled = false;
                cook = true;

                int m = Convert.ToInt32(countMeat.Value);
                int v = Convert.ToInt32(countVeg.Value);
                

                pan.init(m,v);

                meat = new Meat[Convert.ToInt32(countMeat.Value)];
                veg = new Veg[Convert.ToInt32(countVeg.Value)];
                MessageBox.Show("Овощи есть, мясо есть. готовь","OK", MessageBoxButtons.OK, MessageBoxIcon.Information);


                for (int i = 0; i < meat.Length; i++)
                {
                    meat[i] = new Meat();
                }
                for (int i = 0; i < veg.Length; i++)
                {
                    veg[i] = new Veg();
                }

                
            }

            else
            {
                MessageBox.Show("Нужно взять мясо и овощи", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

        private void cutMeat_Click(object sender, EventArgs e)
        {
            if (cook)
            {
                for (int i = 0; i < meat.Length; i++)
                {
                    if (meat[i].needCut)
                    {
                        MessageBox.Show("Мясо уже нарезано, кидай в сковородку", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                        return;
                    }
                    else
                    {
                        knife.cutMeat(meat[i]);
                    }
                }
                MessageBox.Show("Мясо нарезано, можно жарить", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Нечего резать, где мясо?", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void cutVeg_Click(object sender, EventArgs e)
        {
            if (cook)
            {
                for (int i = 0; i < veg.Length; i++)
                {
                    if (veg[i].isDirty)
                    {
                        MessageBox.Show("Овощи грязные, помой их", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                        return;
                    }
                    if (!veg[i].needCut)
                    {
                        MessageBox.Show("Овощи уже порезаны, жарь", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     
                        return;
                    }
                    knife.cutVag(veg[i]);
                }
                MessageBox.Show("Овощи порезаны, можно жарить", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }

            else
            {
                MessageBox.Show("Нечего резать, где овощи?", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void addMeat_Click(object sender, EventArgs e)
        {
            if (cook)
            {
                for (int i = 0; i < meat.Length; i++)
                {
                    if (meat[i].needCut)
                    {
                        MessageBox.Show("Мясо не нарезано", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       
                        return;
                    }
                }
                pan.addMeat(meat);
                MessageBox.Show("Мясо в сковородке", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Нету мяса?", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void addRice_Click(object sender, EventArgs e)
        {
            pan.addRice(rice);
            MessageBox.Show("Рис вместе с мясом, финишная прямая", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void addVeg_Click(object sender, EventArgs e)
        {
            if (cook)
            {
                for (int i = 0; i < veg.Length; i++)
                {
                    if (veg[i].isDirty)
                    {
                        MessageBox.Show("Овощи грязные, помой их", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       
                        return;
                    }
                    if (veg[i].needCut)
                    {
                        MessageBox.Show("Овощи не порезаны", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       
                        return;
                    }
                }

                pan.addVeg(veg);
                MessageBox.Show("Овощи в сковородке", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

            else
            {
                MessageBox.Show("Нету овощей", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

        private void addSpice_Click(object sender, EventArgs e)
        {
            pan.addSpice(spice);
            MessageBox.Show("Добавили специй", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
        }

        private void fry_Click(object sender, EventArgs e)
        {
            if (stove.isOn)
            {
                if (cook)
                {

                    if (pan.meatIsReadyToGo())
                    {
                        stove.cook(pan);
                        MessageBox.Show("Мясо готово, кидай рис", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      
                    }
                    else
                    {
                        MessageBox.Show("Каких-то продуктов не хватает, не торопись", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                else
                {
                    MessageBox.Show("Нет продуктов", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Включи плиту!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void finish_Click(object sender, EventArgs e)
        {
            if (stove.isOn)
            {
                if (cook)
                {
                    if (pan.plovIsReadyToGo())
                    {
                        stove.cook(pan);
                        isFinish = true;
                        MessageBox.Show("Все готово, можно кушать", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else
                    {
                        MessageBox.Show("что-то там не так", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Нет продуктов", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Включи плиту!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void eat_Click(object sender, EventArgs e)
        {
            if (isFinish)
            {
                if (waterTap.isOpen)
                {
                    MessageBox.Show("Закрой кран", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    return;
                }
                if (stove.isOn)
                {
                    MessageBox.Show("Выключи плиту!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    return;
                }
               
                //System.exit(0);
                MessageBox.Show("Приятного аппетита", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Еще нечего кушать", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        


        private void waterTapOn_CheckedChanged(object sender, EventArgs e)
        {
            if (waterTapOn.Checked)
            {
                waterTap.isOpen = true;
                MessageBox.Show("Кран открыт", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void waterTapOff_CheckedChanged(object sender, EventArgs e)
        {
            if (waterTapOff.Checked)
            {
                waterTap.isOpen = false;
                MessageBox.Show("Кран закрыт", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void stoveIsOn_CheckedChanged(object sender, EventArgs e)
        {
            if (stoveIsOn.Checked)
            {
                MessageBox.Show("Плита включена", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                stove.isOn = true;
            }
        }

        private void stoveIsOff_CheckedChanged(object sender, EventArgs e)
        {
            if (stoveIsOff.Checked)
            {
                stove.isOn = false;
                MessageBox.Show("Плита выключена", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
