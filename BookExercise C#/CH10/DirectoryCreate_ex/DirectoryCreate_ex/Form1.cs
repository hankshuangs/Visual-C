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
namespace DirectoryCreate_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string dirPath = Application.StartupPath + @"\www\drMaster\com\tw";
            string msg = "";

            if (Directory.Exists(dirPath))
            {
                msg = msg + "目錄:[" + dirPath + "]有找到!\n";
                msg = msg + "不執行建立目錄動作!";
                MessageBox.Show(msg, "Directory.CreateDirectory()方法");
            }
            else
            {
                msg = msg + "建立目錄:[" + dirPath + "]!\n";
                msg = msg + "完成目錄建立!!";

                Directory.CreateDirectory(dirPath);

                MessageBox.Show(msg, "Directory.CreateDirectory()方法");
            }
        }
    }
}
