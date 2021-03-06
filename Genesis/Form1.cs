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
        //TODO: Добавить ICO иконку к программе а) Свойство Icon б) "Проект" => "Свойства" => "Значок"

        uint count = 0;
        /// <summary>
        /// Метод подсчитывает количество особей в популяции с геном красоты и выводит на экран
        /// </summary>
        void countBirds()
        {
            for (int bird = 0; bird < population.Count; bird++)
            {
                if (population[bird] == true)
                    count++;
            }
            if (count == 0)
                genBeauty.Value = 0;
            else
            {
                int genbeauty = (int)(count / numPopulationSize.Value * 100);
                if (genbeauty <= genBeauty.Maximum) { genBeauty.Value = genbeauty; }
                else { genBeauty.Value = genBeauty.Maximum; }
            }
            lblBeautyPercent.Text = genBeauty.Value.ToString() + "%";
            // При изменении размера популяции, % особей с геном, Кол-во особей с геном => Выводить на экран "Количество особей с геном" в объект Label.   
            lblGenCount.Text = count.ToString();
            //TODO: ДОбавить setState в местах, где необходима цветовая индикация
            TaskbarProgress.SetValue( System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle, count, (int)numPopulationSize.Value);
            TaskbarProgress.SetState(System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle, TaskbarProgress.TaskbarStates.Normal);

            Application.DoEvents();
        }

        bool stop = false;

        List<bool> population = new List<bool>();
        //Чтобы увидеть все задачи TODO нажми: меню "Вид" > "Список задач"
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
            //Блокировка кнопок
            numPopulationSize.Enabled = numPopulationSurvival.Enabled =
            numPopulationBonusSurvival.Enabled = numChildrenNumber.Enabled =
            numBeautyPercent.Enabled = numBeautyCount.Enabled = false;

            int populationSize = (int)numPopulationSize.Value;
            //Заполнил коллекцию птицами
            //TODO: При каждом новом запуске надо очищать коллекцию от птиц. А иначе второй запуск эмуляции в том же окне глючит.
            for (int i = 0; i < populationSize; i++)
                population.Add(false);
            countBirds();
            //Выбрал птиц с генами 
            decimal BeautyPercent ;
            if (radGenPercent.Checked == true) //TODO: radGenPercent.Checked само по себе является логической переменной
                BeautyPercent = numBeautyPercent.Value / 100;
            else
                BeautyPercent = numBeautyCount.Value / populationSize; 
           
            for (int bird = 0; bird < populationSize * BeautyPercent; bird++)
                population[bird] = true;
            countBirds();


            uint step = 0;
            while (count < populationSize && count > 0)
            {
                if (stop)//Проверка, что кто-то останавливает эмуляцию
                {
                    btnStart.Text = "Пуск эмуляции";
                    stop = false;
                    numPopulationSize.Enabled = numPopulationSurvival.Enabled = numPopulationBonusSurvival.Enabled = numChildrenNumber.Enabled = numBeautyPercent.Enabled = numBeautyCount.Enabled = true;
                    return;
                }

                //Размножение 2.0
                for (int child = 0; child < populationSize; child++)
                {
                    if (population[child])
                        for (int i = 0; i < numChildrenNumber.Value; i++) //TODO: Заменить все объекты формы на переменные локальные (в начале эмуляции их разместить)
                            population.Add(true);
                    else
                        for (int i = 0; i < numChildrenNumber.Value; i++)
                            population.Add(false);
                }

                //Вымирание 2.0
                Random rnd = new Random();
                while (population.Count > populationSize)
                {
                    for (int i = 0; i < population.Count; i++)
                    {
                        int percent = rnd.Next(0, 100);
                        if (population[i])
                        {
                            if (percent > numPopulationSurvival.Value + numPopulationBonusSurvival.Value)
                                population.RemoveAt(i);
                        }
                        else
                            if (percent > numPopulationSurvival.Value)
                                population.RemoveAt(i);
                        if (population.Count <= populationSize)
                            break;
                    }
                }
                lblStep.Text = "Поколение: " + ++step;
                //uint A = count;
                countBirds();
                //uint P = (uint)(populationSize - count) / (count - A);
                //if (count > populationSize) P = 0;
                //txtLog.Text += string.Format("\r\nКол-во птиц с геном через {0} поколение {1}\r\nПтицы без гена вымрут приблизительно через {2} поколений", step,count,P);
                if (numDelay.Value != 0)
                    System.Threading.Thread.Sleep( (int)numDelay.Value );
            }
            MessageBox.Show("Эмуляция завершена");
            btnStart.Text = "Пуск эмуляции";
            numPopulationSize.Enabled = numPopulationSurvival.Enabled =
                numPopulationBonusSurvival.Enabled = numChildrenNumber.Enabled =
                numBeautyPercent.Enabled = numBeautyCount.Enabled = true;
        }
         
         void num_Scroll(object sender, ScrollEventArgs e)
        {
            int N = e.NewValue - e.OldValue;
            NumericUpDown num = (NumericUpDown)sender;
            num.Value = num.Value + N * 50;
        }


        private void radGenPercent_CheckedChanged(object sender, EventArgs e)
        {
            if ( radGenPercent.Checked == true) //TODO: radGenPercent.Checked само по себе является логической переменной
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

        private void numPopulationSize_ValueChanged(object sender, EventArgs e)
        {
            numBeautyCount.Maximum = numPopulationSize.Value - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
#if DEBUG
            CollectionsTrening about = new CollectionsTrening();
            about.ShowDialog();
#else
            About aboutbox = new About();
            aboutbox.ShowDialog();
#endif
        }
    }
}