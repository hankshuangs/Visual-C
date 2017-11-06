using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//新增命名空間
namespace BinaryWriter_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            string msg = "";
            string fileName1 = Application.StartupPath + @"\Ryu.bmp";
            string fileName2 = Application.StartupPath + @"\RyuCopy.bmp";

            byte[] bufByte = null;

            try
            {
                using (FileStream fs1 = new FileStream(fileName1, FileMode.Open))
                {
                    if (File.Exists(fileName1))
                    {
                        using (BinaryReader br = new BinaryReader(fs1))
                        {

                            long size = br.BaseStream.Length;
                            bufByte = new byte[size];
                            bufByte = br.ReadBytes((int)size);

                            msg = msg + "原始檔案位置:" + fileName1 + "\n";
                            msg = msg + "原始檔案大小:" + size + " bytes\n";

                            br.Close();
                        }
                        fs1.Close();
                    }
                    else
                    {
                        MessageBox.Show("[" + fileName1 + "]不存在.", "讀取失敗");
                    }
                }
                using (FileStream fs2 = new FileStream(fileName2, FileMode.Create))
                {
                    using (BinaryWriter bw = new BinaryWriter(fs2))
                    {

                        bw.Write(bufByte);
                        bw.Flush();

                        long newSize = bw.BaseStream.Length;

                        bw.Close();
                        msg = msg + "新檔案位置:" + fileName2 + "\n";
                        msg = msg + "新檔案大小:" + newSize + " bytes\n";
                        msg = msg + "二位進檔案複製完成^.^";
                        MessageBox.Show(msg, "BinaryWriter");

                    }
                    fs2.Close();
                }


            }
            catch (IOException ex)
            {

                MessageBox.Show("錯誤訊息:" + ex.Message, "IOException例外");
            }
        }
    }
}
