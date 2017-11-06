using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBox_ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string msg = "";
        string caption = "";
        MessageBoxButtons buttons;//所要顯示按鈕
        MessageBoxIcon icon = MessageBoxIcon.None; //所要顯示按鈕
        DialogResult result;      //接收所按下按鈕的回傳值
        private void Form1_Load(object sender, EventArgs e)
        {
            cboButtons.DropDownStyle = ComboBoxStyle.DropDown;
            cboIcons.DropDownStyle = ComboBoxStyle.DropDown;
        }
        private void btn_Run_Click(object sender, EventArgs e)
        {
            msg = txtText.Text;
            caption = txtCaption.Text;
            result = MessageBox.Show(msg, caption, buttons, icon);
            GetResult(result);
        }
        public void GetResult(DialogResult DR)
        {
            switch (DR)
            {
                case DialogResult.OK:
                    MessageBox.Show(this, "您按下[確定]鈕", "DialogResult回傳值");
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show(this, "您按下[取消]鈕", "DialogResult回傳值");
                    break;
                case DialogResult.Yes:
                    MessageBox.Show(this, "您按下[是]鈕", "DialogResult回傳值");
                    break;
                case DialogResult.No:
                    MessageBox.Show(this, "您按下[否]鈕", "DialogResult回傳值");
                    break;
                case DialogResult.Abort:
                    MessageBox.Show(this, "您按下[中止]鈕", "DialogResult回傳值");
                    break;
                case DialogResult.Ignore:
                    MessageBox.Show(this, "您按下[忽略]鈕", "DialogResult回傳值");
                    break;
                case DialogResult.Retry:
                    MessageBox.Show(this, "您按下[重試]鈕", "DialogResult回傳值");
                    break;
                case DialogResult.None:
                    MessageBox.Show(this, "強制回應對話方塊", "DialogResult回傳值");
                    break;
                default:
                    break;
            }
        }

        private void btn_Rewrite_Click(object sender, EventArgs e)
        {
            txtCaption.Text = "";
            txtText.Text = "";
        }

        private void cboButtons_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cboButtons.Text)
            {
                case "[確定]":
                    buttons = MessageBoxButtons.OK;
                    break;
                case "[確定][取消]":
                    buttons = MessageBoxButtons.OKCancel;
                    break;
                case "[是][否]":
                    buttons = MessageBoxButtons.YesNo;
                    break;
                case "[是][否][取消]":
                    buttons = MessageBoxButtons.YesNoCancel;
                    break;
                case "[重試][取消]":
                    buttons = MessageBoxButtons.RetryCancel;
                    break;
                case "[中止][重試][略過]":
                    buttons = MessageBoxButtons.AbortRetryIgnore;
                    break;
                default:
                    break;
            }
        }

        private void cboIcons_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboIcons.Text)
            {
                case "Information":
                    picbox1.BackgroundImage = Resource1.Information;
                    //System.Drawing.Bitmap.FromFile("../../images/Information.gif");
                    icon = MessageBoxIcon.Information;
                    break;
                case "Error":
                    picbox1.BackgroundImage = Resource1.Error;
                    icon = MessageBoxIcon.Error;
                    break;
                case "Stop":
                    picbox1.BackgroundImage = Resource1.Stop;
                    icon = MessageBoxIcon.Stop;
                    break;
                case "Warning":
                    picbox1.BackgroundImage = Resource1.Warning;
                    icon = MessageBoxIcon.Warning;
                    break;
                case "Question":
                    picbox1.BackgroundImage = Resource1.Question;
                    icon = MessageBoxIcon.Question;
                    break;
                case "Exclamation":
                    picbox1.BackgroundImage = Resource1.Exclamation;
                    icon = MessageBoxIcon.Exclamation;
                    break;
                case "Asterisk":
                    picbox1.BackgroundImage = Resource1.Asterisk;
                    icon = MessageBoxIcon.Asterisk;
                    break;
                case "Hand":
                    picbox1.BackgroundImage = Resource1.Hand;
                    icon = MessageBoxIcon.Hand;
                    break;
                default:
                    picbox1.BackgroundImage = null;
                    icon = MessageBoxIcon.None;
                    break;
            }
        }

    }
}
