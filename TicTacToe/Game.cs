using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    static class Game
    {
        public static void Run()
        {
            char[,] table = new char[3, 3] { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };

            bool isRunning = true;

            while (isRunning)
            {
                ShowTable(table);
                
                Console.Write("[player1] choose a case: ");
                int chosenCase = Convert.ToInt32(Console.ReadLine());

                char mark = 'X';
                int row = 0;
                if (chosenCase <= 3)
                {
                    row = 1;
                }
                else if (chosenCase <= 6)
                {

                    row = 2;
                    switch (chosenCase)
                    {
                        case 4:
                            chosenCase = 1;
                            break;
                        case 5:
                            chosenCase = 2; break;
                        case 6:
                            chosenCase = 3; break;
                    }
                }
                else if (chosenCase <= 9)
                {
                    row = 3;
                    switch (chosenCase)
                    {
                        case 7:
                            chosenCase = 1;
                            break;
                        case 8:
                            chosenCase = 2;
                            break;
                        case 9:
                            chosenCase = 3; break;
                    }
                } else
                {
                    Exit("Invalid input");
                }

                if (!(table[row - 1, chosenCase - 1] == ' '))
                {
                    Console.WriteLine("This case is already chosen!");
                }
                else
                {
                    table[row - 1, chosenCase - 1] = mark;
                }

                ShowTable(table);
                if (CheckWin(table))
                {
                    Exit("player1 won");
                }
                //P2
                Console.Write("[player2] choose a case: ");
                chosenCase = Convert.ToInt32(Console.ReadLine());

                mark = 'O';
                row = 0;
                if (chosenCase <= 3)
                {
                    row = 1;
                }
                else if (chosenCase <= 6)
                {

                    row = 2;
                    switch (chosenCase)
                    {
                        case 4:
                            chosenCase = 1;
                            break;
                        case 5:
                            chosenCase = 2; break;
                        case 6:
                            chosenCase = 3; break;
                    }
                }
                else if (chosenCase <= 9)
                {
                    row = 3;
                    switch (chosenCase)
                    {
                        case 7:
                            chosenCase = 1;
                            break;
                        case 8:
                            chosenCase = 2;
                            break;
                        case 9:
                            chosenCase = 3; break;
                    }
                }
                else
                {
                    Exit("Invalid input");
                }

                if (!(table[row - 1, chosenCase - 1] == ' '))
                {
                    Console.WriteLine("This case is already chosen!");
                }
                else
                {
                    table[row - 1, chosenCase - 1] = mark;
                }
                if (CheckWin(table))
                {
                    Exit("player2 won");
                }
            }
        }
        public static void ShowTable(char[,] table)
        {
            int caseCount = 1;
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    if (caseCount % 3 == 0)
                    {
                        Console.Write("{0}:\t[{1}]\t", caseCount, table[i, j]);
                    }
                    else
                    {
                        Console.Write("{0}:\t[{1}]\t|", caseCount, table[i, j]);
                    }
                    caseCount++;
                }
                Console.WriteLine('\n');
            }
        }
        static void Exit(string msg)
        {
            Console.WriteLine("Exiting: {0}", msg);
            Environment.Exit(0);
        }
        static bool CheckWin(char[,] table)
        {
            // checking horizontaly.
            for (int i = 0; i < table.GetLength(0); i++)
            {
                if (table[i, 0] == table[i, 1] && table[i, 0] == table[i, 2] && table[i,0] != ' ')
                {
                    return true;
                }
            }

            // checking vertically.
            for (int i = 0; i < 3; i++)
            {
                if (table[0, i] == table[1, i] && table[0, i] == table[2, i] && table[0, i] != ' ')
                {
                    return true;
                }
            }

            // checking diagonally 1
            if (table[0,0] == table[1,1] && table[0,0] == table[2,2] && table[0,0] != ' ')
            {
                return true;
            }

            // checking diagonally 2
            if (table[2,0] == table[1,1] && table[2,0] == table[0,2] && table[2,0] != ' ')
            {
                return true;
            }


            return false;
        }
    }
}
