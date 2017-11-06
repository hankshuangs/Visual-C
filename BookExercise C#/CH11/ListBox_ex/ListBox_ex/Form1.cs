using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox2.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0 && listBox2.Items.Count == 0)
            {
                listBox1.Items.Add("筆記型電腦");
                listBox1.Items.Add("桌上型電腦");
                listBox1.Items.Add("PDA");
                listBox1.Items.Add("EeePC");
                listBox1.Items.Add("超級電腦");
                listBox1.Items.Add("Wii");
                listBox1.Items.Add("PlayStation 3");
                listBox1.Items.Add("Xbox 360");
            }
            else
            {
                MessageBox.Show("您已經加入過清單項目", "資訊");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            if (listBox1.Focus())
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox1.SetSelected(i, true);
                }
            }
            else
            {
                for (int j = 0; j < listBox2.Items.Count; j++)
                {
                    listBox2.SetSelected(j, true);
                }
            }
        }

        private void btnUnselectAll_Click(object sender, EventArgs e)
        {
            if (listBox1.Focus())
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox1.SetSelected(i, false);
                }
            }
            else
            {
                for (int j = 0; j < listBox2.Items.Count; j++)
                {
                    listBox2.SetSelected(j, false);
                }
            }
        }

        private void btnToRight_Click(object sender, EventArgs e)
        {
            int count = listBox1.SelectedIndices.Count;
            if (count == 0)
            {
                MessageBox.Show("［商品清單］無任何商品", "資訊");
            }
            else
            {
                foreach (var obj in listBox1.SelectedItems)
                {
                    listBox2.Items.Add(obj);
                }

                for (int i = 0; i < count; i++)
                {
                    object item = listBox1.SelectedItem;
                    listBox1.Items.Remove(item);
                }
            }
        }

        private void btnAllToRight_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("［商品清單］無任何商品", "資訊");
            }
            else
            {
                foreach (var obj in listBox1.Items)
                {
                    listBox2.Items.Add(obj);
                }

                int count = listBox1.Items.Count;
                for (int i = 0; i < count; i++)
                {
                    listBox1.Items.RemoveAt(0);
                }
            }
        }

        private void btnToLeft_Click(object sender, EventArgs e)
        {
            int count = listBox2.SelectedIndices.Count;
            if (count == 0)
            {
                MessageBox.Show("［購物清單］無任何商品", "資訊");
            }
            else
            {

                foreach (var obj in listBox2.SelectedItems)
                {
                    listBox1.Items.Add(obj);
                }

                for (int i = 0; i < count; i++)
                {
                    object item = listBox2.SelectedItem;
                    listBox2.Items.Remove(item);
                }
            }
        }

        private void btnAllToLeft_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count == 0)
            {
                MessageBox.Show("［購物清單］無任何商品", "資訊");
            }
            else
            {
                foreach (var obj in listBox2.Items)
                {
                    listBox1.Items.Add(obj);
                }

                int count = listBox2.Items.Count;
                for (int i = 0; i < count; i++)
                {
                    listBox2.Items.RemoveAt(0);
                }
            }
        }

    }
}
