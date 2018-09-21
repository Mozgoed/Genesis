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
                genBeauty.Value = (int) (count / population.Length * 100);
            Application.DoEvents();
        }

        bool[] population = new bool[10];

        private void btnStart_Click(object sender, EventArgs e)
        {
            countBirds();
            MessageBox.Show("Создан массив особей без гена красоты");
            for (int bird = 0; bird < population.Length/2; bird++)
            {
                population[bird] = true;
            }
            countBirds();
            MessageBox.Show("Заполнена половина популяции особей с геном красоты");

            MessageBox.Show("Эмуляция завершена");
        }
    }
}
