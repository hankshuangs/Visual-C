using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView_ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //第一種:定義TreeNode節點在指派給TreeView
            TreeNode tn = new TreeNode("博碩集團");
            tn.Nodes.Add("許清榮電腦著作");
            tn.Nodes[0].Nodes.Add("掌握Hadoop翱翔雲端：Windoop應用實作指南");
            tn.Nodes[0].Nodes.Add("Visual C# 2010程式設計實例演練與系統開發");
            tn.Nodes[0].Nodes.Add("部落格‧網誌人氣排名提升與行銷的不傳秘技");
            tn.Nodes[0].Nodes.Add("Visual Basic 2008程式設計經典教本");
            tn.Nodes[0].Nodes.Add("Java視窗應用程式設計與SCJP認證實戰演練");
            tn.Nodes[0].Nodes.Add("e世代必學實用軟體密技應用實務");
            treeView1.Nodes.Add(tn);
            //第二種:從TreeView直接加入節點
            treeView1.Nodes.Add("博碩文化");
            treeView1.Nodes[1].Nodes.Add("Ryu電腦著作");
            treeView1.Nodes[1].Nodes[0].Nodes.Add("Pocket PC裝置應用程式開發秘笈");
            treeView1.Nodes[1].Nodes[0].Nodes.Add("Visual C# 2005 建構資訊系統實戰經典教本");
            treeView1.Nodes[1].Nodes[0].Nodes.Add("Visual Basic 2005 Express 程式設計經典教本");
            treeView1.Nodes[1].Nodes[0].Nodes.Add("Visual Basic 2005 –進銷存系統開發實務設計");
            treeView1.Nodes[1].Nodes[0].Nodes.Add("Windows Mobile 6 應用程式設計與操控實務");
        }
    }
}
