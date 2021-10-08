using System;

namespace ItemProjection
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int m, n, p;
                int[,,] array = Input.ModelConsoleInput(out m, out n, out p);

                Model3D model3D = new Model3D(array, m, n, p);

                int[,] arrayProjectionMN, arrayProjectionMP, arrayProjectionNP;

                model3D.GetModelProjection(out arrayProjectionMN, out arrayProjectionMP, out arrayProjectionNP);

                //Output projection
                Console.WriteLine("Projection on MN:");
                for (int i = m - 1; i >= 0; i--)
                {
                    for (int j = 0; j < n; j++)
                        Console.Write(arrayProjectionMN[i, j] + " ");
                    Console.WriteLine("\n");
                }

                Console.WriteLine("Projection on MP:");
                for (int i = m - 1; i >= 0; i--)
                {
                    for (int j = 0; j < p; j++)
                        Console.Write(arrayProjectionMP[i, j] + " ");
                    Console.WriteLine("\n");
                }

                Console.WriteLine("Projection on NP:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < p; j++)
                        Console.Write(arrayProjectionNP[i, j] + " ");
                    Console.WriteLine("\n");
                }
            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
