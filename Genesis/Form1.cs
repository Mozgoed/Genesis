using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
        void countBirds(int step, bool parallel)
        {
            count = 0;
            if (parallel)
            {
                long c = 0;
                Parallel.For<long>(0, population.Length, () => 0, (j, loop, subtotal) =>
                {
                    if (population[j]) subtotal++;
                    return subtotal;
                },
                (x) => Interlocked.Add(ref c, x)
                );
                count = (uint)c;
            }
            else
                for (int bird = 0; bird < population.Length; bird++)
                {
                    if (population[bird] == true)
                        count++;
                }

            if (delay)
            {
                if (count == 0)
                    genBeauty.Value = 0;
                else
                    genBeauty.Value = (int)((double)count / population.Length * 100);

                lblBeautyPercent.Text = genBeauty.Value.ToString() + "%";
                lblCount.Text = "Особей: " + count + " / " + numPopulationSize.Value;
                lblStep.Text = "Поколение: " + step;
                TaskbarProgress.SetValue(System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle, count, (int)numPopulationSize.Value);
                Application.DoEvents();
            }
        }

        bool stop = false;
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Остановить")
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
            Application.DoEvents();
            decimal BeautyPercent;
            if (radGenPercent.Checked)
            {
                BeautyPercent = numBeautyPercent.Value / 100;
            }
            else
            {
                BeautyPercent = numBeautyCount.Value / (uint)numPopulationSize.Value;
            }
            int result = Emulation((uint)numPopulationSize.Value, BeautyPercent, (int)numChildrenNumber.Value, (byte)numPopulationSurvival.Value, (byte)numPopulationBonusSurvival.Value);

            TaskbarProgress.SetState(System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle, TaskbarProgress.TaskbarStates.Indeterminate);
            if (result > 0)
                txtLog.Text += "\r\nРезультат: Ген победил. ";
            if (result < 0)
                txtLog.Text += "\r\nРезультат: Ген проиграл. ";
            txtLog.Text += "Поколение: " + step;

            MessageBox.Show("Эмуляция завершена");
            TaskbarProgress.SetState(System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle, TaskbarProgress.TaskbarStates.NoProgress);

            LockControls(false);
        }

        int step = 0;
        bool[] population;
        private int Emulation(uint populationSize, decimal beautyPercent, int childrenNumber, byte populationSurvival, byte populationBonus)
        {
            population = new bool[populationSize];


            for (int bird = 0; bird < populationSize * beautyPercent; bird++)
            {
                population[bird] = true;
            }
            countBirds(0, true);
            step = 0;
            while (count < populationSize && count > 0)
            {
                //Проверка, что кто-то останавливает эмуляцию
                if (stop)
                {
                    btnStart.Text = "Пуск эмуляции";
                    TaskbarProgress.SetState(System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle, TaskbarProgress.TaskbarStates.Normal);
                    stop = false;
                    return 0;
                }

                //Размножение
                byte[] byteGeneration = new byte[populationSize * (childrenNumber + 1)];
                int child = 0;
                for (int bird = 0; bird < populationSize; bird++)
                {
                    for (int i = 0; i < (childrenNumber + 1); i++)
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
                        if (byteGeneration[child] == 0 && percent > populationSurvival)
                        {
                            byteGeneration[child] = 255;
                            count2Kill--;
                        }
                        if (byteGeneration[child] == 1 && percent > populationSurvival + populationBonus)
                        {
                            byteGeneration[child] = 255;
                            count2Kill--;
                        }
                        if (count2Kill == 0) break;
                    }

                //Перенос выживших особей из большого массива в стандартный
                uint count = 0;
                for (child = 0; child < byteGeneration.Length; child++)
                {
                    if (byteGeneration[child] == 0) { population[count++] = false; }
                    if (byteGeneration[child] == 1) { population[count++] = true; }
                }

                countBirds(++step, true);

                if (delay) System.Threading.Thread.Sleep((int)numDelay.Value);
            }
            if (count == 0) return -1 * step;
            else return step;
        }

        void LockControls(bool isLocked)
        {
            if (isLocked)
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

        private void num_Scroll(object sender, ScrollEventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            int N = e.NewValue - e.OldValue;
            num.Value = num.Value + N * 50;
        }

        private void radGenPercent_CheckedChanged(object sender, EventArgs e)
        {
            if (radGenPercent.Checked)
            {
                radGenCount.Checked = false;
                numBeautyPercent.Enabled = true;
                numBeautyCount.Enabled = false;
                count = (uint)(numBeautyPercent.Value * numPopulationSize.Value / 100);
            }
            else
            {
                radGenCount.Checked = true;
                numBeautyPercent.Enabled = false;
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
                if (numBeautyCount.Value >= numPopulationSize.Value) numBeautyCount.Value = numPopulationSize.Value - 1;

                count = (uint)(numBeautyCount.Value);
            }
            lblCount.Text = "Особей: " + count + " / " + numPopulationSize.Value;
            genBeauty.Value = (int)((double)count / (double)numPopulationSize.Value * 100);
            lblBeautyPercent.Text = genBeauty.Value.ToString() + "%";
        }

        private void btnPackageEmulation_Click(object sender, EventArgs e)
        {
            LockControls(true);
            txtLog.Text += "\r\n";
            txtLog.Text += "Пакетная эмуляция";
            txtLog.Text += string.Format("\r\nБаза = {0}, Бонус = {1}, Потомки = {2}", numPopulationSurvival.Value, numPopulationBonusSurvival.Value, numChildrenNumber.Value);
            Application.DoEvents();
            int winCount = 0;
            double winAverageSteps = 0;
            double failAverageSteps = 0;
            for (double percent = 0.01; percent <= 1; percent+=0.01)
            {
                numBeautyPercent.Value = (decimal)percent;
                for (double bonus = 0.1; bonus <= 2; bonus += 0.1)
                {
                    numPopulationBonusSurvival.Value = (decimal)bonus;
                    for (int turn = 0; turn < 1000; turn++)
                    {
                        decimal BeautyPercent;
                        if (radGenPercent.Checked)
                        {
                            BeautyPercent = numBeautyPercent.Value / 100;
                        }
                        else
                        {
                            BeautyPercent = numBeautyCount.Value / (uint)numPopulationSize.Value;
                        }
                        int result = Emulation((uint)numPopulationSize.Value, BeautyPercent, (int)numChildrenNumber.Value, (byte)numPopulationSurvival.Value, (byte)numPopulationBonusSurvival.Value);
                        //txtLog.Text += "\r\n" + result;
                        if (result > 0)
                        {
                            winCount++;
                            winAverageSteps += result;
                        }
                        if (result < 0)
                        {
                            failAverageSteps += result;
                        }
                        TaskbarProgress.SetValue(System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle, turn, 1000);
                        Application.DoEvents();
                    }
                    string text = numPopulationSize.Value.ToString() + ";";
                    decimal BeautyPercenT = radGenPercent.Checked ? numBeautyPercent.Value / 100 : numBeautyCount.Value / (uint)numPopulationSize.Value;
                    text += BeautyPercenT.ToString() + ";" + numChildrenNumber.Value + ";" + numPopulationSurvival.Value + ";" + numPopulationBonusSurvival.Value + ";";
                    text += (winCount / 10.0).ToString("F1") + ";";
                    if (winCount == 0) text += "0;";
                    else text += (winAverageSteps / (double)winCount).ToString("F0") + ";";
                    if (winCount == 1000) text += "0;";
                    else text += (failAverageSteps / (double)(1000 - winCount)).ToString("F0") + ";";
                    System.IO.File.AppendAllText("results.txt", text + "\r\n");


                    Application.DoEvents();
                }
            }
            LockControls(false);
        }

        bool delay = true;
        private void numDelay_ValueChanged(object sender, EventArgs e)
        {
            delay = numDelay.Value > 0;
        }
    }
}