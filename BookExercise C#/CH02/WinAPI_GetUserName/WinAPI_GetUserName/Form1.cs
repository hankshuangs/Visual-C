using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; //使用DllImport所需引用的命名空間
namespace WinAPI_GetUserName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("Advapi32.dll", EntryPoint = "GetUserName",
         ExactSpelling = false, SetLastError = true)]
        static extern bool GetUserName(
            [MarshalAs(UnmanagedType.LPArray)] byte[] lpBuffer,
            [MarshalAs(UnmanagedType.LPArray)] int[] nSize);
        private void btnGetUserName_Click(object sender, EventArgs e)
        {
            byte[] str = new byte[20];
            int[] len = new int[1];
            len[0] = str.Length;
            GetUserName(str, len);
            string Msg = System.Text.Encoding.ASCII.GetString(str);
            Msg = Msg.Substring(0, Msg.IndexOf('\0'));
            MessageBox.Show(this, Msg, "獲取使用者名稱"); 
        }
    }
}
