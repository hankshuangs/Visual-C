using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandPattern_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
           
            InvokerCommand invokeCmd = new InvokerCommand(2);
            BusinessCheckCommand bcc = new BusinessCheckCommand();

            IdentityChecksCommand identityChecks = new IdentityChecksCommand(bcc);
            DoCheckCommand doCheck = new DoCheckCommand(bcc);

            invokeCmd.setCommand(0, identityChecks);
            invokeCmd.setCommand(1, doCheck);

            invokeCmd.runAllCommands();
        }

        private void btnVIP_Click(object sender, EventArgs e)
        {
            
            InvokerCommand invokeCmd = new InvokerCommand(1);
            BusinessCheckCommand bcc = new BusinessCheckCommand();

            IdentityChecksCommand identityChecks = new IdentityChecksCommand(bcc);
            invokeCmd.setCommand(0, identityChecks);

            invokeCmd.runCommand(0);;
        }
    }

    /// <summary>
    /// 所有命令都要實現的介面
    /// </summary>
    public interface iCommand
    {
        void execute();
        //void undo();//設計復原機制
        //void save();
        //void load();
    }

    
    public class BusinessCheckCommand
    {
        public void IdentityChecks()
        {
            MessageBox.Show("身分查核!!", "IdentityChecks()");
        }

        public void DoCheck()
        {
            MessageBox.Show("行李檢查!!", "DoCheck()");
            MessageBox.Show("護照檢查!!", "DoCheck()");
        }
    }

    
    public class IdentityChecksCommand : iCommand
    {
        private BusinessCheckCommand businessCheckCommand;
        public IdentityChecksCommand(BusinessCheckCommand bcc)
        {
            this.businessCheckCommand = bcc;
        }

        public void execute()
        {
            businessCheckCommand.IdentityChecks();
        }
    }
    
    public class DoCheckCommand : iCommand
    {
        private BusinessCheckCommand businessCheckCommand;
        public DoCheckCommand(BusinessCheckCommand bcc)
        {
            this.businessCheckCommand = bcc;
        }

        public void execute()
        {
            businessCheckCommand.DoCheck();
        }
    }
    
    public class NoCommand : iCommand
    {
        public void execute()
        {
            MessageBox.Show("Nothing to do.", "NoCommand");
        }
    }
    
    public class InvokerCommand
    {
        private iCommand[] commands;

        public InvokerCommand()
        {
            commands = new iCommand[1];
            commands[0] = new NoCommand();
        }

        public InvokerCommand(int num)
        {
            commands = new iCommand[num];
            for (int i = 0; i < commands.Length; i++)
            {
                commands[i] = new NoCommand();
            }
        }
        
        public void setCommand(int slot, iCommand cmd)
        {
            commands[slot] = cmd;
        }
        
        public void runCommand(int slot)
        {
            commands[slot].execute();
        }
        
        public void runAllCommands()
        {
            for (int i = 0; i < commands.Length; i++)
            {
                commands[i].execute();
            }
        }

    }

}
