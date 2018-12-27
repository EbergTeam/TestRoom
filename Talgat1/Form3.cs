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
        private Figure currentFigure = null;

        public Form3()
        {
            InitializeComponent();
        }

        public void selectFigure_Click(object sender, EventArgs e) //отрисовка прямоугольника
        {
            var button = sender as Button;
            int typeFigure = int.Parse(button.Tag.ToString());
            
            switch (typeFigure)
            {
                case 1:
                    currentFigure = new Rectangle();
                    break;

                case 2:
                    currentFigure = new Ellipse();
                    break;

                case 3:
                    currentFigure = new Round();
                    break;

                case 4:
                    currentFigure = new Line();
                    break;

                case 5:
                    currentFigure = new Triangle();
                    break;

                default:
                    break;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e) //фиксирование начала координат для элемента
        {
            if (currentFigure is null) return;

            textBox3.Text = (currentFigure.x1 = e.X).ToString();
            textBox4.Text = (currentFigure.y1 = e.Y).ToString();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (currentFigure is null) return;

            textBox5.Text = (currentFigure.x2 = e.X).ToString();
            textBox6.Text = (currentFigure.y2 = e.Y).ToString();
            Graphics g = Graphics.FromHwnd(panel1.Handle);
            currentFigure.Draw(g);
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