using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrategyPattern_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSQL_Click(object sender, EventArgs e)
        {
            SourceStrategy ss = new SQLSource();
            ss.runFindString();
        }

        private void btnHbase_Click(object sender, EventArgs e)
        {
            SourceStrategy ss = new HBaseSource();
            ss.runFindString();
        }

        private void btnDynamicSetting_Click(object sender, EventArgs e)
        {
            SourceStrategy ss = new HBaseSource();
            
            ss.setIFindString(new FindWithBigData());
            ss.runFindString();

            //同上述功能
            //SourceStrategy ss = new HBaseSource("Cassandra");
            //ss.runFindString();
        }
    }


    
    public abstract class SourceStrategy
    {
        public iFindString IFindString;
        public SourceStrategy() { }
        
        public SourceStrategy(iFindString fs)
        {
            this.IFindString = fs;
        }
        
        public void runFindString()
        {
            IFindString.FindString();
        }
        
        public void setIFindString(iFindString fb)
        {
            IFindString = fb;
        }
    }

    
    public interface iFindString
    {
        void FindString();
    }

    
    public class SQLSource : SourceStrategy
    {
        public SQLSource()
        {
            this.IFindString = new FindWithSQL();
        }
    }

    public class HBaseSource : SourceStrategy
    {
        public HBaseSource()
        {
            this.IFindString = new FindWithHBase();
        }
        
        public HBaseSource(string DBType)
        {
            if (DBType == "Cassandra")
            {
                this.IFindString = new FindWithBigData();
            }
            else
            {
                this.IFindString = new FindWithHBase();
            }
        }

    }

    
    public class FindWithSQL : iFindString
    {
        public void FindString()
        {
            MessageBox.Show(@"String finding from SQL !!", "FindWithSQL");
        }
    }

    
    public class FindWithHBase : iFindString
    {
        public void FindString()
        {
            MessageBox.Show(@"String finding from HBase !!", "FindWithHBase");
        }
    }

    
    public class FindWithBigData : iFindString
    {
        public void FindString()
        {
            MessageBox.Show(@"String finding from BigData !!", "FindWithBigData");
        }
    }
   

}
