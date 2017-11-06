using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControl_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TabPage tp1, tp2;
        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.ImageList = imageList1;
            tabControl1.TabPages[0].ImageIndex = 0;
            tabControl1.TabPages[1].ImageIndex = 1;
            tabControl1.TabPages[2].ImageIndex = 2;

            tSSLab.Text = "目前所在頁籤位置:" + tabControl1.SelectedTab.Text;

            btnAdd.Enabled = true;
            btnRemove.Enabled = false;
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            int maxTabPages = tabControl1.TabCount;
            if (tabControl1.SelectedIndex != (maxTabPages - 1))
            {
                tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
            }
            else
            {
                tabControl1.SelectedIndex = 0;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tp1 = new TabPage("新功能1");
            tp2 = new TabPage("新功能2");
            tabControl1.TabPages.Add(tp1);
            tabControl1.TabPages.Add(tp2);
            btnAdd.Enabled = false;
            btnRemove.Enabled = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tp1);
            tabControl1.TabPages.Remove(tp2);
            btnAdd.Enabled = true;
            btnRemove.Enabled = false;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int maxTabPages = tabControl2.TabCount;
            if (tabControl2.SelectedIndex != 0)
            {
                tabControl2.SelectedIndex = tabControl2.SelectedIndex - 1;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int maxTabPages = tabControl2.TabCount;
            if (tabControl2.SelectedIndex != (maxTabPages - 1))
            {
                tabControl2.SelectedIndex = tabControl2.SelectedIndex + 1;
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            switch (tabControl1.TabPages[e.TabPageIndex].Name)
            {
                case "tabPage1":
                    tSSLab.Text = "目前所在頁籤位置:" + tabPage1.Text;
                    break;
                case "tabPage2":
                    tSSLab.Text = "目前所在頁籤位置:" + tabPage2.Text;
                    break;
                default:
                    tSSLab.Text = "目前所在頁籤位置:" + tabControl1.SelectedTab.Text;
                    break;
            }
        }
    }
}
