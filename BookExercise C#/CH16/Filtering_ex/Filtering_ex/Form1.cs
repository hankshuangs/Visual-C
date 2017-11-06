using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filtering_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string[] names = { "Ryu" , "Kevin", "Maggie", "Candy", "James" ,
                               "Karen" , "Kenny" , "Punkey" ,"Kewin", "Leo", "Ken" };

            var nameQuery = from name in names
                            where name.IndexOf("Ke") != -1
                            select name;
            string result = "英文名字開頭為'Ke'的有:\n";
            foreach (var obj in nameQuery)
            {
                result = result + obj + "\n";
            }
            MessageBox.Show(result, "篩選運算子");
        }
    }
}
