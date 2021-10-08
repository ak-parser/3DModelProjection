using System;
using System.Collections.Generic;
using System.Text;

namespace ItemProjection
{
    class Input
    {
        public static int[,,] ModelConsoleInput(out int m, out int n, out int p)
        {
            string[] inputList = Console.ReadLine().Split(" ");
            m = Convert.ToInt32(inputList[0]);
            n = Convert.ToInt32(inputList[1]);
            p = Convert.ToInt32(inputList[2]);

            int[,,] array = new int[m, n, p];

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine($"\nInput {i + 1} matrix:");
                for (int j = 0; j < n; j++)
                {
                    string[] inputMatrix = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    for (int k = 0; k < p; k++)
                    {
                        array[i, j, k] = Convert.ToInt32(inputMatrix[k]);
                    }
                }
            }
            Console.WriteLine();

            return array;
        }
    }
}
