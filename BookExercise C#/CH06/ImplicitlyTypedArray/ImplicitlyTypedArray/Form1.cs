using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImplicitlyTypedArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOneArray_Click(object sender, EventArgs e)
        {
            var student = new[] { "Ryu", "Candy" };

            string msg = "學生清單:\n";
            foreach (var obj in student)
            {
                msg = msg + obj + "\n";
            }
            MessageBox.Show(msg, "隱含型別一維陣列範例");
        }

        private void btnTwoArray_Click(object sender, EventArgs e)
        {
             var employee = new[,] { {"許清榮","Ryu","資深工程師" },
                                   {"江世華","Candy","研發工程師" } };

            string msg = "員工清單:\n";
            foreach (var obj in employee)
            {
                msg = msg + obj + ",";
            }
            MessageBox.Show(msg, "隱含型別二維陣列範例");
        }

        private void btnImplicitlyAnonymous_Click(object sender, EventArgs e)
        {
             var student = new[] 
                         {new {Name="Ryu", Age=28 , Score = 100} ,
                          new {Name="Candy", Age=26 , Score = 96 }};

            string msg = "";
            for (int i = 0; i < student.Length; i++)
            {
                msg = msg + "姓名:" + student[i].Name + " ,";
                msg = msg + "年齡:" + student[i].Age + " ,";
                msg = msg + "成績:" + student[i].Score + "\n";
            }
            MessageBox.Show(msg, "隱含型別&匿名型別");
        }
        
    }
}
