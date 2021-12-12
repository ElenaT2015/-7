using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Даны два треугольника. Введите длины сторон x1, y1, z1 треугольника 1:");
            Console.Write(" x1 = ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" y1 = ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" z1 = ");
            int z1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите длины сторон x2, y2, z2 треугольника 2:");
            Console.Write(" x2 = ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" y2 = ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" z2 = ");
            int z2 = Convert.ToInt32(Console.ReadLine());
            double triangleSquare1 = CalcTriangle(x1, y1, z1, 1); //вызов метода расчета S треугольника 1;                          
            double triangleSquare2 = CalcTriangle(x2, y2, z2, 2); //вызов метода расчета S треугольника 2;  
            if (triangleSquare1 == triangleSquare2)
            {
                Console.WriteLine(" Треугольники №1 = №2 = {0:f3}!", triangleSquare1); //Вывод результатов
            }
            else
            {
                if (triangleSquare1 > triangleSquare2 && triangleSquare1 != 0 && triangleSquare2 != 0)
                {
                    Console.WriteLine(" Площадь треугольника №1= {0:f3} больше площади треугольника №2= {1:f3}!", triangleSquare1, triangleSquare2); //Вывод результатов
                }
                else
                {
                    Console.WriteLine(" Площадь треугольника №2= {0:f3} больше площади треугольника №1= {1:f3}!", triangleSquare2, triangleSquare1); //Вывод результатов
                }
            }
            Console.ReadKey();
        }
        static double CalcTriangle(double x, double y, double z, byte i)
        {
            double halfPerimeter = (x + y + z) / 2; // Вычисление полупериметра P/2 треугольника;
            double EquMinus = halfPerimeter * (halfPerimeter - x) * (halfPerimeter - y) * (halfPerimeter - z);
            if (EquMinus <= 0)
            {
                Console.WriteLine(" Одна из введенных сторон треугольника №{0} неверна! Соотношение Герона не выполняется!", i); //Ошибка - Корень из отрицательного числа 
                return 0;
            }
            else
            {
                double triangleSquare = Math.Sqrt(EquMinus); // Вычисление площади S треугольника по формуле Герона;
                Console.WriteLine(" Плащадь треугольника №{0}= {1:F3} ", i, triangleSquare); //Вывод результатов до сотых
                return triangleSquare;
            }
        }
    }
}   