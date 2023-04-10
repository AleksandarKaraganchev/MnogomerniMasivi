using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace LotarienBilet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string[] size = Console.ReadLine().Split();
            int row = int.Parse(size[0]);
            int col = int.Parse(size[1]);
            int diagonalSum = 0;
            int diagonalSum2 = 0;
            int abovePrSum = 0;
            int belowPrSum = 0;
            int evenOnPrCt = 0;
            int evenOnedgeCt = 0;
            int oddOnedgeCt = 0;
            int[,] ticket = new int[row, col];
            for (int rw = 0; rw < row; rw++)
            {
                string[] line = Console.ReadLine().Split();
                for (int cl = 0; cl < col; cl++)
                {
                    ticket[rw, cl] = int.Parse(line[cl]);
                }
            }          
            for (int rw = 0; rw < row; rw++)
            {
                for (int cl = 0; cl < col; cl++)
                {
                    if (rw == cl)
                    {
                        diagonalSum += ticket[rw, cl];
                        if (ticket[rw, cl] % 2 == 0)
                        {
                            evenOnPrCt++;
                        }
                    }

                    if (rw + cl == row - 1)
                    {
                        diagonalSum2 += ticket[rw, cl];
                    }

                    if (rw < cl)
                    {
                        abovePrSum += ticket[rw, cl];
                    }

                    if (rw > cl)
                    {
                        belowPrSum += ticket[rw, cl];
                    }

                    if (rw == 0 || rw == row - 1 || cl == 0 || cl == col - 1)
                    {
                        if (ticket[rw, cl] % 2 == 0)
                        {
                            evenOnedgeCt++;
                        }
                        else
                        {
                            oddOnedgeCt++;
                        }
                    }
                }
            }

            bool winning = diagonalSum == diagonalSum2 && abovePrSum % 2 == 0 && belowPrSum % 2 == 1;
            if (winning)
            {
                double prize = (belowPrSum + evenOnPrCt + evenOnedgeCt + oddOnedgeCt) / 4.0 * 2 - 0.5;
                Console.WriteLine($"YES, The amount of money won is: {prize:f2}");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
