using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablichki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            int n = int.Parse(Console.ReadLine());
            int[][][] sheets = new int[n][][];
            for (int i = 0; i < n; i++)
            {
                int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int rows = size[0];
                int cols = size[1];
                sheets[i] = new int[rows][];
                for (int row = 0; row < rows; row++)
                {
                    int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    sheets[i][row] = values;
                }
            }
            double[] sheetAvg = new double[n];
            for (int i = 0; i < n; i++)
            {
                int min = sheets[i][0][0];
                int max = sheets[i][0][0];
                int summarise = 0;

                for (int rw = 0; rw < sheets[i].Length; rw++)
                {
                    for (int cl = 0; cl < sheets[i][rw].Length; cl++)
                    {
                        int value = sheets[i][rw][cl];

                        if (value < min)
                        {
                            min = value;
                        }

                        if (value > max)
                        {
                            max = value;
                        }

                        summarise += value;
                    }
                }
                double average = (double)summarise / (sheets[i].Length * sheets[i][0].Length);
                sheetAvg[i] = average;
                Console.WriteLine();
                Console.WriteLine($"{min} {max} {average:f2}");
            }
            double documentAvg = sheetAvg.Average();
            for (int i = 0; i < sheetAvg.Length; i++)
            {
                if (sheetAvg[i] > documentAvg)
                {
                    Console.Write("2 ");
                }
                else
                {
                    Console.Write("4 ");
                }
            }
            Console.WriteLine();
        }
    }
}
