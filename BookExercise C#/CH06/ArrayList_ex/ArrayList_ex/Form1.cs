using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;//for ArrayList
namespace ArrayList_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArrayList_Click(object sender, EventArgs e)
        {
            string name = "許清榮";
            int score = 100;
            bool status = true;

            ArrayList student = new ArrayList();

            student.Add(name);
            student.Add(score);
            student.Add(status);

            string msg = "ArrayList陣列元素內容和資料型別:\n";
            foreach (var obj in student)
            {
                msg = msg + obj + "," + obj.GetType().ToString() + "\n";
            }

            MessageBox.Show(msg, "ArrayList類別");
        }
    }
}
