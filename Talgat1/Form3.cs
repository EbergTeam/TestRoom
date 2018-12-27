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
        public class classFigure //общий класс свойств
        {
            public int x1, y1, x2, y2;
            public int typeOfFigure;
            public void choiceFigure(int _in)//что ты хотел с этим сделать??????????????????????????????
            {
                typeOfFigure = _in;
            }
        }
        
        public class classRectangle : classFigure
        {
            public void drawRectangle(Graphics a) //отрисовка прямоугольника
            {
                a.DrawRectangle(new Pen(Brushes.Black, 2), x1, y1, x2 - x1, y2 - y1);
            }
        }
        public class classEllipse : classFigure
        {
            public void drawEllipse(Graphics a) //отрисовка элипса
            {
                a.DrawEllipse(new Pen(Brushes.Black, 2), x1, y1, x2 - x1, y2 - y1);
            }
        }
        public class classRound : classFigure
        {
            public void drawRound(Graphics a) //отрисовка круга
            {
                a.DrawEllipse(new Pen(Brushes.Black, 2), x1, y1, x2 - x1, x2 - x1);
            }
        }
        public class classLine : classFigure
        {
            public void drawLine(Graphics a) //отрисовка линии
            {
                a.DrawLine(new Pen(Brushes.Black, 2), x1, y1, x2, y2);
            }
        }
        public class classTriangle : classFigure
        {
            public void drawTriangle(Graphics a) //отрисовка треугольника
            {
                Point[] points = { new Point(x1, y1), new Point(x1, y2), new Point(x2, y1), new Point(x1, y1) };
                a.DrawLines(new Pen(Brushes.Black, 2), points);
            }
        }

        classFigure objectFigure = new classFigure();
        classRectangle objectRectangle = new classRectangle(); 
        classEllipse objectEllipse = new classEllipse();
        classRound objectRound = new classRound();
        classLine objectLine = new classLine();
        classTriangle objectTriangle = new classTriangle();
  
        public Form3()
        {
            InitializeComponent();
        }
        public void button1_Click(object sender, EventArgs e) //отрисовка прямоугольника
        {
             objectFigure.choiceFigure(1);
        }
        private void button2_Click(object sender, EventArgs e) //отрисовка элипса
        {
            objectFigure.choiceFigure(2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            objectFigure.choiceFigure(3);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            objectFigure.choiceFigure(4);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            objectFigure.choiceFigure(5);
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e) //фиксирование начала координат для элемента
        {
            textBox3.Text = (objectFigure.x1 = e.X).ToString();
            textBox4.Text = (objectFigure.y1 = e.Y).ToString();
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e) 
        {
            textBox5.Text = (objectFigure.x2 = e.X).ToString();
            textBox6.Text = (objectFigure.y2 = e.Y).ToString();
            Graphics g = Graphics.FromHwnd(panel1.Handle);

            switch (objectFigure.typeOfFigure)
            {
                case 1:
                    objectRectangle.drawRectangle(g);
                    break;
                case 2:
                    objectEllipse.drawEllipse(g);
                    break;
                case 3:
                    objectRound.drawRound(g);
                    break;
                case 4:
                    objectLine.drawLine(g);
                    break;
                case 5:
                    objectTriangle.drawTriangle(g);
                    break;
                default:
                    break;
            }
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = e.X.ToString();
            textBox2.Text = e.Y.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.White; //работает на раз
        }
    }
}
