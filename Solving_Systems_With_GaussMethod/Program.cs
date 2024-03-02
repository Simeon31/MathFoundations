using System;

namespace Solving_Systems_With_GaussMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up the coeffs and right-hand side of the equations

            double[,] coeffs =
            {
                { 2, -1, 3 },
                { 4, 1, -2 },
                { 3, -4, 1 }
            };
            double[] constants = { 7, 6, -3 };

            //Solve the equations using Gaussian elimination

            GaussianElimination(coeffs, constants);

            for (int i = 0; i < constants.Length; i++)
            {
                Console.WriteLine("x" + (i + 1) + " = " + constants[i]);
            }

            static void SwapRows(double[,] coeffs, double[] constants, int row1, int row2)
            {
                for (int i = 0; i < constants.Length; i++)
                {
                    double temp = coeffs[row1, i];
                    coeffs[row1, i] = coeffs[row2, i];
                    coeffs[row2, i] = temp;
                }

                double tempConstant = constants[row1];
                constants[row1] = constants[row2];
                constants[row2] = tempConstant;
            }

            static void GaussianElimination(double[,] coeffs, double[] constants)
            {
                int numEquations = constants.Length;

                for (int i = 0; i < numEquations; i++)
                {
                    int pivotRow = i;
                    for (int j = i + 1; j < numEquations; j++)
                    {
                        if (Math.Abs(coeffs[j, i]) > Math.Abs(coeffs[pivotRow, i]))
                        {
                            pivotRow = j;
                        }
                    }

                    if (pivotRow != i)
                    {
                        SwapRows(coeffs, constants, i, pivotRow);
                    }
                    if (coeffs[i,i] != 0)
                    {
                        for (int j = 0; j < numEquations; j++)
                        {
                            double scaleFactor = coeffs[j, i] / coeffs[i, i];
                            for (int k = i; k < numEquations; k++)
                            {
                                coeffs[j, k] -= scaleFactor * coeffs[i, k];
                            }
                            constants[j] -= scaleFactor * constants[i];
                        }
                    }
                }

                for (int i = numEquations - 1; i >= 0; i--)
                {
                    double sum = 0;
                    for (int j = i + 1; j < numEquations; j++)
                    {
                        sum += coeffs[i, j] * constants[j];
                    }
                    constants[i] = (constants[i] - sum) / coeffs[i, i];
                }
            }
        }
    }
}
