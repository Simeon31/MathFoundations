using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> xs = new List<double>() { 0.0, 0.1, 0.2, 0.3, 0.4, 0.5 };
            Func<double, double> f = x => Math.Sin(x);

            Console.WriteLine("Values of sin(x) for x in [0, 0.5]: ");
            PrintValues(xs, f);
        }
        static void PrintValues(IEnumerable<double> xs, Func<double, double> f)
        {
            foreach (var x in xs)
            {
                Console.WriteLine("f({0}) = {1}", x, f(x));
            }
        }
    }
}
