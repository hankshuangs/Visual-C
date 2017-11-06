using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView_ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //1. 加入列舉檢視項目
            listView1.Items.Add(new ListViewItem("我的易速達"));
            listView1.Items.Add(new ListViewItem("我的大羊"));
            listView1.Items.Add(new ListViewItem("我的火神"));

            //2. 設定影像清單
            listView1.LargeImageList = imageList1;

            //3. 設定每個項目的影像索引編號
            listView1.Items[0].ImageIndex = 0;
            listView1.Items[1].ImageIndex = 1;
            listView1.Items[2].ImageIndex = 2;
        }
    }
}
