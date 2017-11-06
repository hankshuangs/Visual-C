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
namespace DirectoryGetFiles_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListFiles_Click(object sender, EventArgs e)
        {
            string DirPath = Application.StartupPath;
            string msg = "", fileName = "";

            if (Directory.Exists(DirPath))
            {
                msg = msg + "目錄:[" + DirPath + "]有找到!\n";
                msg = msg + "檔案清單如下:\n";

                var files = Directory.GetFiles(DirPath);

                foreach (var obj in files)
                {
                    fileName = obj.Substring(obj.LastIndexOf("\\") + 1);
                    msg = msg + fileName + "\n";
                }
                MessageBox.Show(msg, "Directory.GetFiles()方法");
                rtxtListFiles.Text = msg;
            }
            else
            {
                msg = msg + "目錄:[" + DirPath + "]不存在!\n";
                msg = msg + "沒有任何檔案!!";
                MessageBox.Show(msg, "Directory.GetFiles()方法");
            }
        }
    }
}
