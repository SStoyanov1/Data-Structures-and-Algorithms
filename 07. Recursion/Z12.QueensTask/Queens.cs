using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Queens
{
    private const int CHESS_SIZE = 8;
    private const char EMPTY_CELL = '0';
    private const char UNDER_ATTACK_CELL = '1';
    private const char QUEEN = 'Q';
    private static int puttedQueensCounter = 0;
    private static char[,] field = new char[CHESS_SIZE, CHESS_SIZE];

    static void Main()
    {
        int row = 0;
        int col = 0;
        for (int i = 0; i < CHESS_SIZE; i++)
        {
            row = i;
            col = 0;
            PutTheQueen(row, col);
            puttedQueensCounter = 0;
            field = new char[CHESS_SIZE, CHESS_SIZE];
            Console.WriteLine("-------------------------");
        }
        
    }

    private static void PutTheQueen(int row, int col)
    {
        if (!IsInRange(row, col))
        {
            return;
        }

        if (field[row, col] == EMPTY_CELL - '0')
        {
            MarkCurrentRow(row);
            MarkCurrentCol(col);
            MarkTopLeft(row, col);
            MarkTopRight(row, col);
            MarkBottomLeft(row, col);
            MarkBottomRight(row, col);

            field[row, col] = QUEEN;
            puttedQueensCounter++;
            if (puttedQueensCounter == 8)
            {
                Print();
            }

            PutTheQueen(row, col + 1);
            PutTheQueen(row + 1, col - 1);
        }
        else
        {
            PutTheQueen(row - 1, col + 1);
            PutTheQueen(row + 1, col + 1);
            PutTheQueen(row + 1, col);

        }
    }

    private static void Print()
    {
        for (int i = 0; i < CHESS_SIZE; i++)
        {
            for (int j = 0; j < CHESS_SIZE; j++)
            {
                Console.Write(field[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        //System.Environment.Exit(0);
    }

    private static bool IsInRange(int row, int col)
    {
        if (row >= 0 && row < field.GetLength(0) && col >= 0 && col < field.GetLength(1))
        {
            return true;
        }
        return false;
    }

    private static void MarkCurrentCol(int col)
    {
        for (int i = 0; i < CHESS_SIZE; i++)
        {
            field[i, col] = '1';
        }
    }

    private static void MarkCurrentRow(int row)
    {
        for (int i = 0; i < CHESS_SIZE; i++)
        {
            field[row, i] = '1';
        }
    }

    private static void MarkBottomRight(int row, int col)
    {
        int diagonalRowBottomRight = row + 1;
        int diagonalColBottomRight = col + 1;
        while (diagonalRowBottomRight < CHESS_SIZE && diagonalColBottomRight < CHESS_SIZE)
        {
            field[diagonalRowBottomRight, diagonalColBottomRight] = '1';
            diagonalRowBottomRight++;
            diagonalColBottomRight++;
        }
    }

    private static void MarkBottomLeft(int row, int col)
    {
        int diagonalRowBottomLeft = row + 1;
        int diagonalColBottomLeft = col - 1;
        while (diagonalRowBottomLeft < CHESS_SIZE && diagonalColBottomLeft >= 0)
        {
            field[diagonalRowBottomLeft, diagonalColBottomLeft] = '1';
            diagonalRowBottomLeft++;
            diagonalColBottomLeft--;
        }
    }

    private static void MarkTopRight(int row, int col)
    {
        int diagonalRowTopRight = row - 1;
        int diagonalColTopRight = col + 1;
        while (diagonalRowTopRight >= 0 && diagonalColTopRight < CHESS_SIZE)
        {
            field[diagonalRowTopRight, diagonalColTopRight] = '1';
            diagonalRowTopRight--;
            diagonalColTopRight++;
        }
    }

    private static void MarkTopLeft(int row, int col)
    {
        int diagonalRowTopLeft = row - 1;
        int diagonalColTopLeft = col - 1;
        while (diagonalRowTopLeft >= 0 && diagonalColTopLeft >= 0)
        {
            field[diagonalRowTopLeft, diagonalColTopLeft] = '1';
            diagonalRowTopLeft--;
            diagonalColTopLeft--;
        }
    }
}
