using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Step 1:宣告委派
        private delegate void dlgRemoteControl(object sender, EventArgs e);
         private void Form1_Load(object sender, EventArgs e)
        {
            //Step 2:宣告委派變數，指向方法或事件
            dlgRemoteControl dRC = btnOpenTV_Click;

            //Step 3:利用委派成員Invoke()方法來叫用方法或事件
            dRC.Invoke(sender, e);
        }
       
        private void btnOpenTV_Click(object sender, EventArgs e)
        {
            string msg = "目前正在播放節目為[看見台灣]";
            MessageBox.Show(msg, "三粒");
        }

       
    }
}
