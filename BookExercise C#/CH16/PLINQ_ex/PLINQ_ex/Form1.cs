using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLINQ_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            var files = System.IO.Directory.GetFiles(@"C:\Windows\System32");

            var exefiles = from file in files.AsParallel()
                           where file.IndexOf("exe") != -1 && getFileName(file).Length >= 25
                           select getFileName(file);

            int i = 0;
            string msg = "找尋EXE檔案結果如下：\n";
            Parallel.ForEach(exefiles, new ParallelOptions { MaxDegreeOfParallelism = 4 }, (file) =>
            {
                i = i + 1;
                msg = msg + i.ToString() + ". " + file + "\n";
            });

            MessageBox.Show(msg + "共找到" + i.ToString() + "個檔案。" ,"平行LINQ");
        }

        public string getFileName(string file)
        {
            int index = file.LastIndexOf("\\");
            return file.Substring(index + 1);
        }
    }
}
