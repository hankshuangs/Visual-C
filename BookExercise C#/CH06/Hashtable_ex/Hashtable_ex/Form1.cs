using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;//for Hashtable
namespace Hashtable_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Hashtable student = new Hashtable();

            student.Add("Ryu", 100);
            student.Add("Candy", 85);
            student.Add("Karen", 70);
            student.Add("Becky", 82);

            string msg = "學生C#考試成績:\n";
            foreach (DictionaryEntry obj in student)
            {
                var name = obj.Key;
                var score = obj.Value;
                msg = msg + "姓名:" + name + ",";
                msg = msg + "分數:" + score + "\n";
            }
            msg = msg + "考試人數:" + student.Count;
            MessageBox.Show(msg, "Hashtable類別");
        }
    }
}
