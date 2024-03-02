using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    // Пример за използване на функции от по-висок ред за сортиране на масив от числа.
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 2, 8, 1, 9, 4 };

            Console.WriteLine("Before sorting: ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            Array.Sort(numbers, CompareNumbers);
            Console.WriteLine("After sorting: ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
        static int CompareNumbers(int x, int y)
        {
            if (x < y)
            {
                return -1;
            }
            else if (x > y)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
