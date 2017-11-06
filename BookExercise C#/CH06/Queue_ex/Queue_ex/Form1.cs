using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;//for Queue
namespace Queue_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Queue words = new Queue();

            words.Enqueue("drMaster");
            words.Enqueue("hinet");
            words.Enqueue("microsoft");
            words.Enqueue("nokia");
            words.Enqueue("intel");

            string msg = "輸入單字結果:\n";

            int nums = words.Count;

            for (int i = 0; i < nums; i++)
            {
                var word = words.Dequeue();
                msg = msg + word + "\n";
            }

            MessageBox.Show(msg, "Queue類別");
        }
    }
}
