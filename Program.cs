using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        class Tri
        {
            public int[] xp;
            public int[] yp;
            public int x;
            public int y;
            public int npol;


            public int Triangle(int npol, int[] xp, int[] yp, int x, int y)
            {
                int c = 0;
                for (int i = 0, j = npol - 1; i < npol; j = i++)
                {
                    if ((((yp[i] <= y) && (y < yp[j])) || ((yp[j] <= y) && (y < yp[i]))) &&
                      (x > (xp[j] - xp[i]) * (y - yp[i]) / (yp[j] - yp[i]) + xp[i]))
                        c = 1 - c;
                }
                return c;
            }

            public bool Res()
            {
                Tri t = new Tri();

                xp = new int[] { 0, 2, 4 }; // массив х вершин треугольника
                yp = new int[] { 0, 2, 2 }; // массив  у вершин треугольника
                x = 2;  // координата x точки 
                y = 1; // координата y точки 
                npol = xp.Length;
                int res = t.Triangle(npol, xp, yp, x, y);

                if (res == 1) // точка внутри
                {
                    return true;
                }
                return false; // иначе - снаружи
            }
        }


        static void Main()
        {

            Tri t = new Tri();
            bool text = t.Res();
            Console.WriteLine(text == true ? "Точка принадлежит треугольнику!" : "Точка снаружи");
            Console.ReadKey();

        }
    }
}
        
    
