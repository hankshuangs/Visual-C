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
namespace FileDelete_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string filePath = Application.StartupPath + @"\MyVN900.jpg";
            string msg = "";

            if (File.Exists(filePath))
            {
                msg = msg + "檔案:[" + filePath + "]有找到!\n";
                msg = msg + "檔案:[" + filePath + "]已被刪除!";

                File.Delete(filePath);

                MessageBox.Show(msg, "File.Delete()方法");
            }
            else
            {
                msg = msg + "檔案:[" + filePath + "]不存在!";
                MessageBox.Show(msg, "File.Delete()方法");
            }
        }
    }
}
