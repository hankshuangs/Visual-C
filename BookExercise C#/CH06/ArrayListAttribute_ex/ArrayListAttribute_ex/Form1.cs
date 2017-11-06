using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayListAttribute_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapacity_Click(object sender, EventArgs e)
        {
            System.Collections.ArrayList employee =
        new System.Collections.ArrayList();

            employee.Insert(0, "許清榮");
            employee.Insert(1, "吳宜隆");
            employee.Insert(2, "林建亨");
            employee.Insert(3, "買大誠");
            employee.Insert(4, "廖健宇");

            int nums = employee.Capacity;

            string msg = "employee能夠包含陣列元素容量數:" + nums;
            MessageBox.Show(msg, "Capacity屬性");
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            System.Collections.ArrayList employee =
               new System.Collections.ArrayList();

            employee.Insert(0, "許清榮");
            employee.Insert(1, "吳宜隆");
            employee.Insert(2, "林建亨");
            employee.Insert(3, "買大誠");
            employee.Insert(4, "廖健宇");

            int nums = employee.Count;

            string msg = "employee實際陣列元素個數:" + nums;
            MessageBox.Show(msg, "Count屬性");
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            System.Collections.ArrayList employee =
        new System.Collections.ArrayList();

            employee.Insert(0, "許清榮");
            employee.Insert(1, "吳宜隆");
            employee.Insert(2, "林建亨");
            employee.Insert(3, "買大誠");
            employee.Insert(4, "廖健宇");

            var item = employee[2];

            string msg = "employee陣列第三個元素:" + item;
            MessageBox.Show(msg, "Item屬性");
        }
    }
}
