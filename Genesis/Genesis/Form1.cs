using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Genesis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        /*
        0-самец без гена 
        1-самец с геном 
        2-самка без гена
        3-самка с геном 
        */
        //Вот сюда можно вынести count <===
        uint count = 0;
        int countMG = 0;
        int countFG = 0;
        int countM = 0;
        int countF = 0;
        /// <summary>
        /// Метод подсчитывает количество особей в популяции с геном красоты и выводит на экран
        /// </summary>
        void countBirds()
        {
            for (int bird = 0; bird < population.Count; bird++)
            {
                if (population[bird] == 1 || population[bird] == 3 ) count++; // посчитать птиц с геном 
                if (population[bird] == 1) countMG++; // опсчитать самцов с геном 
                if (population[bird] == 3) countFG++; // опсчитать самок с геном 
                if (population[bird] == 0 || population[bird] == 1) countM++; // посчитать самцов 
                if (population[bird] == 2 || population[bird] == 3) countF++; // посчитать самок 
            }
            if (count == 0)
                genBeauty.Value = 0;
            else
            {
                int genbeauty = (int)(count / numPopulationSizeM.Value+numPopulationSizeF.Value* 100);
                if (genbeauty <= genBeauty.Maximum) { genBeauty.Value = genbeauty; }
                else { genBeauty.Value = genBeauty.Maximum; }
            }
            lblBeautyPercent.Text = genBeauty.Value.ToString() + "%";  
            lblGenCount.Text = count.ToString();
            //TODO: ДОбавить setState в местах, где необходима цветовая индикация
            TaskbarProgress.SetValue( System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle, count, (int)numPopulationSizeM.Value);
            TaskbarProgress.SetState(System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle, TaskbarProgress.TaskbarStates.Normal);
            Application.DoEvents();
        }
        /*
        0-самец без гена 
        1-самец с геном 
        2-самка без гена
        3-самка с геном 
        */
        bool stop = false;

        List<byte> population = new List<byte>();
        //Чтобы увидеть все задачи TODO нажми: меню "Вид" > "Список задач"
        private void btnStart_Click(object sender, EventArgs e)
        {
            txtLog.Text += "\r\nПривет!";
            
            if(btnStart.Text == "Остановить")
            {
                btnStart.Text = "Остановка эмуляции...";
                Application.DoEvents();
                stop = true;
                return;
            }

            btnStart.Text = "Остановить";
            //Блокировка кнопок
            numPopulationSizeM.Enabled = numPopulationSurvival.Enabled = numPopulationBonusSurvival.Enabled = numChildrenNumber.Enabled = numBeautyPercentM.Enabled = numBeautyCountM.Enabled = false;

            int populationSize = (int)numPopulationSizeM.Value+(int)numPopulationSizeF.Value;
            int populationSizeM = (int)numPopulationSizeM.Value;
            int populationSizeF = (int)numPopulationSizeF.Value;
            //Заполнил коллекцию птицами 
            for (int i = 0; i < populationSizeM; i++)
            {
                population.Add(0);
            }
            for (int i = 0; i < populationSizeF; i++)
            {
                population.Add(2);
            }
            countBirds();
            //Нашел процент самцов с геном от общего кол-ва самцов 
            decimal BeautyPercentM ;
            if (radGenPercent.Checked == true)
            {
                BeautyPercentM = numBeautyPercentM.Value / 100;
            }
            else
            {
                BeautyPercentM = numBeautyCountM.Value / populationSizeM; 
            }
            //нашел процент самок с геном от общего кол-ва самок
            decimal BeautyPercentF;
            if (radGenPercent.Checked == true)
            {
                BeautyPercentF = numBeautyPercentF.Value / 100;
            }
            else
            {
                BeautyPercentF = numBeautyCountF.Value / populationSizeF;
            }
            //Заполнение коллекции птицами с геном (не работают Х и У)
            int x = (int)(BeautyPercentM * populationSizeM);
            int y = (int)(BeautyPercentF * populationSizeF);
            while (x!=0 && y!=0)
                for (int i = 0; i < populationSize; i++)
                {
                    if (population[i] == 0) { population[i] = 1; x--; }
                    if (population[i] == 2) { population[i] = 3; y--; }
                }
            countBirds();
            

            uint step = 0;
            while (count < populationSize && count > 0)
            {
                if (stop)//Проверка, что кто-то останавливает эмуляцию
                {
                    btnStart.Text = "Пуск эмуляции";
                    stop = false;
                    numPopulationSizeM.Enabled = numPopulationSurvival.Enabled = numPopulationBonusSurvival.Enabled = numChildrenNumber.Enabled = numBeautyPercentM.Enabled = numBeautyCountM.Enabled = true;
                    return;
                }

                //Размножение2.0 (подходит только для не моногамных видов)
                Random chance = new Random();
                int cha = chance.Next(0, 100);
                for (int F = 0; F < populationSize; F++)//пройтись по всем птицам 
                {
                    if (population[F] == 2)//найти самку без гена
                    {
                        if (cha < (int)(countMG / countM)*100) //найти шанс того , что самец будет с геном 
                        {
                            for (int child = 0; child < (int)numChildrenNumber.Value; child++)//создать опредленное кол-во потомков
                                if (cha < (int)num1ParentChance.Value)//если повезло и ген передался потомку
                                {
                                    if (cha > 50) population.Add(1);//ребенок будет самцом с геном 
                                    else population.Add(3);//ребенок будет самкой с геном 
                                }
                                else//если не повезло и ген не передался потомку
                                {
                                    if (cha > 50) population.Add(0);//ребенок будет самцом без гена
                                    else population.Add(2);//ребенок будет самкой без гена
                                }
                        }
                        else //найти шанс того , что самец будет без гена => гена в семье нет . передавать нечего 
                        {
                            for (int child = 0; child < (int)numChildrenNumber.Value; child++)
                                if (cha > 50) population.Add(0);
                                else population.Add(2);
                        }
                    }
                    if (population[F] == 3)
                    {
                        if (cha < (int)(countMG / countM)*100)
                        {
                            for (int child = 0; child < (int)numChildrenNumber.Value; child++)
                                if (cha < (int)num2ParentsChance.Value)
                                {
                                    if (cha > 50) population.Add(1);
                                    else population.Add(3);
                                }
                                else
                                {
                                    if (cha > 50) population.Add(0);
                                    else population.Add(2);
                                }
                        }
                        else
                        {
                            for (int child = 0; child < (int)numChildrenNumber.Value; child++)
                                if (cha < (int)num1ParentChance.Value)
                                {
                                    if (cha > 50) population.Add(1);
                                    else population.Add(3);
                                }
                                else
                                {
                                    if (cha > 50) population.Add(0);
                                    else population.Add(2);
                                }
                        }
                    }
                }




                        //Вымирание2.0
                Random rnd = new Random();
                while (population.Count > populationSize)
                {
                    for (int i = 0; i < population.Count; i++)
                    {
                        int percent = rnd.Next(0, 100);
                        if (population[i] == 1 || population[i] == 3 && percent > numPopulationSurvival.Value + numPopulationBonusSurvival.Value)
                            population.RemoveAt(i);
                        if (i == population.Count) break;
                        if (population.Count == populationSize) break;
                        if (population[i] == 0 || population[i] == 2 && percent > numPopulationSurvival.Value)
                            population.RemoveAt(i);
                    }
                }
                lblStep.Text = "Поколение: " + ++step; 
                countBirds();
                txtLog.Text += ("\r\n" + "Кол-во птиц с геном через " + step + " поколение : " + count);

                if (numDelay.Value != 0)
                    System.Threading.Thread.Sleep( (int)numDelay.Value );
            }
            MessageBox.Show("Эмуляция завершена");

            btnStart.Text = "Пуск эмуляции";
            numPopulationSizeM.Enabled = numPopulationSurvival.Enabled = numPopulationBonusSurvival.Enabled = numChildrenNumber.Enabled = numBeautyPercentM.Enabled = numBeautyCountM.Enabled = true;
   
       
        }
         
         void num_Scroll(object sender, ScrollEventArgs e)
        {
            int N = e.NewValue - e.OldValue;
            NumericUpDown num = (NumericUpDown)sender;
            num.Value = num.Value + N * 50;
        }


        private void radGenPercent_CheckedChanged(object sender, EventArgs e)
        {
            if ( radGenPercent.Checked == true)
            {
                radGenCount.Checked = false;
                numBeautyPercentM.Enabled = true;
                numBeautyCountM.Enabled = false;
                numBeautyPercentF.Enabled = true;
                numBeautyCountF.Enabled = false;
            }
            else
            {
                radGenCount.Checked = true;
                numBeautyPercentM.Enabled = false ;
                numBeautyCountM.Enabled = true;
                numBeautyPercentF.Enabled = false;
                numBeautyCountF.Enabled = true;
            }
        }

        private void numPopulationSize_ValueChanged(object sender, EventArgs e)
        {
            numBeautyCountM.Maximum = numPopulationSizeM.Value - 1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}