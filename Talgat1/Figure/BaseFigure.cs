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

        public BaseFigure(Color borderСolor)//именуй правильно _in не сообщает о том, зачем нужна эта переменная
        {
            _borderСolor = borderСolor; // вынес конструктор отдельно, потому что все равно  делается везде одно и тоже
        }

        private Color _borderСolor; // именуй правильно. СловаИзДвухСловДелятсяБольшимиБуквами
                                    // то что отмечено как public, всегда должно начинаться с большой буквы.

        public Color BorderColor
        {
            get { return _borderСolor; }  // за одно просматри, зачем нужны вот эти get; set;
            set { _borderСolor = value; }
        }

        public abstract void Draw(Graphics graphics);
    }
}