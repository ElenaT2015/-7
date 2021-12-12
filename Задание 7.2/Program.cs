using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Введите одну из сторон куба х по длине его ребра:");
            int x = Convert.ToInt32(Console.ReadLine());
            double ValCube = ValCubeCalc(x); //вызов метода расчета объема куба;                          
            double SurfCube = SurfCubeCalc(x); //вызов метода расчета S поверхности куба;  
            Console.ReadKey();
        }
        static double SurfCubeCalc(int a)
        {
            double SurfCube = 6 * Math.Pow(a, 2); // Вычисление площади S поверхности куба S=6H2;
            Console.WriteLine(" Площадь поверхности куба= {0:F3} ", SurfCube); //Вывод результатов до сотых
            return SurfCube;
        }
        static double ValCubeCalc(int a)
        {
            double ValCube = Math.Pow(a, 3); // Вычисление объема куба S=H3;
            Console.WriteLine(" Объем куба= {0:F3} ", ValCube); //Вывод результатов до сотых
            return ValCube;
        }
    }
}
