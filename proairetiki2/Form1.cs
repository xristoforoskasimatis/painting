using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proairetiki2
{
    public partial class Form1 : Form
    {
        Pen p;
        Graphics g;
        float x1, y1;
        bool draw,b1,b2,b3,b4,b5,b6,b7,b8,b9;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

            draw = true;
            x1 = e.X;
            y1 = e.Y;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            b1 = true;
            p.Color = Color.Blue;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            b6 = true;
            p.Color = Color.Red;
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            b5 = true;
            p.Color = Color.Black;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            b4 = true;
            p.Color = Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            b3 = true;
            p.Color = Color.Yellow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b2 = true;
            p.Color = Form1.DefaultBackColor;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            b9 = true;
            p.Width = 3;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            b8 = true;
            p .Width=5;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            p = new Pen(Color.Black);
            p.Width = 1;
            label1.Text = "";
            label2.Text = "";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = e.X.ToString();
            label2.Text = e.Y.ToString();
           
            if ((draw)&&(b1||b2||b3||b4||b5)&&(b7||b8||b9))
            {
                g.DrawLine(p, x1, y1, e.X, e.Y);
                x1 = e.X;
                y1 = e.Y;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            b7 = true;
            p.Width = 7;
        }
    }
}
