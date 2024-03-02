using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solving_Systems_With_KramersRule
{
    // A program for solving linear equations with Cramer's rule
    class Example
    {
        static double DeterminantOfMatrix(double[,] mat)
        {
            double ans;
            ans = mat[0, 0] * (mat[1, 1] * mat[2, 2] - mat[2, 1] * mat[1, 2])
                - mat[0, 1] * (mat[1, 0] * mat[2, 2] - mat[1, 2] * mat[2, 0])
                + mat[0, 2] * (mat[1, 0] * mat[2, 1] - mat[1, 1] * mat[2, 0]);
            return ans;
        }

        public static void FindSolution(double[,] coeff)
        {
            // Matrix d using coeff as given in Cramer's rule
            double[,] d =
            {
                {coeff[0,0], coeff[0,1], coeff[0,2] },
                {coeff[1,0], coeff[1,1], coeff[1,2] },
                {coeff[2,0], coeff[2,1], coeff[2,2] }
            };

            // Matrix d1 using coeff as given in Cramer's rule
            double[,] d1 =
            {
                {coeff[0,3], coeff[0,1], coeff[0,2] },
                {coeff[1,3], coeff[1,1], coeff[1,2] },
                {coeff[2,3], coeff[2,1], coeff[2,2] }
            };

            // Matrix d2 using coeff as given in Cramer's rule
            double[,] d2 =
            {
                {coeff[0,0], coeff[0,3], coeff[0,2] },
                {coeff[1,0], coeff[1,3], coeff[1,2] },
                {coeff[2,0], coeff[2,3], coeff[2,2] }
            };

            // Matrix d3 using coeff as given in Cramer's rule
            double[,] d3 =
            {
                {coeff[0,0], coeff[0,1], coeff[0,3] },
                {coeff[1,0], coeff[1,1], coeff[1,3] },
                {coeff[2,0], coeff[2,1], coeff[2,3] }
            };

            double D = DeterminantOfMatrix(d);
            double D1 = DeterminantOfMatrix(d1);
            double D2 = DeterminantOfMatrix(d2);
            double D3 = DeterminantOfMatrix(d3);

            Console.WriteLine($"D is: {D:F6}");
            Console.WriteLine($"D1 is: {D1:F6}");
            Console.WriteLine($"D2 is: {D2:F6}");
            Console.WriteLine($"D3 is: {D3:F6}");

            if (D != 0)
            {
                // Coeff have a unique solution, hence we apply Cramer's rule
                double x = D1 / D;
                double y = D2 / D;
                double z = D3 / D;

                Console.WriteLine($"Value of x is: {x:F6}");
                Console.WriteLine($"Value of y is: {y:F6}");
                Console.WriteLine($"Value of z is: {z:F6}");
            }
            else
            {
                if (D1 == 0 && D2 == 0 && D3 == 0)
                {
                    Console.WriteLine("Infinite solutions");
                }
                else if (D1 != 0 || D2 != 0 || D3 != 0)
                {
                    Console.WriteLine("No solutions");
                }
            }
        }
    }
}
