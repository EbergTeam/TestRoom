﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Talgat1
{
    public partial class Form1 : Form
    {

        bool doDraw;
        public Form1()
        {
            InitializeComponent();
            doDraw = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            doDraw = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (doDraw)
            {
                //Graphics g = Graphics.FromHwnd(Handle);
                Graphics g = Graphics.FromHwnd(panel1.Handle);
                SolidBrush redBrush = new SolidBrush(Color.Red);
                g.FillEllipse(redBrush, e.X, e.Y, 10, 10);
                
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            doDraw = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
