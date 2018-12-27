using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

/*
Реализовать векторный графический редактор.То есть подобие Paint, чтобы на нем можно было рисовать 
фигуры(круг, элипс, прямоугольник, линия, точка, + одна фигура состоящая из составных линий, например треугольник). 
Как происходить рисовка, нажимаешь кнопу, нажимаешь в нужном месте экрана и тянешь, увеличивая размер.отпускаешь фигура сохраняется
Следующим этапом будет возможность двигать фигуры, изменять размер, сохранять в файл и считывать. Группировка
*/

namespace Talgat1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new Form2());
            Application.Run(new Form3());
            //Test
        }
    }
}
