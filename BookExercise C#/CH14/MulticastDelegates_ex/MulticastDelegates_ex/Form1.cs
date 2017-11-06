using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MulticastDelegates_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private delegate void dlgt(object sender, EventArgs e);

        private void btnNotify_Click(object sender, EventArgs e)
        {
            MessageBox.Show("林杰樑:毒醃製品傷肝!!", "衛生署疾病管制局");

            dlgt virusNotify = btnKaoHsiung_Click;
            virusNotify = virusNotify + btnTaichung_Click;
            virusNotify = virusNotify + btnTaipei_Click;
            virusNotify.Invoke(sender, e);
        }

        private void btnKaoHsiung_Click(object sender, EventArgs e)
        {
            MessageBox.Show("程橘:別再吃塑化劑!!", "高雄市-衛生局");
        }

        private void btnTaichung_Click(object sender, EventArgs e)
        {
            MessageBox.Show("胡莒光:無食物解百毒", "台中市-衛生局");
        }

        private void btnTaipei_Click(object sender, EventArgs e)
        {
            MessageBox.Show("好龍冰:補內臟如吃毒", "台北市-衛生局");
        }
    }
}
