using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;//新增命名空間
namespace Process_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Process myProcess = new Process();
        private void tSB_IE_Click(object sender, EventArgs e)
        {
            myProcess = Process.Start("IExplore.exe", "www.yuntech.edu.tw");
        }

        private void tSB_Notepad_Click(object sender, EventArgs e)
        {
            string filePath = Application.StartupPath + @"\default.htm";

            ProcessStartInfo psi = new
                ProcessStartInfo("NotePad.exe", filePath);
            myProcess.StartInfo = psi;
            myProcess.Start();
        }

        private void tSB_RAR_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = Application.StartupPath + @"\images.rar";
            psi.UseShellExecute = true;
            myProcess.StartInfo = psi;
            myProcess.Start();
        }
    }
}
