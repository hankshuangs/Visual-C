using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayListMethod_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            System.Collections.ArrayList student =
    new System.Collections.ArrayList();

            student.Add("Ryu");
            student.Add("Candy");

            string msg = "共新增" + student.Count + "個元素";
            MessageBox.Show(msg, "Add()方法");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            System.Collections.ArrayList student =
         new System.Collections.ArrayList();
            student.Add("Ryu");
            student.Add("Candy");

            student.Clear();

            string msg = "目前陣列清單共有" + student.Count + "個元素";
            MessageBox.Show(msg, "Clear()方法");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            System.Collections.ArrayList student =
      new System.Collections.ArrayList();
            student.Add("Ryu");

            student.Insert(1, "Candy");

            student.Add("Ven");

            student.Insert(0, "Karen");

            string msg = "陣列清單內容:\n";
            for (int i = 0; i < student.Count; i++)
            {
                msg = msg + student[i] + "\n";
            }
            MessageBox.Show(msg, "Insert()方法");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            System.Collections.ArrayList student =
    new System.Collections.ArrayList();
            student.Add("Ryu");
            student.Add("Karen");
            student.Add("Candy");

            student.Remove("Karen");

            string msg = "陣列清單內容:\n";
            for (int i = 0; i < student.Count; i++)
            {
                msg = msg + student[i] + "\n";
            }
            MessageBox.Show(msg, "Remove()方法");
        }

        private void btnRemoveAt_Click(object sender, EventArgs e)
        {
            System.Collections.ArrayList student =
      new System.Collections.ArrayList();
            student.Add("Ryu");
            student.Add("Ven");
            student.Add("Becky");
            student.Add("Candy");

            student.RemoveAt(1);
            student.RemoveAt(1);

            string msg = "陣列清單內容:\n";
            for (int i = 0; i < student.Count; i++)
            {
                msg = msg + student[i] + "\n";
            }
            MessageBox.Show(msg, "RemoveAt()方法");
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            System.Collections.ArrayList student =
      new System.Collections.ArrayList();
            student.Add("Ryu");
            student.Add("Ven");
            student.Add("Becky");
            student.Add("Candy");

            student.Reverse();

            string msg = "陣列清單內容:\n";
            for (int i = 0; i < student.Count; i++)
            {
                msg = msg + student[i] + "\n";
            }
            MessageBox.Show(msg, "Reverse()方法");
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            System.Collections.ArrayList student =
      new System.Collections.ArrayList();
            student.Add("Ryu");
            student.Add("Ven");
            student.Add("Becky");
            student.Add("Candy");

            student.Sort();

            string msg = "陣列清單內容:\n";
            for (int i = 0; i < student.Count; i++)
            {
                msg = msg + student[i] + "\n";
            }
            MessageBox.Show(msg, "Sort()方法");
        }

        private void btnTrimToSize_Click(object sender, EventArgs e)
        {
            System.Collections.ArrayList student =
   new System.Collections.ArrayList();
            student.Add("Ryu");
            student.Add("Candy");
            int oldCapacity = student.Capacity;

            student.TrimToSize();

            int newCapacity = student.Capacity;

            string msg = "調整前陣列元素可容納:" + oldCapacity + "個\n";
            msg = msg + "調整後陣列元素可容納:" + newCapacity + "個\n";
            msg = msg + "目前Capacity和Count的內容值是相等";
            MessageBox.Show(msg, "TrimToSize()方法");
        }
    }
}
