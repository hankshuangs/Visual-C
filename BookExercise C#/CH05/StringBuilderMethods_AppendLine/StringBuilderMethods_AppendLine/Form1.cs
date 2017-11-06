﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringBuilderMethods_AppendLine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string s1 = "I forgot to friend you.";
            string s2 = "That's why I didn't see you right away.";
            StringBuilder SB = new StringBuilder(s1);

            SB.AppendLine();

            SB.Append(s2);
            MessageBox.Show(SB.ToString(), "AppendLine()方法");
        }
    }
}
