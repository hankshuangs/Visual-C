using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selecting_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int[] nums = { 3, 6, 2, 4, 0, 1, 5 };
            string[] weeks = { "星期日" , "星期一", "星期二", "星期三", 
                                 "星期四", "星期五", "星期六"};

            var weekNums = from n in nums
                           select weeks[n];

            string result = "轉換的選取結果:\n";
            foreach (var obj in weekNums)
            {
                result = result + obj + "\n";
            }
            MessageBox.Show(result, "選取運算子");
        }
    }
}
