using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectHash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrypto_Click(object sender, EventArgs e)
        {
            if (txtInput.Text != "")
            {
                string enCrypType = "";
                if (rdoMD5.Checked)
                {
                    enCrypType = rdoMD5.Text;
                }
                else
                {
                    enCrypType = rdoSHA1.Text;
                }
                string result = ClsHash.Class1.HashEncryption(enCrypType,
                    txtInput.Text);
                rtxtResult.Text = result;
            }
        }
    }
}
