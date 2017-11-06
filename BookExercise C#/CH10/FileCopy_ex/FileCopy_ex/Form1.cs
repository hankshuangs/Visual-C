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
namespace FileCopy_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            string oldFileName = Application.StartupPath + @"\Hadoop.jpg";
            string newFileName = Application.StartupPath + @"\Hadoop2.jpg";
            string msg = "";

            if (File.Exists(oldFileName))
            {
                msg = msg + "檔案:[" + oldFileName + "]有找到!\n";
                msg = msg + "檔案已被拷貝到:[" + newFileName + "]!";

                File.Copy(oldFileName, newFileName, true);

                MessageBox.Show(msg, "File.Copy()方法");
            }
            else
            {
                msg = msg + "檔案:[" + oldFileName + "]沒有找到!\n";
                MessageBox.Show(msg, "File.Copy()方法");
            }
        }
    }
}
