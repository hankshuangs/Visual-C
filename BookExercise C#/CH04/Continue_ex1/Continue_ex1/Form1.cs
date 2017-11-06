using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Continue_ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int[] score = new int[10] { 60, 59, 72, 56, 43, 97, 100, 52 ,88 , 36 };

            string msg = "及格分數如下所示:" + Environment.NewLine;

            for (int i = 0; i < score.Length; i++)
            {
                if (score[i] < 60)
                {
                    continue;
                }

                msg = msg + score[i].ToString() + Environment.NewLine;

            }

            MessageBox.Show(msg, "continue程式範例");
        }
    }
}
