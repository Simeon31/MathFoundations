using System;
using System.Collections.Generic;

namespace SetsExample06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 2, 4, 5, 3 };

            HashSet<int> set = new();
            for (int i = 0; i < arr.Length; i++)
            {
                set.Add(arr[i]);
            }

            int[] newarray = new int[set.Count];
            set.CopyTo(newarray);

            Console.WriteLine("Масивът без дублиращи елементи е: ");
            foreach (int i in newarray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
