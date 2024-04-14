using System;
using System.Collections.Generic;

namespace SetsExample05
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int> { 1, 2, 3 };

            Console.WriteLine("Всички подмножества на множеството са: ");
            foreach (var subset in GetSubsets(set))
            {
                Console.Write("{");
                foreach (int item in subset)
                {
                    Console.Write("{0} ", item);
                }
                Console.WriteLine("}");
            }
        }

        static IEnumerable<IEnumerable<T>> GetSubsets<T>(HashSet<T> set)
        {
            int n = set.Count;
            T[] arr = new T[n];
            set.CopyTo(arr);

            for (int i = 0; i < (1 << n); i++)
            {
                yield return SubSet(arr, i);
            }
        }

        static IEnumerable<T> SubSet<T>(T[] arr, int bits)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if ((bits & (1 << i)) != 0)
                {
                    yield return arr[i];
                }
            }
        }
    }
}
