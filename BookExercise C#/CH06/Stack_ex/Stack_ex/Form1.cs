using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections; //for Stack
namespace Stack_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Stack words = new Stack();

            words.Push("drMaster");
            words.Push("hinet");
            words.Push("microsoft");
            words.Push("nokia");
            words.Push("intel");

            string msg = "輸入單字結果:\n";

            int nums = words.Count;

            for (int i = 0; i < nums; i++)
            {
                var word = words.Pop();
                msg = msg + word + "\n";
            }

            MessageBox.Show(msg, "Stack類別");
        }
    }
}
