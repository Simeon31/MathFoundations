using System;
using System.Collections.Generic;

namespace SetsExample02
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 1, 2, 3, 4, 5 };

            if (set1.IsSubsetOf(set2))
            {
                Console.WriteLine("set1 е подмножество на set2");
            }
            else
            {
                Console.WriteLine("set1 не е подмножество на set2");
            }
        }
    }
}
