using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections; //新增
namespace AsOperators_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            ArrayList allTypes = new ArrayList();
            allTypes.Add("許清榮");
            allTypes.Add(28);
            allTypes.Add(true);
            allTypes.Add('男');
            allTypes.Add("Ching-Jung Hsu");
            string msg = "";
            foreach (var obj in allTypes)
            {
                string showStr = obj as string;

                if (showStr != null)
                {
                    msg = msg + showStr + "\n";
                }
            }
            MessageBox.Show(msg, "as運算子");
        }
    }
}
