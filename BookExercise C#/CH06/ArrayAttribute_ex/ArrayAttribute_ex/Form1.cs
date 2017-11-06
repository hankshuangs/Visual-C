using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayAttribute_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLength_Click(object sender, EventArgs e)
        {
            string[,] student = { {"Ryu","178cm","68kg"} ,
                                  {"Candy","162cm","48kg"}};

            int len = student.Length;

            string msg = "student陣列元素總數:" + len;
            MessageBox.Show(msg, "Length屬性");
        }

        private void btnRank_Click(object sender, EventArgs e)
        {
            int[, , ,] array4D = new int[2, 3, 4, 5];

            int rank = array4D.Rank;

            string msg = "array4D陣列維度為:" + rank;
            MessageBox.Show(msg, "Rank屬性");
        }
    }
}
