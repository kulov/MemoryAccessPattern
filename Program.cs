namespace MemoryAccessPattern
{
    using System;
    using System.Diagnostics;

    internal class Program
    {
        public static void Main()
        {
            const int SIZE = 10000;
            int[,] matrix = new int[SIZE, SIZE];

            while (true)
            {
                // Faster
                Stopwatch sw = Stopwatch.StartNew();
                for (int row = 0; row < SIZE; row++)
                {
                    for (int column = 0; column < SIZE; column++)
                    {
                        matrix[row, column] = (row * SIZE) + column;
                    }
                }
                Console.WriteLine("Faster: " + sw.Elapsed);

                // Slower
                sw = Stopwatch.StartNew();
                for (int column = 0; column < SIZE; column++)
                {
                    for (int row = 0; row < SIZE; row++)
                    {
                        matrix[row, column] = (row * SIZE) + column;
                    }
                }
                Console.WriteLine("Slower: " + sw.Elapsed);

                Console.WriteLine("=================");
                Console.ReadLine();
            }
        }
    }
}
