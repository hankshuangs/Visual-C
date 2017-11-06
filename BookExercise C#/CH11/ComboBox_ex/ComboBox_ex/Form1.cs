using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cboAntecedent.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            cboAntecedent.Items.Add("國中");
            cboAntecedent.Items.Add("高中");
            cboAntecedent.Items.Add("專科");
            cboAntecedent.Items.Add("大學");
            cboAntecedent.Items.Add("碩士");
            cboAntecedent.Items.Add("博士");
            cboAntecedent.Items.Insert(0, "國小");

            cboAntecedent.SelectedItem = "大學";
        }

        private void btnGetItems_Click(object sender, EventArgs e)
        {
            string msg = "最高學歷內容:\n";
            foreach (var obj in cboAntecedent.Items)
            {
                msg = msg + obj + "\n";
            }
            msg = msg + "總計:" + cboAntecedent.Items.Count + "個項目";
            MessageBox.Show(msg, "Items屬性");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            cboAntecedent.Items.Clear();
            string msg = "組合方塊清單項目內容已經被清除";
            MessageBox.Show(msg, "Clear()方法");
        }

        private void cboAntecedent_SelectedIndexChanged(object sender, EventArgs e)
        {
            string msg = "您選取項目為:" + cboAntecedent.SelectedItem;
            MessageBox.Show(msg, "SelectedIndexChanged事件");
        }


    }
}
