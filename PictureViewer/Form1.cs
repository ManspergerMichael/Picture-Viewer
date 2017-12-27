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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close(); //closes the instance of the program
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //set background color of picture box to the selected color
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //removes selected picture
            pictureBox1.Image = null;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //open file diolog box, user searches and selects a picture file
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if checkbox is checked, PictueBox's size mode property is set to strech
            //if box is cleared, set sizemode to normal
            if (checkBox1.Checked)
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
