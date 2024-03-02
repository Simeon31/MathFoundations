using System;

namespace Solving_Systems_With_KramersRule
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a coefficient matrix to store the
            // coeffs of lenear matrix

            double[,] coeff =
            {
                {2, -1, 3, 9 },
                {1, 1, 1, 6 },
                {1, -1, 1, 2 }
            };

            Example.FindSolution(coeff);
        }
    }
}
