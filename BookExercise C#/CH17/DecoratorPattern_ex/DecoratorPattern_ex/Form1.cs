using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecoratorPattern_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOriginal_Click(object sender, EventArgs e)
        {
 
            ConcreteComponent cc = new ConcreteComponent();
            cc.operation();
        }

        private void btnExpansion_Click(object sender, EventArgs e)
        {
            
            ConcreteComponent cc = new ConcreteComponent();
            ConcreteDecoratorA CDA = new ConcreteDecoratorA(cc);
            ConcreteDecoratorB CDB = new ConcreteDecoratorB(cc);
            CDA.operation();
            CDB.operation();
        }
    }

    
    public interface iComponent
    {
        void operation();
    }

   
    class ConcreteComponent : iComponent
    {
        public void operation()
        {
            MessageBox.Show("Check file format:", "ConcreteComponent");
        }
    }

    
    public abstract class Decorator : iComponent
    {
        private iComponent component;
        public Decorator()
        {
            this.component = null;
        }
        public Decorator(iComponent component)
        {
            this.component = component;
        }

        public virtual void operation()
        {
            if (component != null)
            {
                component.operation();
            }
        }
    }

    
    class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA()
        {
        }
        public ConcreteDecoratorA(iComponent icomponent)
            : base(icomponent)
        {
        }
        private string ProcessStatus { get; set; }

        public override void operation()
        {
            base.operation();
            ProcessStatus = "Sucessfully!!";
            MessageBox.Show("Process files " + ProcessStatus, "ConcreteDecoratorA");
        }
    }

    
    class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(iComponent icomponent)
            : base(icomponent)
        {
        }
        public override void operation()
        {
            base.operation();
            CheckFieldValue();
            MessageBox.Show("File's contents is correct!!", "ConcreteDecoratorB");
        }
        
        void CheckFieldValue()
        {
            MessageBox.Show("Check the file contents of the field values.", "ConcreteDecoratorB");
        }
    }

}
