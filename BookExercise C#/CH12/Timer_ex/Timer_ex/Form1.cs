using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Timer t1 = new Timer();
        int totalSecond;
        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "HH:mm:ss";
            dateTimePicker1.Value = DateTime.Parse("00:00:00");

            this.t1.Tick += new System.EventHandler(this.t1_Tick);
            t1.Enabled = false;
            t1.Interval = 1000;
        }

        private void t1_Tick(object sender, EventArgs e)
        {
            if (totalSecond > 0)
            {
                lbl_Sec.Text = totalSecond.ToString() + "秒";
                totalSecond = totalSecond - 1;
            }
            else
            {
                lbl_Sec.Text = "0秒";
                t1.Enabled = false;
                MessageBox.Show("時間到(Time's Up)!!", "Timer範例");
                btnStart.Enabled = true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            totalSecond = 0;
            int H = (int)dateTimePicker1.Value.Hour;
            int M = (int)dateTimePicker1.Value.Minute;
            int S = (int)dateTimePicker1.Value.Second;

            totalSecond = H * 60 * 60 + M * 60 + S;
            t1.Enabled = true;
            btnStart.Enabled = false;
        }
    }
}
