using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//new
using System.IO.Compression; //new

namespace GZipStream_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            string data = rtxtData.Text;
            string compressfile = Application.StartupPath + @"\compressfile.zip";

            GZipStream outStream = new GZipStream(File.OpenWrite(compressfile), CompressionMode.Compress);
            
            StreamWriter sw = new StreamWriter(outStream);
            sw.Write(data);
            sw.Close();

            MessageBox.Show("檔案壓縮完成，路徑:" + compressfile, "資訊");
            rtxtData.Text = "";
        }

        private void btnDecompress_Click(object sender, EventArgs e)
        {
            string ReadData = "";
            string compressfile = Application.StartupPath + @"\compressfile.zip";

            GZipStream instream = new GZipStream(File.OpenRead(compressfile), CompressionMode.Decompress);

            StreamReader reader = new StreamReader(instream);

            ReadData = reader.ReadToEnd();
            reader.Close();
            rtxtData.Text = ReadData;
            MessageBox.Show("檔案解壓縮成功!!", "資訊");
        }
    }
}
