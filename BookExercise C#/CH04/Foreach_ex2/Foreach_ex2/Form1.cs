using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foreach_ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Mybutton_Click(object sender, EventArgs e)
        {
            string msg = "";

            foreach (Control obj in this.Controls)
            {

                msg = msg + obj.GetType().ToString() +
                    ",物件名稱:" + obj.Name + "\n";
                obj.Font = new Font(this.Font, FontStyle.Bold);
                obj.ForeColor = System.Drawing.Color.Green;

                if (obj is Label)
                {
                    obj.Text = "我是標籤";
                }
                else if (obj is ComboBox)
                {
                    obj.Text = "我是組合方塊";
                }
                else if (obj is CheckBox)
                {
                    obj.Text = "我是核取方塊";
                }
                else if (obj is RadioButton)
                {
                    obj.Text = "我是圈選按鈕";
                }
                else if (obj is TextBox)
                {
                    obj.Text = "我是文字方塊";
                }
                else if (obj is Button)
                {
                    obj.Text = "我是按鈕";
                }
                else
                {
                    obj.Text = "未知的控制項";
                }

            }

            MessageBox.Show(msg, "表單內所有控制項");
        }
    }
}
