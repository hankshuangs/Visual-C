using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView_ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.LargeImageList = imageList1;
            listView1.SmallImageList = imageList2;
            listView1.Activation = ItemActivation.OneClick;
            ListViewItemConstruct("主畫面");
        }
        private void ListViewItemConstruct(string name)
        {
            listView1.View = View.LargeIcon;

            switch (name)
            {
                case "主畫面":
                case "回上一頁":
                    listView1.Items.Clear();
                    listView1.Items.Add(new ListViewItem("客戶管理"));
                    listView1.Items.Add(new ListViewItem("線上更新"));
                    listView1.Items.Add(new ListViewItem("其他功能"));
                    listView1.Items[0].ImageIndex = 0;
                    listView1.Items[1].ImageIndex = 1;
                    listView1.Items[2].ImageIndex = 2;
                    break;

                case "客戶管理":
                    listView1.Items.Clear();
                    listView1.Columns.Clear();
                    listView1.Columns.Add("車名", 140, HorizontalAlignment.Left);
                    listView1.Columns.Add("馬力", 60, HorizontalAlignment.Left);
                    listView1.Columns.Add("扭力", 60, HorizontalAlignment.Left);
                    listView1.Columns.Add("價格", 60, HorizontalAlignment.Left);

                    listView1.Items.Add(new ListViewItem("回上一頁"));
                    ListViewItem LVIA = new ListViewItem("Colt puls");
                    LVIA.SubItems.Add("112hp");
                    LVIA.SubItems.Add("14.9kgm");
                    LVIA.SubItems.Add("54.5萬");
                    listView1.Items.Add(LVIA);

                    ListViewItem LVIB = new ListViewItem("EVO 10");
                    LVIB.SubItems.Add("291hp");
                    LVIB.SubItems.Add("40kgm");
                    LVIB.SubItems.Add("230萬");
                    listView1.Items.Add(LVIB);

                    ListViewItem LVIC = new ListViewItem("Eclipse 2014");
                    LVIC.SubItems.Add("260hp");
                    LVIC.SubItems.Add("30.7kgm");
                    LVIC.SubItems.Add("160萬");
                    listView1.Items.Add(LVIC);

                    listView1.Items[0].ImageIndex = 3;
                    listView1.Items[1].ImageIndex = 4;
                    listView1.Items[2].ImageIndex = 5;
                    listView1.Items[3].ImageIndex = 6;
                    break;

                case "其他功能":
                    listView1.Items.Clear();
                    listView1.Items.Add(new ListViewItem("回上一頁"));
                    listView1.Items[0].ImageIndex = 3;
                    MessageBox.Show("功能正在建構中..", "其他功能");
                    break;

                default:
                    MessageBox.Show(name);
                    break;
            }
        }

        private void cboView_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboView.Text)
            {
                case "LargeIcon":
                    listView1.View = View.LargeIcon;
                    break;
                case "Details":
                    listView1.View = View.Details;
                    break;
                case "SmallIcon":
                    listView1.View = View.SmallIcon;
                    break;
                case "List":
                    listView1.View = View.List;
                    break;
                case "Tile":
                    listView1.View = View.Tile;
                    break;
                default:
                    listView1.View = View.LargeIcon;
                    break;
            }
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            string ItemName = listView1.FocusedItem.Text;
            //下面亦可捕捉到選取項目名稱
            //int n = listView1.SelectedIndices[0];
            //ItemName = listView1.Items[n].Text;
            ListViewItemConstruct(ItemName);
        }
    }
}
