using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grouping_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string[] names = { "Ryu", "Kevin" , "May", "Maggie", "Candy", 
                              "James" , "Karen" , "Kenny" , "Punkey" , "Leo", "Ken" };

            var nameGroupQuery = from name in names
                                 group name by name.Length;

            string result = "根據英文名字長度來進行分組:\n";
            foreach (var g in nameGroupQuery)
            {
                foreach (var name in g)
                {
                    result = result + name + ",";
                }
                result = result + "\n";
            }

            MessageBox.Show(result, "群組運算子");
        }
    }
}
