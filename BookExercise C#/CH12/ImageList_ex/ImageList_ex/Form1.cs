using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageList_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ImageList il = new ImageList();
        int x = 0, y = 1, z = 2;
        private void Form1_Load(object sender, EventArgs e)
        {
            il.ColorDepth = ColorDepth.Depth32Bit;
            il.ImageSize = new Size(250, 190);
            il.Images.Add(Image.FromFile("../../images/Elva01.jpg"));
            il.Images.Add(Image.FromFile("../../images/Elva02.jpg"));
            il.Images.Add(Image.FromFile("../../images/Elva03.jpg"));
            il.Images.Add(Image.FromFile("../../images/Elva04.jpg"));
            il.Images.Add(Image.FromFile("../../images/Elva05.jpg"));
            il.Images.Add(Image.FromFile("../../images/Elva06.jpg"));
            pictureBox1.Image = il.Images[x];
            pictureBox2.Image = il.Images[y];
            pictureBox3.Image = il.Images[z];
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            int max = il.Images.Count - 1;
            if (x < max) { x = x + 1; }
            else { x = 0; }

            if (y < max) { y = y + 1; }
            else { y = 0; }

            if (z < max) { z = z + 1; }
            else { z = 0; }

            pictureBox1.Image = il.Images[x];
            pictureBox2.Image = il.Images[y];
            pictureBox3.Image = il.Images[z];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int min = 0;
            if (x > min) { x = x - 1; }
            else { x = il.Images.Count - 1; }

            if (y > min) { y = y - 1; }
            else { y = il.Images.Count - 1; }

            if (z > min) { z = z - 1; }
            else { z = il.Images.Count - 1; }

            pictureBox1.Image = il.Images[x];
            pictureBox2.Image = il.Images[y];
            pictureBox3.Image = il.Images[z];
        }

    
    }
}
