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
        private string[] colorsNames;
        private Color[] colors;
        private int index;
        private Graphics graphics;
        private List<BaseFigure> figureConteiner = new List<BaseFigure>();
        private int currentFigureType = 1;
        private Color currentBorderColor = Color.Black;

        public Form3()
        {
            InitializeComponent();
            colorsNames = new string[3] { "Красный", "Синий", "Зеленый" };
            colors = new Color[3] { Color.Red, Color.Blue, Color.Green };
            comboBox1.Items.AddRange(colorsNames);
            comboBox1.SelectedIndex = 0;
            index = 0;
            graphics = panel1.CreateGraphics();
            panel1.BackColor = Color.White;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        public void selectFigure_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            currentFigureType = int.Parse(button.Tag.ToString());
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e) //фиксирование начала координат для элемента
        {
            switch (currentFigureType)
            {
                case 1:
                    currentFigure = new Figure.Rectangle(currentBorderColor);
                    break;

                case 2:
                    currentFigure = new Ellipse(currentBorderColor);
                    break;

                case 3:
                    currentFigure = new Round(currentBorderColor);
                    break;

                case 4:
                    currentFigure = new Line(currentBorderColor);
                    break;

                case 5:
                    currentFigure = new Triangle(currentBorderColor);
                    break;

                default:
                    break;
            }

            textBox3.Text = (currentFigure.x1 = e.X).ToString(); // никогда не пиши так (currentFigure.x1 = e.X).ToString();
            textBox4.Text = (currentFigure.y1 = e.Y).ToString(); // пиши раздельно.

            figureConteiner.Add(currentFigure);

            ReDrawAllFigures();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (currentFigure is null) return;

            currentFigure.x2 = e.X;
            currentFigure.y2 = e.Y;

            textBox1.Text = e.X.ToString();
            textBox2.Text = e.Y.ToString();

            ReDrawAllFigures();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (currentFigure is null) return;

            currentFigure.x2 = e.X;
            currentFigure.y2 = e.Y;

            textBox5.Text = e.X.ToString();
            textBox6.Text = e.Y.ToString();

            ReDrawAllFigures();

            currentFigure = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RemoveAllFigures();
        }

        private void ReDrawAllFigures()
        {
            ClearGraphics();
            foreach (var figure in figureConteiner)
                figure.Draw(graphics);
        }

        private void ClearGraphics() =>           //погугли зачем тут стрелка. Полезно новое узнать, не сможешь найти, забей, сам объясню
            graphics?.Clear(Color.White); // тоже самое со значком ?

        private void RemoveAllFigures()
        {
            figureConteiner.Clear();
            ClearGraphics();
        }

        private void BorderColorChanged(object sender, EventArgs e)
        {
            index = comboBox1.SelectedIndex;
            label6.Text = index.ToString();
            currentBorderColor = colors[index];
        }
    }
}