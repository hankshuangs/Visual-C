using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstraction_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public enum MsgBoxButtons
        {
            AbortRetryIgnore, OK, OKCancel,
            RetryCancel, YesNo, YesNoCancel
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            string msg = "顯示各種訊息按鈕狀況:\n";

            msg = msg + PlayMsgBoxButton(MsgBoxButtons.RetryCancel) + "\n";
            msg = msg + PlayMsgBoxButton(MsgBoxButtons.OKCancel) + "\n";
            msg = msg + PlayMsgBoxButton(MsgBoxButtons.YesNoCancel);

            MessageBox.Show(msg, "Abstraction範例");
        }
        public string PlayMsgBoxButton(MsgBoxButtons mbb)
        {
            switch (mbb)
            {
                case MsgBoxButtons.AbortRetryIgnore:
                    return "[中止][重試][略過]";
                case MsgBoxButtons.OK:
                    return "[確定]";
                case MsgBoxButtons.OKCancel:
                    return "[確定][取消]";
                case MsgBoxButtons.RetryCancel:
                    return "[重試][取消]";
                case MsgBoxButtons.YesNo:
                    return "[是][否]";
                case MsgBoxButtons.YesNoCancel:
                    return "[是][否][取消]";
                default:
                    return "參數有誤!!";
            }

        }
    }
}
