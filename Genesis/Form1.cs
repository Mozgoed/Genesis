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

        private void btnStart_Click(object sender, EventArgs e)
        {
            int populationSize = (int)numPopulationSize.Value;
            population = new bool[populationSize];
            countBirds();
            MessageBox.Show("Создан массив особей без гена красоты");
            for (int bird = 0; bird < population.Length / 2; bird++)
            {
                population[bird] = true;
            }
            countBirds();
            MessageBox.Show("Заполнена половина популяции особей с геном красоты");

            //Размножение
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
                    if (byteGeneration[child] == 0)
                    {
                        if (percent > 70)
                        {
                            byteGeneration[child] = 255;
                            count--;
                        }
                    }
                    if (byteGeneration[child] == 1)
                    {
                        if (percent > 70 + 10)
                        {
                            byteGeneration[child] = 255;
                            count--;
                        }
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

            MessageBox.Show("Эмуляция завершена");
        }
    }
}