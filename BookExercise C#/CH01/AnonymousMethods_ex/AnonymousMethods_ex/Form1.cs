﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnonymousMethods_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        delegate void ShowMessage(string msg);
        private void btnRun_Click(object sender, EventArgs e)
        {
            ShowMessage ShowMsg = delegate(string msg)
            {
                MessageBox.Show(msg, "委派技巧");
            };
            ShowMsg("不用額外實作要傳遞的方法參數(匿名方法)");
        }
    }
}