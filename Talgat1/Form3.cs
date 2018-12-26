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
    public partial class Form3 : Form
    {
        public class Figure //все элементы
        {
            //public bool doDraw;
            public int X1, Y1, X2, Y2; //общие свойства всех элементов
            public int TypeOfFigure;
            
            public void DrawRectangle(Graphics a) //отрисовка прямоугольника
            {
                a.DrawRectangle(new Pen(Brushes.Black, 2), X1, Y1, X2-X1, Y2-Y1);
            }
            public void DrawEllipse(Graphics a) //отрисовка элипса
            {
                //a.DrawEllipse(new Pen(Brushes.Black, 2), X, Y, (deltaX - X), (deltaY - Y));
                //a.FillEllipse(new SolidBrush(Color.Red), X, Y, (deltaX - X), (deltaY - Y));
                a.DrawEllipse(new Pen(Brushes.Black, 2), X1, Y1, X2-X1, Y2-Y1);
            }
            public void DrawRound(Graphics a) //отрисовка круга
            {
                a.DrawEllipse(new Pen(Brushes.Black, 2), X1, Y1, X2 - X1, X2 - X1);
            }
            public void DrawLine(Graphics a) //отрисовка линии
            {
                a.DrawLine(new Pen(Brushes.Black, 2), X1, Y1, X2, Y2);
            }
            public void DrawLines(Graphics a) //отрисовка линии
            {
                Point[] points = {new Point(X1,Y1), new Point(X1,Y2), new Point(X2,Y1), new Point(X1,Y1)};
                a.DrawLines(new Pen(Brushes.Black, 2), points);
            }
        }

        Figure figure = new Figure();

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //отрисовка прямоугольника
        {
            figure.TypeOfFigure = 1;
        }

        private void button2_Click(object sender, EventArgs e) //отрисовка элипса
        {
            figure.TypeOfFigure = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            figure.TypeOfFigure = 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            figure.TypeOfFigure = 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            figure.TypeOfFigure = 5;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e) //фиксирование начала координат для элемента
        {
            textBox3.Text=(figure.X1 = e.X).ToString();
            textBox4.Text = (figure.Y1 = e.Y).ToString();
            //figure.doDraw = true;
        }
        
        private void panel1_MouseUp(object sender, MouseEventArgs e) 
        {
            textBox5.Text = (figure.X2 = e.X).ToString();
            textBox6.Text = (figure.Y2 = e.Y).ToString();
            //figure.doDraw = false;
            Graphics g = Graphics.FromHwnd(panel1.Handle);
            switch (figure.TypeOfFigure)
            {
                case 1:
                    figure.DrawRectangle(g);
                    break;
                case 2:
                    figure.DrawEllipse(g);
                    break;
                case 3:
                    figure.DrawRound(g);
                    break;
                case 4:
                    figure.DrawLine(g);
                    break;
                case 5:
                    figure.DrawLines(g);
                    break;
                default:
                    break;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = e.X.ToString();
            textBox2.Text = e.Y.ToString();

            /*Graphics g = Graphics.FromHwnd(panel1.Handle);
            if (figure.doDraw)
            {
                switch (figure.TypeOfFigure)
                {
                    case 1:
                        figure.DrawRectangle(g);
                        break;
                    case 2:
                        figure.DrawRound(g, e.X, e.Y);
                        break;
                    default:
                        break;
                }
            }*/
        }
        private void button4_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.White;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
