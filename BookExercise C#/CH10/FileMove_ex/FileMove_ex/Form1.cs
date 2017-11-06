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
namespace FileMove_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            string oldFileName = Application.StartupPath + @"\Hadoop.jpg";
            string newFileName = Application.StartupPath + @"\Move\Hadoop.jpg";
            string msg = "";

            if (File.Exists(oldFileName))
            {
                msg = msg + "檔案:[" + oldFileName + "]有找到!\n";
                msg = msg + "檔案已被移動到:[" + newFileName + "]!";

                File.Move(oldFileName, newFileName);

                MessageBox.Show(msg, "File.Move()方法");
            }
            else
            {
                msg = msg + "檔案:[" + newFileName + "]有找到!\n";
                msg = msg + "檔案已被移動到:[" + oldFileName + "]!";

                File.Move(newFileName, oldFileName);

                MessageBox.Show(msg, "File.Move()方法");
            }
        }
    }
}
