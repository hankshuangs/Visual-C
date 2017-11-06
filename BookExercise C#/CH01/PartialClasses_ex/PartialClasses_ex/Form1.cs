using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartialClasses_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowPeopleInfo_Click(object sender, EventArgs e)
        {
            //將Human實體化為一個讀者(Reader)物件
            Human Reader = new Human();
            Reader.Name = "Elva";
            Reader.Age = 5;
            string Action = Reader.ToWalk();
            MessageBox.Show(Action, Reader.Name + "-" + Reader.Age);
        }
    }
}
