using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtID.BackColor = Color.AliceBlue;
            txtID.MaxLength = 10;

            txtID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtID.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtID.AutoCompleteCustomSource.Add("sa");
            txtID.AutoCompleteCustomSource.Add("ryu");
            txtID.AutoCompleteCustomSource.Add("ray");
            txtID.AutoCompleteCustomSource.Add("ken");
            txtID.AutoCompleteCustomSource.Add("kenny");
            txtPWD.BackColor = Color.AntiqueWhite;
            txtPWD.MaxLength = 12;

            txtPWD.PasswordChar = '*';
            txtPWD.UseSystemPasswordChar = true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "ryu" && txtPWD.Text == "123")
            {
                MessageBox.Show("帳號和密碼正確!!", "登入成功");
            }
            else
            {
                MessageBox.Show("帳號或密碼錯誤!!", "登入失敗");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtPWD.ResetText();
        }


    }
}
