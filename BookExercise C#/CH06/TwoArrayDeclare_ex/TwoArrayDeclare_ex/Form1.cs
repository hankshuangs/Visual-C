using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoArrayDeclare_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string msg = "博碩集團員工資料如下:\n";

            string[,] employee = new string[2, 3];

            employee[0, 0] = "許清榮";
            employee[0, 1] = "Ryu";
            employee[0, 2] = "資深工程師";
            employee[1, 0] = "江世華";
            employee[1, 1] = "Candy";
            employee[1, 2] = "研發工程師";

            int Rank = employee.Rank;
            for (int i = 0; i < Rank; i++)
            {
                for (int j = 0; j < employee.GetLength(Rank - 1); j++)
                {
                    msg = msg + employee[i, j] + "\t";
                }
                msg = msg + "\n";
            }

            MessageBox.Show(msg, "二維陣列宣告");
        }
    }
}
