using System;

namespace D3
{
    class Program
    {
        static void Main(string[] args)
        {
            static long CountCollisions(string[] lines, int xStep, int yStep)
            {
                int treesCollidedWith = 0;
                int tobogganX = 0;
                //int tobogganY = 0 + yStep;

                for (int tobogganY = 0 + yStep; tobogganY < lines.Length; tobogganY+=yStep)
                {
                    string currentRow = lines[tobogganY];

                    tobogganX = (tobogganX + xStep) % currentRow.Length; 

                    if (currentRow[tobogganX] == '#')
                    {
                        treesCollidedWith++;
                    }
                }
                return treesCollidedWith;
            }

            Console.WriteLine("Reading in the Data file.");
            string[] lines = System.IO.File.ReadAllLines(@"D3.txt");

            Console.WriteLine("Calculating collisions for 1, 1");
            long c1 = CountCollisions(lines, 1, 1);
            Console.WriteLine("Calculating collisions for 3, 1");
            long c2 = CountCollisions(lines, 3, 1);
            Console.WriteLine("Calculating collisions for 5, 1");
            long c3 = CountCollisions(lines, 5, 1);
            Console.WriteLine("Calculating collisions for 7, 1");
            long c4 = CountCollisions(lines, 7, 1);
            Console.WriteLine("Calculating collisions for 1, 2");
            long c5 = CountCollisions(lines, 1, 2);

            long collisionsMultiplied = c1 * c2 * c3 * c4 * c5;

            Console.WriteLine($"Total collisions for {c1} * {c2} * {c3} * {c4} * {c5} is = {collisionsMultiplied} !");

            
        }
    }
}
