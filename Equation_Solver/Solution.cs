// Solution to The Linear Algebra Equation Solver challenge

using System;

public class Program
{
    public static double[] SolveLinearEquations(double[,] equations)
    {
        int n = equations.GetLength(0);
        int m = equations.GetLength(1) - 1;

        for (int i = 0; i < n; i++)
        {
            int maxRow = i;
            for (int k = i + 1; k < n; k++)
            {
                if (Math.Abs(equations[k, i]) > Math.Abs(equations[maxRow, i]))
                {
                    maxRow = k;
                }
            }

            for (int k = i; k < m + 1; k++)
            {
                double temp = equations[i, k];
                equations[i, k] = equations[maxRow, k];
                equations[maxRow, k] = temp;
            }

            for (int k = i + 1; k < n; k++)
            {
                double factor = equations[k, i] / equations[i, i];
                for (int j = i; j < m + 1; j++)
                {
                    equations[k, j] -= factor * equations[i, j];
                }
            }
        }

        double[] solution = new double[m];

        for (int i = m - 1; i >= 0; i--)
        {
            double sum = 0;
            for (int j = i + 1; j < m; j++)
            {
                sum += equations[i, j] * solution[j];
            }
            solution[i] = (equations[i, m] - sum) / equations[i, i];
        }

        return solution;
    }

    static void Main()
    {
        double[,] equations = new double[,]
        {
            { 2, 3, 1, 4 },
            { 1, -1, 2, 1 },
            { 3, 2, -1, 8 }
        };

        double[] solution = SolveLinearEquations(equations);
        foreach (var value in solution)
        {
            Console.Write($"{value} ");
        }
    }
}
