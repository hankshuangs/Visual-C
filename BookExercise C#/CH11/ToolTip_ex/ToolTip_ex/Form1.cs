using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolTip_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.IsBalloon = true;

            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Windows 8.1";

            toolTip1.UseAnimation = true;
            toolTip1.UseFading = true;

            toolTip1.SetToolTip(txtInput, "請您輸入下圖xxxx-xx內容");
            toolTip1.SetToolTip(picLicense, "此圖防止機器人留言垃圾廣告");
            toolTip1.SetToolTip(btnOk, "按下[確定]鈕以執行驗證動作");
            toolTip1.SetToolTip(btnClear, "按下[清除]鈕將清除輸入字串");
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "8888-88")
            {
                MessageBox.Show("輸入驗證碼正確!", "驗證結果");
            }
            else
            {
                MessageBox.Show("輸入驗證碼錯誤!", "驗證結果");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
        }
       
    }
}
