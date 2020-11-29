using System;

namespace ofjwijgporje
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Варіант 8
             * Розробити програму, що ілюструє постулат Бертрана, 
             * згідно якого для будь-якого числа n > 1 знайдеться 
             * просте число p в інтервалі n < p < 2n. Під час виконання 
             * програми слід ввести число Х, більше 1 (в іншому випадку
             * програма повинна повідомляти про помилку), отримати послідовність 
             * усіх простих чисел в діапазоні ├]Х,2Х┤[ та кількість простих чисел.
             */
            int n;
            int simpl = 0;
            do
            {
                Console.WriteLine("Введiть число Х > 1");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 2); //ввід і перевірка числа

            for (int i = n + 1; i < 2 * n; i++)
            {
                //i перебирає числа між n та 2n
                int cnt = 0;
                for (int j = 2; j < i; j++)
                {
                    //j перебирає числа, на які ділить i, якщо i дилитиметься без остачі хоча б на одну j, воно складне, якщо з остачею на всі дж - просте

                    if (i % j != 0)
                    {
                        cnt++;
                    }
                    if (cnt == i - 2)
                    {
                        Console.Write(i);
                        Console.Write(" ");
                        cnt = 0;
                        simpl++;
                    }
                }
            }
            Console.WriteLine();
            Console.Write("Кiлькiсть простих чисел: ");
            Console.WriteLine(simpl);
            Console.ReadKey();
        }
    }
}