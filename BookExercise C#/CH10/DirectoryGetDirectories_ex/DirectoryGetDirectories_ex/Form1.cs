using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //新增此命名空間
namespace DirectoryGetDirectories_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListDirs_Click(object sender, EventArgs e)
        {
            string DirPath = @"C:\";
            string msg = "", dirName = "";

            if (Directory.Exists(DirPath))
            {
                msg = msg + "目錄:[" + DirPath + "]有找到!\n";
                msg = msg + "子目錄清單如下:\n";

                var files = Directory.GetDirectories(DirPath);

                foreach (var obj in files)
                {
                    dirName = obj.Substring(obj.LastIndexOf("\\") + 1);
                    msg = msg + dirName + "\n";
                }
                MessageBox.Show(msg, "Directory.GetDirectories()方法");
                rtxtListDirs.Text = msg;
            }
            else
            {
                msg = msg + "目錄:[" + DirPath + "]不存在!\n";
                msg = msg + "沒有任何子目錄!!";
                MessageBox.Show(msg, "Directory.GetDirectories()方法");
            }
        }
    }
}
