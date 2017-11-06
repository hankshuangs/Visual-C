using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nullable_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public struct Studnet
        {
            public string id;
            public string name;
            public Nullable<int> score;
            public double? avg;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            Studnet[] std = new Studnet[2];
            std[0].id = "A102001";
            std[0].name = "許清榮";
            std[0].score = 100;
            std[0].avg = null;
            std[1].id = "A102002";
            std[1].name = "吳宜隆";
            std[1].score = null;
            std[1].avg = 90;

            string msg = "";
            foreach (var v in std)
            {
                msg = msg + "學號:" + v.id + "\n";
                msg = msg + "姓名:" + v.name + "\n";
                msg = msg + "分數:" + v.score + "\n";
                msg = msg + "平均:" + v.avg + "\n";
            }
            MessageBox.Show(msg, "Nullable類別範例");
        }
    }
}
