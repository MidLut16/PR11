using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    class Program
    {
        static void Main(string[] args)
        //1. Из пяти целых положительных чисел найти два наибольших.
        {
            {
                int max = 0;
                int max2 = 0;

                Console.WriteLine("Введите первое число: ");
                int C1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число: ");
                int C2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите третье число: ");
                int C3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите четвертое число: ");
                int C4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите пятое число: ");
                int C5 = Convert.ToInt32(Console.ReadLine());

                if (max < C1)
                {
                    max = C1;
                }
                if (max < C2)
                {
                    max = C2;
                }
                if (max < C3)
                {
                    max = C3;
                }
                if (max < C4)
                {
                    max = C4;
                }
                if (max < C5)
                {
                    max = C5;
                }

                if (max != C1 && max2 < C1)
                {
                    max2 = C1;
                }
                if (max != C2 && max2 < C2)
                {
                    max2 = C2;
                }
                if (max != C3 && max2 < C3)
                {
                    max2 = C3;
                }
                if (max != C4 && max2 < C4)
                {
                    max2 = C4;
                }
                if (max != C5 && max2 < C5)
                {
                    max2 = C5;
                }

                Console.WriteLine("Первое максимальное число: {0} \n Второе максимальное число: {1} ", max, max2);

                Console.ReadKey();
            }
        }
    }
}
