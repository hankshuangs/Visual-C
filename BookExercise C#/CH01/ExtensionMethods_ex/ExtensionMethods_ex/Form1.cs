using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.CSharp.ExtensionMethods;//new

namespace ExtensionMethods_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            char sex = 'M';
            int charLen = sex.GetLength();
            MessageBox.Show("'" + sex.ToString() + "'字元長度為"
                + charLen, "字元長度計算");
        }
    }
}
namespace Microsoft.CSharp.ExtensionMethods
{
    public static class MyCharMethods
    {
        /// <summary>
        /// 獲取字元長度
        /// </summary>
        /// <param name="c">字元參數</param>
        /// <returns>回傳整數值</returns>
        public static int GetLength(this char c)
        {
            return c.ToString().Length;
        }

    }
}
