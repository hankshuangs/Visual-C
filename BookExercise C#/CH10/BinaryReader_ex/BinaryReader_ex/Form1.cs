using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//新增此命名空間
namespace BinaryReader_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
             string msg = "";
            string filePath = Application.StartupPath + @"\News.txt";

            try
            {
                FileStream fs = new FileStream(filePath, FileMode.Open);
                if (File.Exists(filePath))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {

                        string result = br.ReadString();
                        msg = "";
                        long size = br.BaseStream.Length;

                        msg = msg + "檔案位置:" + filePath + "\n";
                        msg = msg + "檔案大小:" + size + " bytes";

                        MessageBox.Show(msg, "BinaryReader");
                        br.Close();
                        rtxtContent.Text = result;
                    }
                    fs.Close();
                }
                else
                {
                    MessageBox.Show("[" + filePath + "]不存在.", "讀取失敗");
                }
            }
            catch (IOException ex)
            {

                MessageBox.Show("錯誤訊息:" + ex.Message, "IOException例外");
            }
            
        }
    }
}
