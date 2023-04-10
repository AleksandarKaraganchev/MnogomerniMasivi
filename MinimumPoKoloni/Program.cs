using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumPoKoloni
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
            for (int rw = 0; rw < row; rw++)
            {
                string[] elements = Console.ReadLine().Split(' ');
                for (int cl = 0; cl < col; cl++)
                {
                    matrix[rw, cl] = int.Parse(elements[cl]);
                }
            }
            for (int rw = 0; rw < row; rw++)
            {
                for (int cl = 0; cl < col; cl++)
                {
                    Console.Write($"{matrix[rw, cl]} ");
                }
                Console.WriteLine();
            }
            int[] columnMin = new int[col];
            for (int i = 0; i < columnMin.Length; i++)
            {
                columnMin[i] = int.MaxValue;
            }
            for (int cl = 0; cl < col; cl++)
            {
                for (int rw = 0; rw < row; rw++)
                {
                    if (matrix[rw, cl] < columnMin[cl])
                    {
                        columnMin[cl] = matrix[rw, cl];
                    }
                }
            }
            foreach (int min in columnMin)
            {
                Console.Write($"{min} ");
            }
            Console.WriteLine();
        }
    }
}
