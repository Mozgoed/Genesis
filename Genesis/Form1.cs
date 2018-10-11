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

        bool stop = false;
        bool[] population;
        //Чтобы увидеть все задачи TODO нажми: меню "Вид" > "Список задач"
        //TODO: использовать в программе populationSize
        private void btnStart_Click(object sender, EventArgs e)
        {
            if(btnStart.Text == "Остановить")
            {
                btnStart.Text = "Остановка эмуляции...";
                Application.DoEvents();
                stop = true;
                return;
            }

            btnStart.Text = "Остановить";
            //TODO: блокировать остальные кнопки и внизу разблокировать
            numPopulationSize.Enabled = false;
            numPopulationSurvival.Enabled = false;
            numPopulationBonusSurvival.Enabled = false;
            numChildrenNumber.Enabled = false;
            numBeautyPercent.Enabled = false;
            numBeautryCount.Enabled = false;
            numDelay.Enabled = false;

            int populationSize = (int)numPopulationSize.Value;
            population = new bool[populationSize];
            countBirds();
            decimal BeautyPercent ;
            if (radGenPercent.Checked == true)
            {
                BeautyPercent = numBeautyPercent.Value / 100;
            }
            else
            {
             BeautyPercent = numBeautryCount.Value / populationSize; //тут ,чтобы не заморачиваться с кол-вом особей с геном, нашел сколько процентов составляют ососби с геном// 
            }
           
            for (int bird = 0; bird < populationSize * BeautyPercent; bird++)
            {
                population[bird] = true;
            }
            countBirds();

            MessageBox.Show("Заполнена часть популяции особей с геном красоты \nНачало эмуляции...");

            uint step = 0;
            while (genBeauty.Value < 100 && genBeauty.Value > 0)
            {
                //Проверка, что кто-то останавливает эмуляцию
                if (stop)
                {
                    btnStart.Text = "Пуск эмуляции";
                    stop = false;
                    return;
                }

                //Размножение
                //TODO: создать интерфейс для количества потомков (2)--(сделал)
                byte[] byteGeneration = new byte[populationSize * ((int)numChildrenNumber.Value + 1)];
                int child = 0;
                for (int bird = 0; bird < populationSize; bird++)
                {
                    for (int i = 0; i < (numChildrenNumber.Value + 1); i++)//И тут тоже
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
                        if (byteGeneration[child] == 0 && percent > numPopulationSurvival.Value )//TODO: создать интерфейс для базовой выживаемости особи (70)(Сделал)
                        {
                            byteGeneration[child] = 255;
                            count--;
                        }
                        if (byteGeneration[child] == 1 && percent > numPopulationSurvival.Value + numPopulationBonusSurvival.Value) //TODO: создать интерфейс бонусной выживаемости красивой особи (10)(Сделал)
                        {
                            byteGeneration[child] = 255;
                            count--;
                        }
                        if (count == 0) break;
                    }

                //Перенос выживших особей из большого массива в стандартный
                count = 0;
                for (child = 0; child < byteGeneration.Length; child++)
                {
                    if (byteGeneration[child] == 0) { population[count++] = false; }
                    if (byteGeneration[child] == 1) { population[count++] = true; }
                }
                lblStep.Text = "Поколение: " + ++step;
                countBirds();

                if(numDelay.Value != 0)
                    System.Threading.Thread.Sleep( (int)numDelay.Value );
            }
            MessageBox.Show("Эмуляция завершена");

            btnStart.Text = "Пуск эмуляции";
            numPopulationSize.Enabled = true;
            numPopulationSurvival.Enabled = true;
            numPopulationBonusSurvival.Enabled = true;
            numChildrenNumber.Enabled = true;
            numBeautyPercent.Enabled = true;
            numBeautryCount.Enabled = true;
            numDelay.Enabled = true;


        }

        private void numPopulationSize_Scroll(object sender, ScrollEventArgs e)
        {
            int N = e.NewValue - e.OldValue;
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

        private void radGenPercent_CheckedChanged(object sender, EventArgs e)
        {
            //TODO: при клике по левому RadioButton - выключается правый цифровой блок. И наоборот.(вроде сделал)
            if ( radGenPercent.Checked == true)
            {
                radGenCount.Checked = false;
                numBeautyPercent.Enabled = true;
                numBeautryCount.Enabled = false;
            }
            else
            {
                radGenCount.Checked = true;
                numBeautyPercent.Enabled = false ;
                numBeautryCount.Enabled = true;
            }
        }


    }
}