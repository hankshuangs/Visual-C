using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyEvent_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char hideChar;
        int errorCount;
        bool NonNumber = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.Focus();
            GeneratorCode();
        }
        private void GeneratorCode()
        {
            errorCount = 0;
            txt_count.Text = errorCount.ToString();
            txtLetter.Text = "";
            Random Randomobj = new Random();
            hideChar = Convert.ToChar(Randomobj.Next(27) + 65);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            string msg = "";
            switch (e.KeyCode)
            {
                case Keys.ControlKey:
                    msg = msg + "您為什麼要按下[CTRL]鍵？";
                    break;
                case Keys.Delete:
                    msg = msg + "您為什麼要按下[DEL]鍵？";
                    break;
                case Keys.Enter:
                    msg = msg + "您為什麼要按下[Enter]鍵？";
                    break;
                case Keys.Up:
                    msg = msg + "您為什麼要按下[UP]鍵？";
                    break;
                case Keys.Down:
                    msg = msg + "您為什麼要按下[DOWN]鍵？";
                    break;
                case Keys.Left:
                    msg = msg + "您為什麼要按下[LEFT]鍵？";
                    break;
                case Keys.Right:
                    msg = msg + "您為什麼要按下[RIGHT]鍵？";
                    break;
                case Keys.F1:
                    msg = msg + "您為什麼要按下[F1]鍵？";
                    break;
                case Keys.Escape:
                    msg = msg + "您為什麼要按下[ESC]鍵？";
                    break;
                default:
                    break;
            }
            if (msg != "")
            {
                errorCount = errorCount + 1;
                txt_count.Text = errorCount.ToString();
                MessageBox.Show(msg, "e.KeyCode");
            }

            switch (e.KeyValue)
            {
                case 16:
                    errorCount = errorCount + 1;
                    txt_count.Text = errorCount.ToString();
                    MessageBox.Show("您為什麼要按下[Shift]鍵？", "e.KeyValue");
                    break;
                case 18:
                    errorCount = errorCount + 1;
                    txt_count.Text = errorCount.ToString();
                    MessageBox.Show("您為什麼要按下[Alt]鍵？", "e.KeyValue");
                    break;
                default:
                    break;
            }
            NonNumber = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        NonNumber = true;//輸入非數字
                    }
                }
            }
            //亦可
            //if (e.KeyValue >= 48 && e.KeyValue <= 57)
            //{
            //    NonNumber = false;
            //}
            //else
            //{
            //    NonNumber = true;
            //}
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //輸入為數字
            if (NonNumber == false)
            {
                errorCount = errorCount + 1;
                txt_count.Text = errorCount.ToString();
                MessageBox.Show("這不是在玩猜數字遊戲喔！", "訊息提示");
                e.Handled = true;//取消鍵盤輸入
            }
            else
            {
                txtLetter.Text = e.KeyChar.ToString().ToUpper();
                if (e.KeyChar.ToString().ToUpper() == hideChar.ToString().ToUpper())
                {
                    MessageBox.Show("恭喜您猜對了,正確的字母為[" +
                        hideChar.ToString() + "]", "答案正確");
                    GeneratorCode();
                }
                else
                {
                    errorCount = errorCount + 1;
                    txt_count.Text = errorCount.ToString();
                }
            }
        }
    }
}
