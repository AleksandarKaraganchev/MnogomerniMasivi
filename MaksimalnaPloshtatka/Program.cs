using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaksimalnaPloshtatka
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Въведи ред: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Въведи колона: ");
            int col = int.Parse(Console.ReadLine());
            int[,] matrix = new int[row, row];
            for (int i = 0; i < row; i++)
            {
                string[] line = Console.ReadLine().Split();
                for (int f = 0; f < col; f++)
                {
                    matrix[i, f] = int.Parse(line[f]);
                }
            }
            int sumMax = int.MinValue;
            int rowMax = -1, maxCol = -1;
            for (int rw = 0; rw < row - 1; rw++)
            {
                for (int cl = 0; cl < col - 1; cl++)
                {
                    int sum = matrix[rw, cl] + matrix[rw, cl + 1] + matrix[rw + 1, cl] + matrix[rw + 1, cl + 1];
                    if (sum > sumMax)
                    {
                        sumMax = sum;
                        rowMax = rw;
                        maxCol = cl;
                    }
                }
            }
            Console.WriteLine("Output");
            Console.WriteLine($"{matrix[rowMax, maxCol]}" +
                $" {matrix[rowMax, maxCol + 1]}");
            Console.WriteLine();
            Console.WriteLine($"{matrix[rowMax + 1, maxCol]}" +
                $" {matrix[rowMax + 1, maxCol + 1]}");
            Console.WriteLine();
        }
    }
}
