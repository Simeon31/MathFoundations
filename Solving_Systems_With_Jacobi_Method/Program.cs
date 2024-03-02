using System;

namespace Solving_Systems_With_Jacobi_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up coeffs and right-hand side of equations

            double[,] coeffs =
            {
                { 2, -1, 3 },
                { 4, 1, -2 },
                { 3, -4, 1 }
            };
            double[] constants = { 7, 6, -3 };
            double tolerance = 1e-5;
            int maxIterations = 100;

            JacobiMethod(coeffs, constants, tolerance, maxIterations);

            for (int i = 0; i < constants.Length; i++)
            {
                Console.WriteLine("x" + (i + 1) + " = " + constants[i]);
            }
        }

        static void JacobiMethod(double[,] coeffs, double[] constants, double tolerance, int maxIteration)
        {
            int numEquations = constants.Length;
            double[] previous = new double[numEquations];
            Array.Copy(constants, previous, numEquations);

            for (int i = 0; i < maxIteration; i++)
            {
                for (int j = 0; j < numEquations; j++)
                {
                    double sum = constants[j];
                    for (int k = 0; k < numEquations; k++)
                    {
                        if (k != j)
                        {
                            sum -= coeffs[j, k] * previous[k];
                        }
                        constants[j] = sum / coeffs[j, j];
                    }
                }

                double error = 0;
                for (int j = 0; j < numEquations; j++)
                {
                    error += Math.Abs(constants[j] - previous[j]);
                }
                if (error < tolerance)
                {
                    return;
                }
                Array.Copy(constants, previous, numEquations);
            }
        }
    }
}
