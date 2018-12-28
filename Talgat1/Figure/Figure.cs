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
    public abstract class BaseFigure
    {
        public int x1, y1, x2, y2;
        public Color borderСolor; // именуй правильно. СловаИзДвухСловДелятсяБольшимиБуквами
                                  // то что отмечено как public, всегда должно начинаться с большой буквы.
        public abstract void Draw(Graphics a);
    }
}
