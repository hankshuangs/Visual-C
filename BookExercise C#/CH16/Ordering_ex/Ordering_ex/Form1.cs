using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordering_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string[] names = { "Ryu" , "Kevin" , "May", "Maggie", "Candy", "James" ,
                               "Karen" , "Kenny" , "Punkey" , "Leo", "Ken" };

            var nameQuery = from name in names
                            where name.Length == 3
                            orderby name
                            select name;
            string result = "英文名字長度等於3的排序結果:\n";
            foreach (var obj in nameQuery)
            {
                result = result + obj + "\n";
            }
            MessageBox.Show(result, "排序運算子");
        }
    }
}
