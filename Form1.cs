using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        //Show the picture in the picture box
        private void btnShowPic_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        //Clear the picture in the picture box
        private void btnClearPic_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        //Open the color dialog to set the background color of the picture box
        private void btnSetBackgroundColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        //Clear the background color of the picture box
        private void btnClear_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }


        private void checkBoxStretch_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxStretch.Checked == true)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    }
}
