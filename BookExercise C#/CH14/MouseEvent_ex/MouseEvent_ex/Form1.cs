using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseEvent_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            txtX.Text = e.X.ToString();
            txtY.Text = e.Y.ToString();
            txtEventType.Text = "滑鼠目前在觸發物件上-MouseMove";

            switch (e.Button)
            {
                case MouseButtons.Left:
                    MessageBox.Show("您按下滑鼠[左鍵]", "MouseMove事件");
                    break;
                case MouseButtons.Middle:
                    MessageBox.Show("您按下滑鼠[中間鍵]", "MouseMove事件");
                    break;
                case MouseButtons.Right:
                    MessageBox.Show("您按下滑鼠[右鍵]", "MouseMove事件");
                    break;
            }

        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtEventType.Text = "滑鼠左鍵連續「按二次」-MouseDoubleClick";
            MessageBox.Show(txtEventType.Text, "MouseDoubleClick事件");
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            txtEventType.Text = "滑鼠「進入」控制項可見範圍內-MouseEnter";
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            txtEventType.Text = "滑鼠鍵被「按住」-MouseDown";
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            txtEventType.Text = "滑鼠「停駐」於控制項可見範圍一段時間-MouseHover";
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            txtEventType.Text = "滑鼠「離開」控制項-MouseLeave";
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            txtEventType.Text = "按住的滑鼠鍵被「放開」-MouseUp";
        }
    }
}
