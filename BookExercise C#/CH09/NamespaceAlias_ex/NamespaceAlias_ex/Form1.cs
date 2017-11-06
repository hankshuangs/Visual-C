using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysIO = System.IO; //別名命名空間使用

namespace NamespaceAlias_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExists_Click(object sender, EventArgs e)
        {
            string FilePath = Application.StartupPath +
              @"\NamespaceAlias_ex.exe";
            if (SysIO.File.Exists(FilePath))
            {
                MessageBox.Show("[" + FilePath + "]程式執行檔存在.");
            }
            else
            {
                MessageBox.Show("[" + FilePath + "]程式執行檔不存在.");
            }
        }
    }
}
