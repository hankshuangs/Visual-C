using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iterator_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowBooks_Click(object sender, EventArgs e)
        {
            MyBooks MyBookCollections = new MyBooks();
            string msg = "";

            foreach (var book in MyBookCollections)
            {
                msg = msg + book + "\n";
            }

            MessageBox.Show(msg, "許清榮的電腦相關著作");
        }

        public class MyBooks : System.Collections.IEnumerable
        {
            public System.Collections.IEnumerator GetEnumerator()
            {
                yield return "1.Java視窗應用程式設計與SCJP認證實戰演練";
                yield return "2.e世代必學實用軟體密技應用實務";
                yield return "3.Windows Mobile 6應用程式設計與操控實務";
                yield return "4.Visual Basic 2005 進銷存系統開發實務設計";
                yield return "5.Pocket PC裝置應用程式開發秘笈";
                yield return "6.Visual C#2005建構資訊系統實戰經典教本";
                yield return "7.Visual Basic 2005 Express程式設計經典教本";
                yield return "8.Visual C#2008 程式設計實例演練與系統開發";
                yield return "9.Visual Basic 2008程式設計經典教本";
                yield return "10.部落格•網誌人氣排名提升與行銷的不傳秘技";
                yield return "11.Visual C#2010 程式設計實例演練與系統開發";
                yield return "12.掌握Hadoop翱翔雲端-Windoop應用實作指南";
                yield return "13.新一代Visual Basic 2005程序设计";
                yield return "14.亮剑.NET.Visual C# 2008实例演练与系统开发";
            }
        }
    }
}
