using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Talgat1.Figure;

namespace Talgat1
{
    public partial class Form3 : Form
    {
        private BaseFigure currentFigure = null;
        string[] colorsNames;
        Color[] colors;
        int index;

        public Form3()
        {
            InitializeComponent();
            colorsNames = new string[3] { "Красный", "Синий", "Зеленый" };
            colors = new Color[3] { Color.Red, Color.Blue, Color.Green };
            comboBox1.Items.AddRange(colorsNames);
            comboBox1.SelectedIndex = 0;
            index = 0;
        }

        public void selectFigure_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            int typeFigure = int.Parse(button.Tag.ToString());
            index = comboBox1.SelectedIndex;
            label6.Text = index.ToString();

            switch (typeFigure)
            {
                case 1:
                    currentFigure = new Figure.Rectangle(colors[index]);
                    break;

                case 2:
                    currentFigure = new Ellipse(colors[index]);
                    break;

                case 3:
                    currentFigure = new Round(colors[index]);
                    break;

                case 4:
                    currentFigure = new Line(colors[index]);
                    break;

                case 5:
                    currentFigure = new Triangle(colors[index]);
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

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}