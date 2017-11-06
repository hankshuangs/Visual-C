using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdapterPattern_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            Adaptee adaptee = new Adaptee();
            adaptee.fileName = "MyExcel.xls";
            adaptee.SpecificRequest();
        }

        private void btnAdapterProcess_Click(object sender, EventArgs e)
        {
            
            iTarget target = new Adapter();
            target.fileName = "MyExcel.xls";
            target.Request();
        }
    }

   
    class Adaptee
    {
        
        public string fileName;
        public void SpecificRequest()
        {
            if (fileName.IndexOf(".csv") != -1)
            {
                MessageBox.Show("Open csv files to process.", "Successfully");
            }
            else
            {
                MessageBox.Show("Unable to process this file [file format error].", "Failure");
            }
        }
    }

    
    interface iTarget
    {
        
        void Request();
        string fileName { get; set; }
    }


    
    class Adapter : Adaptee, iTarget
    {
        public new string fileName
        {
            get;
            set;
        }
        public void Request()
        {
           
            base.fileName = CovertToCSV(this.fileName);
            
            this.SpecificRequest();
        }

        public string CovertToCSV(string fileName)
        {
            base.fileName = fileName.Replace(".xml", ".csv").Replace(".xls", ".csv").Replace(".txt", ".csv");
            string msg = "All files transform to CSV file.\nProcess Result:";
            msg = msg + fileName + " to " + base.fileName;
            MessageBox.Show(msg , "轉接器處理");
            return base.fileName;
        }
    }

}
