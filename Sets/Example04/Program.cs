using System;
using System.Collections.Generic;

namespace SetsExample04
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();

            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(1);

            Console.WriteLine("Броят на уникалните елементи в множеството е " + set.Count);
        }
    }
}
