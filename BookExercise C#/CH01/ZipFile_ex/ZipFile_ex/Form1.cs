using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression; //Add System.IO.Compression.FileSystem.dll to reference
namespace ZipFile_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            string readPath = Application.StartupPath + @"\filesource";
            string generateCompressfile = Application.StartupPath + "compress.zip";
            try
            {
                ZipFile.CreateFromDirectory(readPath, generateCompressfile, CompressionLevel.Optimal, true);
                MessageBox.Show("檔案壓縮完成，路徑:" + generateCompressfile, "資訊");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "發生例外");
            }
            
        }

        private void btnDecompress_Click(object sender, EventArgs e)
        {
            string generateCompressfile = Application.StartupPath + "compress.zip";
            string extractPath = Application.StartupPath + @"\output";
            try
            {
                ZipFile.ExtractToDirectory(generateCompressfile, extractPath);
                MessageBox.Show("檔案解壓縮完成，路徑:" + extractPath, "資訊");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "發生例外");
            }
            
        }


    }
}
