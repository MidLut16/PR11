using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int c1 = 0;
            int c2 = 0;
            int c3 = 0;
            int c4 = 0;

            Console.WriteLine("Введите четырехзначное число (>0):");
            int chis = Convert.ToInt32(Console.ReadLine());

            c1 = chis / 1000;
            chis = chis - c1 * 100;

            c2 = chis / 100;
            chis = chis - c2 * 10;

            c3 = chis / 10;
            chis = chis - c3 * 10;

            c4 = chis;

            if (c1 != c2 && c2 != c3 && c3 != c1 && c1 != c4 && c2 != c4 && c3 != c4)
            {
                Console.WriteLine("Высказывание верное!");
            }
            else
            {
                Console.WriteLine("Высказывание неверное!");
            }
        }
    }
}
