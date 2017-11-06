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
namespace DirectoryMove_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            string sourceDirPath = Application.StartupPath + @"\www";
            string destDirPath = Application.StartupPath + @"\move";
            string msg = "";

            if (Directory.Exists(sourceDirPath))
            {
                msg = msg + "目錄:[" + sourceDirPath + "]有找到!\n";
                msg = msg + "目錄以被移動到:[" + destDirPath + "]!";

                Directory.Move(sourceDirPath, destDirPath);

                MessageBox.Show(msg, "Directory.Move()方法");
            }
            else
            {
                msg = msg + "目錄:[" + destDirPath + "]有找到!\n";
                msg = msg + "目錄以被移動到:[" + sourceDirPath + "]!";

                Directory.Move(destDirPath, sourceDirPath);

                MessageBox.Show(msg, "Directory.Move()方法");
            }
        }
    }
}
