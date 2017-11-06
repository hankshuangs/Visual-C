using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayMethod_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCopyTo_Click(object sender, EventArgs e)
        {
            string[] fruit = { "banana", "apple", "strawberry" };
            string[] newFruit = new string[3];

            fruit.CopyTo(newFruit, 0);

            string msg = "陣列第二元素水果為:" + newFruit[1];
            MessageBox.Show(msg, "CopyTo()方法");
        }

        private void btnGetLength_Click(object sender, EventArgs e)
        {
            string[] fruit = { "banana", "apple", "strawberry" };

            int len = fruit.GetLength(0);

            string msg = "fruit陣列長度為:" + len;
            MessageBox.Show(msg, "GetLength()方法");
        }

        private void btnGetLowerBound_Click(object sender, EventArgs e)
        {
            string[] fruit = { "banana", "apple", "strawberry" };

            int lowBound = fruit.GetLowerBound(0);

            string msg = "fruit陣列維度的下限:" + lowBound;
            MessageBox.Show(msg, "GetLowerBound()方法");
        }

        private void btnGetUpperBound_Click(object sender, EventArgs e)
        {
            string[] fruit = { "banana", "apple", "strawberry" };

            int upBound = fruit.GetUpperBound(0);

            string msg = "fruit陣列維度的上限:" + upBound;
            MessageBox.Show(msg, "GetUpperBound()方法");
        }

        private void btnGetValue_Click(object sender, EventArgs e)
        {
            string[] fruit = { "banana", "apple", "strawberry" };

            var element = fruit.GetValue(2);

            string msg = "fruit陣列第三個元素:" + element;
            MessageBox.Show(msg, "GetValue()方法");
        }

        private void btnSetValue_Click(object sender, EventArgs e)
        {
            string[] fruit = { "banana", "apple", "strawberry" };

            fruit.SetValue("lemon", 1);//索引值須在0~2之間

            string element = fruit[1];

            string msg = "fruit陣列第二個元素:" + element;
            MessageBox.Show(msg, "SetValue()方法");
        }
    }
}
