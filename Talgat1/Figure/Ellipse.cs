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
    public class Ellipse : BaseFigure
    {
        public Ellipse(Color _in)
        {
            borderСolor = _in;
        }
        public override void Draw(Graphics a)
        {
            a.DrawEllipse(new Pen(borderСolor, 2), x1, y1, x2 - x1, y2 - y1);
        }
    }
}
