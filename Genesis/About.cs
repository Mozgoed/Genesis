using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Genesis
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        List<string> collection = new List<string>();

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //collection.Add("Купить молока");//Добавить новый элемент в конец списка
            //collection.Add("Продать мотоцикл");
            //collection.Add("Починить табуретку");
            //collection.Insert(1, "Вставить фото в рамку");//Вставить элемент на 1 место
            //collection.RemoveAt(0);//Удалить нулевой элемент
            txtTasks.Text = "";

            
            foreach (string s in collection)
            {
                txtTasks.Text += (s + "\r\n");
            }
            // ИЛИ
            //collection.ForEach(delegate (string s) { txtTasks.Text += s + "\r\n"; });

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            collection.Add(txtAdd.Text);
            txtAdd.Text = "";
            txtTasks.Text = "" ;
            foreach (string s in collection)
            {
                txtTasks.Text += (s + "\r\n");
            }
            txtAdd.Focus();
        }

        private void btnDeleteX_Click(object sender, EventArgs e)
        {
            collection.RemoveAt((int)numDelete.Value);
            txtTasks.Text = "";
            foreach (string s in collection)
            {
                txtTasks.Text += (s + "\r\n");
            }
        }

        private void btnAddX_Click(object sender, EventArgs e)
        {
            collection.Insert((int)numX.Value, txtAddX.Text);
            txtTasks.Text = "";
            foreach (string s in collection)
            {
                txtTasks.Text += (s + "\r\n");
            }
            txtAddX.Focus();
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            string A = collection[(int)numA.Value];
            collection[(int)numA.Value] = collection[(int)numB.Value];
            collection[(int)numB.Value] = A;
            txtTasks.Text = "";
            foreach (string s in collection)
            {
                txtTasks.Text += (s + "\r\n");
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            collection.Sort();
            txtTasks.Text = "";
            foreach (string s in collection)
            {
                txtTasks.Text += (s + "\r\n");
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            collection.Reverse();
            txtTasks.Text = "";
            foreach (string s in collection)
            {
                txtTasks.Text += (s + "\r\n");
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            collection.Clear();
            txtTasks.Text = "";
            foreach (string s in collection)
            {
                txtTasks.Text += (s + "\r\n");
            }
        }

        private void btnReversSort_Click(object sender, EventArgs e)
        {
            collection.Sort();
            collection.Reverse();
            txtTasks.Text = "";
            foreach (string s in collection)
            {
                txtTasks.Text += (s + "\r\n");
            }
        }
    }
}
