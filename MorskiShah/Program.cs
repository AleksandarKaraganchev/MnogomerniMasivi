using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorskiShah
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Въведи дъска: ");
            char[,] board = new char[3, 3];
            for (int rw = 0; rw < 3; rw++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int cl = 0; cl < 3; cl++)
                {
                    if (line[cl].Length > 0)
                    {
                        board[rw, cl] = line[cl][0];
                    }
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != '\0') // '/0'- проверява дали позицията е стойност по default,тоест null
                {
                    Console.WriteLine($"The winner is: [{board[i, 0]}]");
                    return;
                }

                if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != '\0')
                {
                    Console.WriteLine($"The winner is: [{board[0, i]}]");
                    return;
                }
            }
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != '\0')
            {
                Console.WriteLine($"The winner is: [{board[0, 0]}]");
                return;
            }

            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != '\0')
            {
                Console.WriteLine($"The winner is: [{board[0, 2]}]");
                return;
            }
            Console.WriteLine("There is no winner");

        }
    }
}
