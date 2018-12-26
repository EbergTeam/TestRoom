using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Talgat1
{
    public partial class Form2 : Form
    {
        public string text;
        public Form2()
        {
            InitializeComponent();
            text = "Тест";
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            g.DrawString(text, new Font("Helvetica", 15),Brushes.Black, 0, 0);
            g.DrawRectangle(new Pen(Brushes.Black, 2), 10, 30, 200, 100);
            g.DrawEllipse(new Pen(Brushes.Black, 2), 150, 120, 100, 130);
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
