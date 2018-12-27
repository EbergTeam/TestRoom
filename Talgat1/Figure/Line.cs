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
    public class Line : BaseFigure
    {
        public override void Draw(Graphics a)
        {
            a.DrawLine(new Pen(Brushes.Black, 2), x1, y1, x2, y2);
        }
    }
}
