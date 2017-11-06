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
namespace DirectoryDelete_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string delDirPath = Application.StartupPath + @"\www";
            string createDirPath = delDirPath + @"\drMaster\com\tw";
            string msg = "";

            if (Directory.Exists(delDirPath))
            {
                msg = msg + "目錄:[" + delDirPath + "]有找到!\n";
                msg = msg + "執行刪除目錄和子目錄動作!";

                Directory.Delete(delDirPath, true);

                MessageBox.Show(msg, "Directory.Delete()方法");
            }
            else
            {
                msg = msg + "找不到刪除目錄:[" + delDirPath + "]!\n";
                msg = msg + "執行目錄建立動作!!";
                Directory.CreateDirectory(createDirPath);
                MessageBox.Show(msg, "Directory.CreateDirectory()方法");
            }
        }
    }
}
