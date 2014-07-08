using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите объем шара :");
            Double V = Convert.ToDouble(Console.ReadLine());
            Double R = Math.Pow(3 * V / 4 / Math.PI,(Double) 1 / 3);

            Console.WriteLine("Радиус шара равен {0}", R);
            Console.WriteLine("Площадь поверхности шара равна {0}", 4 * Math.PI * R * R);
            Console.ReadLine();
        }
    }
}

