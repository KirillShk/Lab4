using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число А, В, С");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());
            int sum = (A + B) * 2; // сумма сторон прямоугольника
            int x = 0; // количество квадратов
            while (sum >= C)
            {
                sum -= C;
                x++;
            }
            Console.WriteLine("Количество квадратов = {0}", x);
            Console.ReadKey();
        }
    }
}
