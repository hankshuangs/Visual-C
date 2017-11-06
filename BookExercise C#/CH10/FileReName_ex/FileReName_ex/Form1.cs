﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //新增此命名空間
namespace FileReName_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReName_Click(object sender, EventArgs e)
        {
            string oldFileName = Application.StartupPath + @"\Java.jpg";
            string newFileName = Application.StartupPath + @"\SCJP.jpg";
            string msg = "";

            if (File.Exists(oldFileName))
            {
                msg = msg + "檔案:[" + oldFileName + "]有找到!\n";
                msg = msg + "檔名已被更改為:[" + newFileName + "]!";

                File.Move(oldFileName, newFileName);

                MessageBox.Show(msg, "File.Move()方法");
            }
            else
            {
                msg = msg + "檔案:[" + newFileName + "]有找到!\n";
                msg = msg + "檔名已被更改為:[" + oldFileName + "]!";

                File.Move(newFileName, oldFileName);

                MessageBox.Show(msg, "File.Move()方法");
            }
        }
    }
}
