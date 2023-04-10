using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrednoAritmetichnoPoRedove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Въведи редове: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Въведи колони: ");
            int col = int.Parse(Console.ReadLine());
            int[,] matrix = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int f = 0; f < col; f++)
                {
                    matrix[i, f] = int.Parse(Console.ReadLine());
                }
            }
            double[] linesAvg = new double[row];
            for (int i = 0; i < row; i++)
            {
                double sum = 0;
                for (int j = 0; j < col; j++)
                {
                    sum += matrix[i, j];
                    Console.Write($"{matrix[i, j]} ");
                }
                linesAvg[i] = sum / col;
                Console.WriteLine($" {linesAvg[i]:f2}");
            }
        }
    }
}
