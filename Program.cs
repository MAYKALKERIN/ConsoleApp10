using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Четене на размерите
        int[] dimensions = Console.ReadLine()
            .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int rows = dimensions[0];
        int cols = dimensions[1];

        int[,] matrix = new int[rows, cols];

        // Четене на матрицата
        for (int i = 0; i < rows; i++)
        {
            int[] rowElements = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = rowElements[j];
            }
        }

        // Откриваме кои редове и колони трябва да станат 0
        bool[] zeroRows = new bool[rows];
        bool[] zeroCols = new bool[cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] == 0)
                {
                    zeroRows[i] = true;
                    zeroCols[j] = true;
                }
            }
        }

        // Зануляване на редовете
        for (int i = 0; i < rows; i++)
        {
            if (zeroRows[i])
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = 0;
                }
            }
        }

        // Зануляване на колоните
        for (int j = 0; j < cols; j++)
        {
            if (zeroCols[j])
            {
                for (int i = 0; i < rows; i++)
                {
                    matrix[i, j] = 0;
                }
            }
        }

        // Извеждане на резултата
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j]);
                if (j != cols - 1)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
