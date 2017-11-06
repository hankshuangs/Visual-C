using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Throw_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string[] appraisal = new string[] { "GTS300i", "T-max", "C650", "AN650", "Xciting" };
            try
            {
                int index = int.Parse(txtNum.Text);
                index = index - 1;
                if (index < 0 || index >= 5)
                {
                    throw new IndexOutOfRangeException();
                }
                string msg = "";
                msg = "您喜愛的大羊重機是:" + appraisal[index] + "\n";
                MessageBox.Show(msg, "throw範例");
            }

            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "FormatException類別");
            }

            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "IndexOutOfRangeException類別");
            }

            finally
            {
                appraisal = null;
            }
        }
    }
}
