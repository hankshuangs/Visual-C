using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;//need import Microsoft.VisualBasic.dll
using Microsoft.VisualBasic.Devices;//need import Microsoft.VisualBasic.dll

namespace FacadePattern_ex
{
    
    public class my
    {
        Applications app;
        Computers pc;

        public my()
        {
            this.app = new Applications();
            this.pc = new Computers();
        }

        public Applications Applications
        {
            get
            {
                return app;
            }
        }

        public Computers Computers
        {
            get
            {
                return pc;
            }
        }

    }

   
    public class Applications
    {
        private WindowsFormsApplicationBase MyApplication;

        public Applications()
        {
            MyApplication = new WindowsFormsApplicationBase();
        }

        public AssemblyInfo Info
        {
            get
            {
                AssemblyInfo Info = new AssemblyInfo(System.Reflection.Assembly.GetExecutingAssembly());
                return Info;
            }
        }
    }

   
    public class Computers
    {
        private ComputerInfo computerInfo;

        public Computers()
        {
            this.computerInfo = new ComputerInfo();
        }

        public ComputerInfo Info
        {
            get
            {
                ComputerInfo cInfo = new ComputerInfo();
                return cInfo;
            }
        }

    }
}
