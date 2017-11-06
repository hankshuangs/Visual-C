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
namespace StreamReader_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private  async void btnRead_Click(object sender, EventArgs e)
        {
            string msg = "";
            string filePath = Application.StartupPath + @"\MyBooks.txt";

            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader sr = new
                        StreamReader(filePath, Encoding.Default))
                    {

                        long size = sr.BaseStream.Length;
                        int countLine = 0;
                        string result = "";

                        //亦可用while(sr.Peek() != -1)來判斷
                        while (sr.EndOfStream != true)
                        {
                            result = result + await sr.ReadLineAsync() + "\n";
                            countLine = countLine + 1;
                        }

                        msg = msg + "檔案位置:" + filePath + "\n";
                        msg = msg + "檔案大小:" + size + " bytes \n";
                        msg = msg + "檔案行數:" + countLine + " 行";
                        MessageBox.Show(msg, "StreamReader");
                        sr.Close();
                        rtxtContent.Text = result;
                    }

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
