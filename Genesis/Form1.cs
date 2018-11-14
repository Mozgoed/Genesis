﻿using System;
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
        //TODO: Добавить ТекстБокс и сделать привязку кнопки и его к форме +++
        //TODO: Сделать окно расширяемым вниз FormBorderStyle и Size, Min...Size, Max...Size +++

        
        //Вот сюда можно вынести count <===

        /// <summary>
        /// Метод подсчитывает количество особей в популяции с геном красоты и выводит на экран
        /// </summary>
        void countBirds()
        {
            double count = 0; //TODO: Вынести count за пределы метода countBirds(). И поменять его тип с double на uint
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

            //TODO: ДОбавить setState в местах, где необходима цветовая индикация
            TaskbarProgress.SetValue( System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle, count, (int)numPopulationSize.Value);
            TaskbarProgress.SetState(System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle, TaskbarProgress.TaskbarStates.Normal);

            Application.DoEvents();
        }

        bool stop = false;
        bool[] population;
        //Чтобы увидеть все задачи TODO нажми: меню "Вид" > "Список задач"
        //TODO: использовать в программе populationSize
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Остановить")
            {
                btnStart.Text = "Остановка эмуляции...";
                Application.DoEvents();
                stop = true;
                return;
            }

            btnStart.Text = "Остановить";
            //Блокировка кнопок
            numPopulationSize.Enabled = numPopulationSurvival.Enabled =
            numPopulationBonusSurvival.Enabled = numChildrenNumber.Enabled =
            numBeautyPercent.Enabled = numBeautyCount.Enabled = false;

            int populationSize = (int)numPopulationSize.Value;
            population = new bool[populationSize];
            countBirds();
            decimal BeautyPercent;
            if (radGenPercent.Checked == true)
            {
                BeautyPercent = numBeautyPercent.Value / 100;
            }
            else
            {
                BeautyPercent = numBeautyCount.Value / populationSize; //тут ,чтобы не заморачиваться с кол-вом особей с геном, нашел сколько процентов составляют ососби с геном// 
            }

            for (int bird = 0; bird < populationSize * BeautyPercent; bird++)
            {
                population[bird] = true;
            }
            countBirds();

            //TODO: MessageBox тут уже не нужен и только раздражает. Он нужен был чтобы показать сколько процентов изначально в популяции. Теперь это будет вычисляться на ходу
            MessageBox.Show("Заполнена часть популяции особей с геном красоты \nНачало эмуляции...");

            uint step = 0;
            //TODO: Программа не работает в режиме одной особи, потому что в таком случае genBeauty.Value уже сразу равен 0. Поэтому надо сравнивать с нулём переменную count, а не полосу зелёную
            while (genBeauty.Value < 100 && genBeauty.Value > 0)
            {
                if (stop)//Проверка, что кто-то останавливает эмуляцию
                {
                    btnStart.Text = "Пуск эмуляции";
                    stop = false;
                    //TODO: ВКЛЮЧИТЬ тут кнопки
                    return;
                }

                //Размножение
                byte[] byteGeneration = new byte[populationSize * ((int)numChildrenNumber.Value + 1)];
                int child = 0;
                for (int bird = 0; bird < populationSize; bird++)
                {
                    for (int i = 0; i < (numChildrenNumber.Value + 1); i++)
                    {
                        if (population[bird] == true)
                            byteGeneration[child++] = 1;
                        else
                            byteGeneration[child++] = 0;
                    }
                }

                //Вымирание
                Random rnd = new Random();
                int count2Kill = byteGeneration.Length - population.Length;
                while (count2Kill > 0)
                    for (child = 0; child < byteGeneration.Length; child++)
                    {
                        int percent = rnd.Next(0, 100);
                        if (byteGeneration[child] == 0 && percent > numPopulationSurvival.Value)
                        {
                            byteGeneration[child] = 255;
                            count2Kill--;
                        }
                        if (byteGeneration[child] == 1 && percent > numPopulationSurvival.Value + numPopulationBonusSurvival.Value)
                        {
                            byteGeneration[child] = 255;
                            count2Kill--;
                        }
                        if (count2Kill == 0) break;
                    }

                //Перенос выживших особей из большого массива в стандартный
                int count = 0;
                for (child = 0; child < byteGeneration.Length; child++)
                {
                    if (byteGeneration[child] == 0) { population[count++] = false; }
                    if (byteGeneration[child] == 1) { population[count++] = true; }
                }
                lblStep.Text = "Поколение: " + ++step;
                countBirds();

                if (numDelay.Value != 0)
                    System.Threading.Thread.Sleep((int)numDelay.Value);
            }
            MessageBox.Show("Эмуляция завершена");

            btnStart.Text = "Пуск эмуляции";
            //Включение кнопок 
            numPopulationSize.Enabled = numPopulationSurvival.Enabled = numPopulationBonusSurvival.Enabled = numChildrenNumber.Enabled = numBeautyPercent.Enabled = numBeautyCount.Enabled = true;
        }
        //TODO: При изменении размера популяции, % особей с геном, Кол-во особей с геном => Выводить на экран "Количество особей с геном" в объект Label.

        private void num_Scroll(object sender, ScrollEventArgs e)
        {
            int N = e.NewValue - e.OldValue;
            NumericUpDown num = (NumericUpDown)sender;
            num.Value = num.Value + N * 50;
        }
        //TODO: Переделать на num_Scroll остальные методы со скроллом
        private void numPopulationSurvival_Scroll(object sender, ScrollEventArgs e)
        {
            int K = e.NewValue - e.OldValue;
            numPopulationSurvival.Value = numPopulationSurvival.Value + K * 50;
        }
        //TODO: Максимальное количество особей с геном не должно быть выше всей популяции. У numBeautyCount - Maximum на 1 меньше, чем размер популяции numPopulationSize.Value
        private void numPopulationBonusSurvival_Scroll(object sender, ScrollEventArgs e)
        {
            int L = e.NewValue - e.OldValue;
            numPopulationBonusSurvival.Value = numPopulationBonusSurvival.Value + L * 50;
        }

        private void radGenPercent_CheckedChanged(object sender, EventArgs e)
        {
            if ( radGenPercent.Checked == true)
            {
                radGenCount.Checked = false;
                numBeautyPercent.Enabled = true;
                numBeautyCount.Enabled = false;
            }
            else
            {
                radGenCount.Checked = true;
                numBeautyPercent.Enabled = false ;
                numBeautyCount.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}