using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    static public class SquareArea
    {
        /// <summary>
        /// Метод, вычисляющий площадь треугольника по трём сторонам. Включена проверка треугольника на прямоугольность.
        /// </summary>
        /// <param name="a">Сторона a</param>
        /// <param name="b">Сторона b</param>
        /// <param name="c">Сторона c</param>
        /// <returns></returns>
        public static double TriangleArea(int a, int b, int c)
        {
            int p = (a + b + c)/2;
            Console.WriteLine("Треугольник прямоугольный? ", IsTriangleSquared(a,b,c));

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        
        /// <summary>
        /// Метод, вычисляющий площадь круга по радиусу.
        /// </summary>
        /// <param name="r">Радиус круга</param>
        /// <returns></returns>
        public static double CircleArea(int r)
        {
            return Math.Pow(r, 2) * Math.PI;
        }

        /// <summary>
        /// Дополнительный метод для проверки треугольника на прямоугольность. За основу взята теорема Пифагора.
        /// </summary>
        /// <param name="a">Сторона a</param>
        /// <param name="b">Сторона b</param>
        /// <param name="c">Сторона c</param>
        /// <returns></returns>
        public static bool IsTriangleSquared(int a, int b, int c) 
        {
            bool ans = false;

            int[] array = new int[3] { a, b, c };
            Array.Sort(array);

            if (Math.Pow(array[2], 2) == Math.Pow(array[0], 2) + Math.Pow(array[1], 2))
                ans = true;

            return ans;
        }
    }
}
