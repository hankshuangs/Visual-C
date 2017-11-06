using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContextMenuStrip_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private ContextMenuStrip cms;
        private void Form1_Load(object sender, EventArgs e)
        {
            cms = new ContextMenuStrip();

            ToolStripMenuItem tsmi1 = new ToolStripMenuItem("複製(Copy)");
            ToolStripMenuItem tsmi2 = new ToolStripMenuItem("剪下(Cut)");
            ToolStripMenuItem tsmi3 = new ToolStripMenuItem("貼上(Paste)");
            cms.Items.Add(tsmi1);
            cms.Items.Add(tsmi2);
            cms.Items.Add(tsmi3);

            cms.ImageList = imageList1;
            cms.Items[0].ImageIndex = 0;
            cms.Items[1].ImageIndex = 1;
            cms.Items[2].ImageIndex = 2;

            rtxtBlog.ContextMenuStrip = cms;

            this.cms.ItemClicked += new ToolStripItemClickedEventHandler(this.cms_ItemClicked);
        }

        private void cms_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.ToString())
            {
                case "複製(Copy)":
                    rtxtBlog.Copy();
                    break;
                case "剪下(Cut)":
                    rtxtBlog.Cut();
                    break;
                case "貼上(Paste)":
                    rtxtBlog.Paste();
                    break;
                default:
                    break;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtBlog.Text, "心情日誌");
        }

       
    }
}
