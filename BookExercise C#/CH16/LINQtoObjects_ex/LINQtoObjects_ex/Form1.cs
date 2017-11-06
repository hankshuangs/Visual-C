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
namespace LINQtoObjects_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            int startPrices , endPrices;
            int.TryParse(txtStartPrice.Text, out startPrices);
            int.TryParse(txtEndPrices.Text, out endPrices);

            ArrayList bigScooter = new ArrayList();
            bigScooter.Add(new BigScooter { ID = "A001", Name = "[SYM] GTS300i", Prices = 192000 });
            bigScooter.Add(new BigScooter { ID = "A002", Name = "[KYMCO] XCITING 300 ", Prices = 158000 });
            bigScooter.Add(new BigScooter { ID = "A003", Name = "[HONDA] NC700D ABS (INTEGRA)", Prices = 458000 });
            bigScooter.Add(new BigScooter { ID = "A004", Name = "[KYMCO] NIKITA 300 ABS", Prices = 208000 });
            bigScooter.Add(new BigScooter { ID = "A005", Name = "[YAMAHA] T-MAX 530 ABS", Prices = 538000 });
            bigScooter.Add(new BigScooter { ID = "A006", Name = "[BMW] C600", Prices = 560000 });

            var scooterQuery = from BigScooter scooter in bigScooter
                               where scooter.Prices >= startPrices
                                      && scooter.Prices <= endPrices
                               select scooter;

            string msg = "大綿羊價格介於" + txtStartPrice.Text +"元~" + txtEndPrices.Text   +"元之間車種:\n";
            int i = 0;
            foreach (BigScooter bigSheep in scooterQuery)
            {
                i = i + 1;
                msg = msg + i + ". " + bigSheep.Name + "=" + bigSheep.Prices + "元\n";
            }
            msg = msg + "共找到:" + i + "台符合條件資料.";
            MessageBox.Show(msg, "LINQ to Objects");
        }
    }
    public class BigScooter
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Prices { get; set; }
    }
}
