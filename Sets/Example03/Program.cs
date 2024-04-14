using System;
using System.Collections.Generic;

namespace SetsExample03
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 4, 5, 6 };

            HashSet<int> unionSet = new HashSet<int>(set1);
            unionSet.UnionWith(set2);

            Console.WriteLine("Сливането на двете множества е: ");
            foreach (int i in unionSet)
            {
                Console.WriteLine(i);
            }
        }
    }
}
