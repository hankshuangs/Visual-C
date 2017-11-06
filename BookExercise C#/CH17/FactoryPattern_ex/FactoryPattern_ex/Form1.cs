using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryPattern_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string fileExtension = cboFileType.Text;
            if (fileExtension != "")
            {
                
                var Processor = FileProcessorFactory.getInstance(fileExtension);
                string result = Processor.Open();
                MessageBox.Show(result,Processor.GetType().Name);
                Processor.Close();
            }
        }
    }

    
    abstract class FileProcessor
    {
        public abstract string Open();
        //public abstract string Modify();
        //public abstract string Delete();
        public void Close() 
        {
            MessageBox.Show("Close file", "Close()");
        }
        
        ~FileProcessor()
        {
            MessageBox.Show("Object release", "~FileProcessor()");
        }
    }

    
    class XMLFileProcessor : FileProcessor
    {
        public override string Open()
        {
            //throw new NotImplementedException();
            return "Open XML file";
        }
    }

    
    class TXTFileProcessor : FileProcessor
    {
        public override string Open()
        {
            //throw new NotImplementedException();
            return "Open TXT file";
        }
    }

   
    class XLSFileProcessor : FileProcessor
    {
        public override string Open()
        {
            //throw new NotImplementedException();
            return "Open XLS file";
        }
    }

   
    static class FileProcessorFactory
    {
        public static FileProcessor getInstance(string fileformat)
        {
            switch (fileformat )
            {
                case "TXT":
                    return new TXTFileProcessor();
                case "XML":
                    return new XMLFileProcessor();
                case "XLS":
                    return new XLSFileProcessor();
                default:
                    return new TXTFileProcessor();
            }

        }
    }

}
