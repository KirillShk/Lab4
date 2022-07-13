using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = 0;
            // счетчик отрицательных и положительных чисел
            int Otr = 0;
            int Pol = 0;
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n < 0)
                {
                    Otr += 1;
                }
                else if (n > 0)
                {
                    Pol += 1;
                }
            } while (n != 0);
            if (Otr > Pol)
            {
                Console.WriteLine("Кол-во отрицательных чисел больше");
            }
            else if (Otr < Pol)
            {
                Console.WriteLine("Кол-во положительных чисел больше");
            }
            else if ((Otr == 0) && (Pol == 0))
            {
                Console.WriteLine("введено число 0");
            }
            else
            {
                Console.WriteLine("Кол-во положительных и отрицательных чисел ровно");
            }
            Console.ReadKey();
        }

    }
}
