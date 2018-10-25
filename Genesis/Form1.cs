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
            if (btnStart.Text == "Остановить")
            {
                TaskbarProgress.SetState(System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle, TaskbarProgress.TaskbarStates.Paused);
                MessageBox.Show("Идёт процесс эмуляции.\nНеобходимо сначала остановить его.");
                TaskbarProgress.SetState(System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle, TaskbarProgress.TaskbarStates.Normal);
                e.Cancel = true;
            }
        }

        uint count = 0;
        /// <summary>
        /// Метод подсчитывает количество особей в популяции с геном красоты и выводит на экран
        /// </summary>
        void countBirds()
        {
            count = 0;
            for (int bird = 0; bird < population.Length; bird++)
            {
                if (population[bird] == true)
                    count++;
            }
            if (count == 0)
                genBeauty.Value = 0;
            else
                genBeauty.Value = (int)((double)count / population.Length * 100);
            lblBeautyPercent.Text = genBeauty.Value.ToString() + "%";
            lblCount.Text = "Особей: " + count + " / " + numPopulationSize.Value;

            TaskbarProgress.SetValue(System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle, count, (int)numPopulationSize.Value);

            Application.DoEvents();
        }

        bool stop = false;
        bool[] population;
        private void btnStart_Click(object sender, EventArgs e)
        {
            if(btnStart.Text == "Остановить")
            {
                TaskbarProgress.SetState(System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle, TaskbarProgress.TaskbarStates.Error);
                btnStart.Text = "Остановка эмуляции...";
                Application.DoEvents();
                stop = true;
                return;
            }

            LockControls(true);
            txtLog.Text += "\r\n";
            txtLog.Text += string.Format("\r\nЭмуляция: Особи/Популяция = {0}", lblCount.Text.Substring(lblCount.Text.IndexOf(" ")));
            txtLog.Text += string.Format("\r\nБаза = {0}, Бонус = {1}, Потомки = {2}", numPopulationSurvival.Value, numPopulationBonusSurvival.Value, numChildrenNumber.Value);

            bool result = Emulation();

            TaskbarProgress.SetState(System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle, TaskbarProgress.TaskbarStates.Indeterminate);
            if(result)
                txtLog.Text += "\r\nРезультат: Ген победил. ";
            else
                txtLog.Text += "\r\nРезультат: Ген проиграл. ";
            txtLog.Text += lblStep.Text;
            MessageBox.Show("Эмуляция завершена");
            TaskbarProgress.SetState(System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle, TaskbarProgress.TaskbarStates.NoProgress);

            LockControls(false);
        }

        void LockControls(bool isLocked)
        {
            if(isLocked)
            {
                btnStart.Text = "Остановить";
                //Блокировка кнопок
                numPopulationSize.Enabled = numPopulationSurvival.Enabled =
                numPopulationBonusSurvival.Enabled = numChildrenNumber.Enabled =
                numBeautyPercent.Enabled = numBeautyCount.Enabled = radGenPercent.Enabled = radGenCount.Enabled = !isLocked;
            }
            else
            {
                btnStart.Text = "Пуск эмуляции";
                //РазБлокировка кнопок
                numPopulationSize.Enabled = numPopulationSurvival.Enabled =
                numPopulationBonusSurvival.Enabled = numChildrenNumber.Enabled =
                radGenPercent.Enabled = radGenCount.Enabled = !isLocked;
                if (radGenPercent.Checked)
                    numBeautyPercent.Enabled = !isLocked;
                else
                    numBeautyCount.Enabled = !isLocked;
            }
        }

        private bool Emulation()
        {
            int populationSize = (int)numPopulationSize.Value;
            population = new bool[populationSize];
            countBirds();
            decimal BeautyPercent;
            if (radGenPercent.Checked)
            {
                BeautyPercent = numBeautyPercent.Value / 100;
            }
            else
            {
                BeautyPercent = numBeautyCount.Value / populationSize;
            }

            for (int bird = 0; bird < populationSize * BeautyPercent; bird++)
            {
                population[bird] = true;
            }
            countBirds();

            uint step = 0;
            while (genBeauty.Value < 100 && count > 0)
            {
                //Проверка, что кто-то останавливает эмуляцию
                if (stop)
                {
                    btnStart.Text = "Пуск эмуляции";
                    TaskbarProgress.SetState(System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle, TaskbarProgress.TaskbarStates.Normal);
                    stop = false;
                    return false;
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
            if (count == 0) return false;
            else return true;
        }

        private void num_Scroll(object sender, ScrollEventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            int N = e.NewValue - e.OldValue;
            num.Value = num.Value + N*50;
        }

        private void radGenPercent_CheckedChanged(object sender, EventArgs e)
        {
            if ( radGenPercent.Checked)
            {
                radGenCount.Checked = false;
                numBeautyPercent.Enabled = true;
                numBeautyCount.Enabled = false;
                count = (uint)(numBeautyPercent.Value * numPopulationSize.Value / 100);
            }
            else
            {
                radGenCount.Checked = true;
                numBeautyPercent.Enabled = false ;
                numBeautyCount.Enabled = true;
                count = (uint)(numBeautyCount.Value);
            }
            lblCount.Text = "Особей: " + count + " / " + numPopulationSize.Value;
            genBeauty.Value = (int)((double)count / (double)numPopulationSize.Value * 100);
            lblBeautyPercent.Text = genBeauty.Value.ToString() + "%";
        }

        private void num_ValueChanged(object sender, EventArgs e)
        {

            if (radGenPercent.Checked)
            {
                count = (uint)(numBeautyPercent.Value * numPopulationSize.Value / 100);
            }
            else
            {
                if (numBeautyCount.Value >= numPopulationSize.Value) numBeautyCount.Value = numPopulationSize.Value-1;
                
                count = (uint)(numBeautyCount.Value);
            }
            lblCount.Text = "Особей: " + count + " / " + numPopulationSize.Value;
            genBeauty.Value = (int)((double)count / (double)numPopulationSize.Value * 100);
            lblBeautyPercent.Text = genBeauty.Value.ToString() + "%";
        }
    }
}