﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringMethods_ToLower
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string s1 = "C# IS THE BEST PROCEDURE LANGUAGE.";

            string s2 = s1.ToLower();

            string msg = "轉換小寫前:" + s1 + "\n";
            msg = msg + "轉換小寫後:" + s2;
            MessageBox.Show(msg, "ToLower()方法");
        }
    }
}
