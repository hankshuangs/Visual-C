using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private MenuStrip ms = new MenuStrip();
        private void Form1_Load(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi1 = new ToolStripMenuItem("檔案");
            ToolStripMenuItem tsmi2 = new ToolStripMenuItem("編輯");

            ms.Items.Add(tsmi1);
            ms.Items.Add(tsmi2);

            ToolStripMenuItem tsmi1_1 = new ToolStripMenuItem("開啟舊檔");
            ToolStripMenuItem tsmi1_2 = new ToolStripMenuItem("儲存檔案");
            ToolStripMenuItem tsmi1_3 = new ToolStripMenuItem("另存新檔");
            ToolStripSeparator tsmi1_4 = new ToolStripSeparator();
            ToolStripMenuItem tsmi1_5 = new ToolStripMenuItem("結束", null, new EventHandler(tsmi1_5_Click));
            tsmi1_5.Checked = true;

            tsmi1.DropDownItems.AddRange(new ToolStripItem[] { tsmi1_1, tsmi1_2, tsmi1_3, tsmi1_4, tsmi1_5 });

            tsmi1_1.Image = imageList1.Images[0];
            tsmi1_2.Image = imageList1.Images[1];
            tsmi1_3.Image = imageList1.Images[2];

            contextMenuStrip1.ImageList = imageList2;
            contextMenuStrip1.Items[0].ImageIndex = 0;
            contextMenuStrip1.Items[1].ImageIndex = 1;
            contextMenuStrip1.Items[2].ImageIndex = 2;
            tsmi2.DropDown = this.contextMenuStrip1;

            // 設定停駐方式和表單功能表繪製樣式
            ms.Dock = DockStyle.Top;
            ms.RenderMode = ToolStripRenderMode.Professional;
            // 設定表單主要功能表
            this.MainMenuStrip = ms;

            // 將MenuStrip加入到表單容器中
            this.Controls.Add(ms);

            this.ms.ItemClicked += new ToolStripItemClickedEventHandler(this.ms_ItemClicked);
        }

        void tsmi1_5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("應用程式關閉", "訊息");
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi3 = new ToolStripMenuItem("新功能");

            ms.Items.Add(tsmi3);

            ToolStripMenuItem tsmi3_1 = new ToolStripMenuItem("新功能1");
            ToolStripMenuItem tsmi3_2 = new ToolStripMenuItem("新功能2");
            tsmi3.DropDownItems.Add(tsmi3_1);
            tsmi3.DropDownItems.Add(tsmi3_2);
            btnAdd.Enabled = false;
            btnRemove.Enabled = true;
        }

        private void ms_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.ToString())
            {
                case "檔案":
                    MessageBox.Show("您點選[檔案]鈕", "ItemClicked事件");
                    break;
                case "編輯":
                    MessageBox.Show("您點選[編輯]鈕", "ItemClicked事件");
                    break;
                default:
                    break;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ms.Items.RemoveAt(2);
            btnAdd.Enabled = true;
            btnRemove.Enabled = false;
        }

        private void btnGetItems_Click(object sender, EventArgs e)
        {
            string msg = "";
            foreach (var obj in ms.Items)
            {
                ToolStripMenuItem tsmi = (ToolStripMenuItem)obj;

                msg = msg + tsmi.Text + " : ";
                foreach (var subObj in tsmi.DropDownItems)
                {
                    if (subObj.GetType().ToString().IndexOf("ToolStripSeparator") == -1)
                    {
                        ToolStripMenuItem subTsmi = (ToolStripMenuItem)subObj;
                        msg = msg + subTsmi.Text + " ";
                    }

                }
                msg = msg + "\n";
            }
            MessageBox.Show(msg, "取出清單項目");
        }
 
    }
}
