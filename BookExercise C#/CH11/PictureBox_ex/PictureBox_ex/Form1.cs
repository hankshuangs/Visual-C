using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Load("../../images/PG20301.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void cboBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboBooks.SelectedItem.ToString())
            {
                case "Visual C#2010 程式設計實例演練與系統開發":
                    if (rdoLocal.Checked == true)
                    {
                        pictureBox1.Image = Properties.Resources.PG20301;
                    }
                    else
                    {
                        pictureBox1.ImageLocation = "http://www.drmaster.com.tw/Cover/PG20301.jpg";
                    }
                    break;
                case "Visual Basic 2008程式設計經典教本":
                    if (rdoLocal.Checked == true)
                    {
                        pictureBox1.Image = Properties.Resources.PG20282;
                    }
                    else
                    {
                        pictureBox1.ImageLocation = "http://www.drmaster.com.tw/Cover/PG20282.jpg";
                    }
                    break;
                case "Java視窗應用程式設計與SCJP認證實戰演練":
                    if (rdoLocal.Checked == true)
                    {
                        pictureBox1.Image = Properties.Resources.PG20262;
                    }
                    else
                    {
                        pictureBox1.ImageLocation = "http://www.drmaster.com.tw/Cover/PG20262.jpg";
                    }
                    break;
                case "e世代必學實用軟體密技應用實務":
                    if (rdoLocal.Checked == true)
                    {
                        pictureBox1.Image = Image.FromFile(@"../../images/IN20035.jpg");
                    }
                    else
                    {
                        pictureBox1.Load("http://www.drmaster.com.tw/Cover/IN20035.jpg");
                    }
                    break;
                case "Windows Mobile 6應用程式設計與操控實務":
                    if (rdoLocal.Checked == true)
                    {
                        pictureBox1.Image = Properties.Resources.PG20259;
                    }
                    else
                    {
                        pictureBox1.Load("http://www.drmaster.com.tw/Cover/PG20259.jpg");
                    }
                    break;
                case "Visual Basic 2005 進銷存系統開發實務設計":
                    if (rdoLocal.Checked == true)
                    {
                        pictureBox1.ImageLocation = "../../images/PG20245.jpg";
                    }
                    else
                    {
                        pictureBox1.Load("http://www.drmaster.com.tw/Cover/PG20245.jpg");
                    }
                    break;
                default:
                    pictureBox1.Load("../../images/PG20301.jpg");
                    break;
            }
        }

        private void cboSizeMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboSizeMode.SelectedIndex)
            {
                case 0:
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 1:
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case 2:
                    pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                    break;
                case 4:
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
            }
        }
    }
}
