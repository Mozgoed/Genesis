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

        /// <summary>
        /// Метод подсчитывает количество особей в популяции с геном красоты и выводит на экран
        /// </summary>
        void countBirds()
        {
            double count = 0;
            for (int bird = 0; bird < population.Length; bird++)
            {
                if (population[bird] == true)
                    count++;
            }
            if (count == 0)
                genBeauty.Value = 0;
            else
                genBeauty.Value = (int)(count / population.Length * 100);
            lblBeautyPercent.Text = genBeauty.Value.ToString() + "%";
            Application.DoEvents();
        }

        bool[] population;
        //Чтобы увидеть все задачи TODO нажми: меню "Вид" > "Список задач"
        //TODO: использовать в программе populationSize
        private void btnStart_Click(object sender, EventArgs e)
        {
            int populationSize = (int)numPopulationSize.Value;
            population = new bool[populationSize];
            countBirds();
            MessageBox.Show("Создан массив особей без гена красоты");
            //TODO: создать интерфейс для начального процента особей с признаком красоты++
            int BeautyPresent =(int)num.Value/100;
            for (int bird = 0; bird < population.Length * BeautyPresent; bird++)
            {
                population[bird] = true;
            }
            countBirds();
            MessageBox.Show("Заполнена часть популяции особей с геном красоты");

            //Размножение
            //TODO: создать интерфейс для количества потомков (2)++
            byte[] byteGeneration = new byte[population.Length * 2];
            int child = 0;
            for (int bird = 0; bird < population.Length; bird++)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (population[bird] == true)
                        byteGeneration[child++] = 1;
                    else
                        byteGeneration[child++] = 0;
                }
            }

            //Вымирание
            Random rnd = new Random();
            int count = population.Length;
            while (count > 0)
                for (child = 0; child < byteGeneration.Length; child++)
                {
                    int percent = rnd.Next(0, 100);
                    //TODO: оптимизировать все операторы if, если они вложены друг в друга ++
                    if (byteGeneration[child] == 0 && percent > 70)
                    {
                        //TODO: создать интерфейс для базовой выживаемости особи++
                        
                        
                            byteGeneration[child] = 255;
                            count--;
                        
                    }
                    if (byteGeneration[child] == 1 && percent > 70 + 10)
                    {
                        //TODO: создать интерфейс бонусной выживаемости красивой особи++
                        
                        
                            byteGeneration[child] = 255;
                            count--;
                        
                    }
                    if (count == 0) break;
                }

            count = 0;
            for (child = 0; child < byteGeneration.Length; child++)
            {
                if (byteGeneration[child] == 0) population[count++] = false;
                if (byteGeneration[child] == 1) population[count++] = true;
            }
            countBirds();
            //TODO: удалить ненужные MessageBox'ы и добавить по необходимости нужные++
            MessageBox.Show("Эмуляция завершена");
        }

        private void numPopulationSize_Scroll(object sender, ScrollEventArgs e)
        {
            int N = e.NewValue - e.OldValue;
            //TODO: подобрать оптимальный коэффициент для вращения колёсика мыши ++
            numPopulationSize.Value = numPopulationSize.Value + N*50;
        }

        private void numPopulationSurvival_Scroll(object sender, ScrollEventArgs e)
        {
            int K = e.NewValue - e.OldValue;
            numPopulationSurvival.Value = numPopulationSurvival.Value + K * 50;
        }

        private void numPopulationBonusSurvival_Scroll(object sender, ScrollEventArgs e)
        {
            int L = e.NewValue - e.OldValue;
            numPopulationBonusSurvival.Value = numPopulationBonusSurvival.Value + L * 50;
        }

       
    }
}