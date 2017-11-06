using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;//for LINQ to XML
namespace LINQtoXML_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string xmlPath = Application.StartupPath + @"\inventory.xml";
            XDocument doc = XDocument.Load(xmlPath);

            var query = from c in doc.Element("items")
                                     .Elements("item")
                        where
                             c.Element("description").ToString().IndexOf("Hadoop") != -1
                             && (int)c.Element("price") <= 650
                        select c;

            string result = "";

            foreach (var obj in query)
            {
                result = result + obj + "\n";
            }

            MessageBox.Show(result, "LINQ to XML");
        }
    }
}
