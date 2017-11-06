using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinArgs_ex
{
    public partial class Form1 : Form
    {
        public Form1(params string[] List)
        {
            InitializeComponent();

            string Msg = "";
            if (List.Length == 0)
            {
                MessageBox.Show("無使用任何引數!可於DOS模式輸入以下敘述："
                    + Environment.NewLine + "WinArgs_ex -?");
            }
            else
            {
                Msg = "共接收" + List.Length.ToString() + "引數\n";

                for (int i = 0; i < List.Length; i++)
                {
                    Msg = Msg + List[i].ToString() + Environment.NewLine;

                    switch (List[i].ToUpper())
                    {
                        case "-?":
                            Msg = Msg + "顯示線上幫忙" + "\n";
                            break;
                        case "-H":
                            Msg = Msg + "顯示線上幫忙" + "\n";
                            break;
                        case "-V":
                            Msg = Msg + "目前系統版本V2.0" + "\n";
                            break;
                        case "-PWD":
                            Msg = Msg + "預設密碼為:[12345]" + "\n";
                            break;
                        default:
                            Msg = Msg + "未知引數" + "\n";
                            break;
                    } // end switch

                } // end for
                MessageBox.Show(Msg, "引數說明");
            }

        }
    }
}
