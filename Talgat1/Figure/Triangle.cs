using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Talgat1.Figure
{
    public class Triangle : Figure
    {
        public override void Draw(Graphics a)
        {
            Point[] points = { new Point(x1, y1), new Point(x1, y2), new Point(x2, y1), new Point(x1, y1) };
            a.DrawLines(new Pen(Brushes.Black, 2), points);
        }
    }
}
