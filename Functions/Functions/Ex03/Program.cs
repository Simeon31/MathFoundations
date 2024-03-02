using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("All numbers: ");
            PrintNumbers(numbers);

            var devisibleBy3Numbers = numbers.Where(n => n % 3 == 0);

            Console.WriteLine("Numbers devisible by 3: ");
            PrintNumbers(devisibleBy3Numbers);
        }
        static void PrintNumbers(IEnumerable<int> numbers)
        {
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
