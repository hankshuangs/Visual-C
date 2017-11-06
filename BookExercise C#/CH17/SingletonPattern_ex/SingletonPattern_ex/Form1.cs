using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingletonPattern_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            SingletonServiceManager.Instance.Run();
            SingletonServiceManager.Instance.Exit();

            //以下方法無法使用，確保SingletonServiceManager類別只會被new一次
            //SingletonServiceManager ssm = new SingletonServiceManager();
            //ssm.Run();
        }
    }

    public sealed class SingletonServiceManager
    {
        private static SingletonServiceManager manager;
        private static object syncRoot = new Object();

        static SingletonServiceManager()
        {
            MessageBox.Show("1.執行靜態建構式");
        }

        SingletonServiceManager()
        {
            MessageBox.Show("2.執行建構式");
        }

        public static SingletonServiceManager Instance
        {
            get
            {
                lock (syncRoot)
                {
                    if (manager == null)
                    {
                        manager = new SingletonServiceManager();
                    }
                    return manager;
                }

            }
        }

        public void Run()
        {
            MessageBox.Show("服務啟動中....");
        }

        public void Exit()
        {
            MessageBox.Show("服務停止中....");
        }
    }

}
