using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayClassMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBinarySearch_Click(object sender, EventArgs e)
        {
            string[] fruit = { "banana", "apple", "strawberry" };
            string key = "strawberry";

            int index = Array.BinarySearch(fruit, key);

            string msg = "fruit陣列內容值為:" + key + "\n";
            msg = msg + "其陣列索引值為:" + index;
            MessageBox.Show(msg, "Array.BinarySearch()方法");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            string[] fruit = { "banana", "apple", "strawberry" };

            Array.Clear(fruit, 1, 1);

            string msg = "fruit陣列內容值為:\n";
            foreach (var obj in fruit)
            {
                msg = msg + obj + "\n";
            }
            MessageBox.Show(msg, "Array.Clear()方法");
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            string[] fruit = { "banana", "apple", "strawberry" };
            int newSize = fruit.Length + 1;

            Array.Resize(ref fruit, newSize);

            fruit[3] = "lemon";
            string msg = "fruit陣列內容值為:\n";
            foreach (var obj in fruit)
            {
                msg = msg + obj + "\n";
            }
            MessageBox.Show(msg, "Array.Resize()方法");
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            string[] fruit = { "banana", "apple", "strawberry" };

            Array.Reverse(fruit);

            string msg = "fruit陣列內容值為:\n";
            foreach (var obj in fruit)
            {
                msg = msg + obj + "\n";
            }
            MessageBox.Show(msg, "Array.Reverse()方法");
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string[] fruit = { "banana", "apple", "strawberry" };

            Array.Sort<string>(fruit);

            string msg = "fruit陣列內容值為:\n";
            foreach (var obj in fruit)
            {
                msg = msg + obj + "\n";
            }
            MessageBox.Show(msg, "Array.Sort()方法");
        }
    }
}
