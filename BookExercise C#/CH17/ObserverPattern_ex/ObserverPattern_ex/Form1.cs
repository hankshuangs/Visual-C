using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverPattern_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNotify_Click(object sender, EventArgs e)
        {
             
            ConcreteSubject s = new ConcreteSubject();

           
            s.Attach(new ConcreteObserver(s, "郝龍斌"));
            s.Attach(new ConcreteObserver(s, "胡自強"));
            s.Attach(new ConcreteObserver(s, "陳菊"));

            
            s.SubjectState = "已經做好防颱準備!!";
            s.Notify();
        }
    }

     
    public interface iSubject
    {
        void Attach(iObserver observer);
        void Detach(iObserver observer); 
        void Notify();
    }

    
    class ConcreteSubject : iSubject
    {
        private string subjectState;
        private bool changed;      
         
        public string SubjectState
        {
            get { return subjectState; }
            set { subjectState = value; }
        }

        private System.Collections.ArrayList observers = new System.Collections.ArrayList();

        
        public void Attach(iObserver observer)
        {
            observers.Add(observer);
            if (observers.Count >= 1)
            {
                this.changed = true;
            }
            else
            {
                this.changed = false;
            }
        }

        
        public void Detach(iObserver observer)
        {
            observers.Remove(observer);
            if (observers.Count >= 1)
            {
                this.changed = true;
            }
            else
            {
                this.changed = false;
            }
        }

       
        public void Notify()
        {
            if (changed == true)
            {
                foreach (iObserver o in observers)
                {
                    o.Update();
                }
            }
            this.changed = false;
        }

    }

     
    public interface iObserver
    {
        void Update();
    }

    
    class ConcreteObserver : iObserver
    {
        private string User;
        private string observerState;
        private ConcreteSubject subject;

         
        public ConcreteObserver(ConcreteSubject subject, string user)
        {
            this.subject = subject;
            this.User = user;
        }

         
        public ConcreteSubject Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        public void Update()
        {
            observerState = subject.SubjectState;
            MessageBox.Show(string.Format("觀察者[ {0} ] 目前處理狀況是: [{1}]", User, observerState));
        }

    }

}
