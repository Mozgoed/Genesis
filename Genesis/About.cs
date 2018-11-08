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
            collection.Add("Купить молока");//Добавить новый элемент в конец списка
            collection.Add("Продать мотоцикл");
            collection.Add("Починить табуретку");
            collection.Insert(1, "Вставить фото в рамку");//Вставить элемент на 1 место
            collection.RemoveAt(0);//Удалить нулевой элемент
            

            
            foreach (string s in collection)
            {
                txtTasks.Text += (s + "\r\n");
            }
            // ИЛИ
            //collection.ForEach(delegate (string s) { txtTasks.Text += s + "\r\n"; });

        }
    }
}
