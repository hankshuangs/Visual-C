using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView_ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.ImageList = imageList1;
            treeView1.CheckBoxes = true;
            TreeViewItemConstruct();
            treeView1.ExpandAll();
        }

        private void TreeViewItemConstruct()
        {

            treeView1.Nodes.Add("客戶管理");
            treeView1.Nodes.Add("線上更新");
            treeView1.Nodes.Add("其他功能");
            treeView1.Nodes[0].Nodes.Add("Colt puls");
            treeView1.Nodes[0].Nodes.Add("EVO 10");
            treeView1.Nodes[0].Nodes.Add("Eclipse 2014");

            treeView1.Nodes[0].ImageIndex = 0;
            treeView1.Nodes[1].ImageIndex = 1;
            treeView1.Nodes[2].ImageIndex = 2;
            treeView1.Nodes[0].Nodes[0].ImageIndex = 4;
            treeView1.Nodes[0].Nodes[1].ImageIndex = 5;
            treeView1.Nodes[0].Nodes[2].ImageIndex = 6;
            treeView1.Nodes[0].SelectedImageIndex = 0;
            treeView1.Nodes[1].SelectedImageIndex = 1;
            treeView1.Nodes[2].SelectedImageIndex = 2;
            treeView1.Nodes[0].Nodes[0].SelectedImageIndex = 4;
            treeView1.Nodes[0].Nodes[1].SelectedImageIndex = 5;
            treeView1.Nodes[0].Nodes[2].SelectedImageIndex = 6;
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "線上更新" && e.Node.Checked == true)
            {
                MessageBox.Show("您勾選:[" + e.Node.Text + "]項目");
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            toolStripStatusLabel1.Text = "目前選取路徑:" + e.Node.FullPath;
            string msg = "";
            switch (e.Node.Text)
            {
                case "客戶管理":
                    msg = msg + "目前可見節點數=" + treeView1.VisibleCount + "\n";
                    msg = msg + "樹狀節點數不含子節點數=" + treeView1.GetNodeCount(false) + "\n";
                    msg = msg + "執行:[" + e.Node.Text + "]功能";
                    MessageBox.Show(msg, e.Node.Text);
                    break;
                case "線上更新":
                    treeView1.CollapseAll();
                    msg = msg + "收合所有子節點:\n";
                    msg = msg + "執行:[" + e.Node.Text + "]功能";
                    MessageBox.Show(msg, e.Node.Text);
                    break;
                case "其他功能":
                    treeView1.ExpandAll();
                    msg = msg + "展開所有子節點:\n";
                    msg = msg + "執行:[" + e.Node.Text + "]功能";
                    MessageBox.Show(msg, e.Node.Text);
                    break;

            }
        }
    }
}
