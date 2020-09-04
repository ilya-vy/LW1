using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число X");
            int L = Convert.ToInt32(Console.ReadLine());
            int z = 0;
            for (int i = 0; L != 0;  i++)
            {
                L = L / 10;
            }
            Console.WriteLine(L);
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
