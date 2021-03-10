// Дано три цілі матриці розмірності n*m. Надрукувати ту з них, в якій більше нульових
// стрічок або стовпців (якщо таких матриць кілька, то надрукувати їх усіх).

using System.Linq;
using System;


namespace FunctionsTask1
{
    internal static class Program
    {
        private static int[,] MatrixInput(int row, int col)
        {
            var matrix = new int[row, col];
            var listOfRows = new string[row];
            for (var i = 0; i < row; i++)
            {
                listOfRows[i] = Console.ReadLine();
                if (listOfRows[i].Split().Length != col)
                    throw new IndexOutOfRangeException("Invalid amount of matrix row elements");
                for (var j = 0; j < col; j++) matrix[i, j] = int.Parse(listOfRows[i].Split()[j]);
            }

            return matrix;
        }

        private static void MatrixOutput(int[,] matrix, int row, int col)
        {
            for (var i = 0; i < row; i++)
            {
                for (var j = 0; j < col; j++) Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }
        }

        private static int ZeroValueRow(int[,] matrix, int row, int col)
        {
            var zeroRowsAmount = 0;
            for (var i = 0; i < row; i++)
            {
                var amountOfZerosInARow = 0;
                for (var j = 0; j < col; j++)
                    if (matrix[i, j] == 0)
                        amountOfZerosInARow++;

                if (amountOfZerosInARow == col)
                    zeroRowsAmount++;
            }

            return zeroRowsAmount;
        }

        private static int ZeroValueColumn(int[,] matrix, int row, int col)
        {
            var zeroColumnsAmount = 0;
            for (var i = 0; i < col; i++)
            {
                var amountOfZerosInAColumn = 0;
                for (var j = 0; j < row; j++)
                    if (matrix[j, i] == 0)
                        amountOfZerosInAColumn += 1;

                if (amountOfZerosInAColumn == row)
                    zeroColumnsAmount += 1;
            }

            return zeroColumnsAmount;
        }

        private static int Max(params int[] numbers)
        {
            return numbers.Max();
        }

        private static void Main()
        {
            Console.Write("Matrix A size (row*col): ");
            var matrixASize = Console.ReadLine().Split("*");
            var (rowA, colA) = (int.Parse(matrixASize[0]), int.Parse(matrixASize[1]));
            Console.WriteLine("Enter A matrix: ");
            var matrixA = MatrixInput(rowA, colA);
            var zeroA = Max(ZeroValueRow(matrixA, rowA, colA), ZeroValueColumn(matrixA, rowA, colA));

            Console.Write("\nMatrix B size (row*col): ");
            var matrixBSize = Console.ReadLine().Split("*");
            var (rowB, colB) = (int.Parse(matrixBSize[0]), int.Parse(matrixBSize[1]));
            Console.WriteLine("Enter B matrix: ");
            var matrixB = MatrixInput(rowB, colB);
            var zeroB = Max(ZeroValueRow(matrixB, rowB, colB), ZeroValueColumn(matrixB, rowB, colB));

            Console.Write("\nMatrix C size (row*col): ");
            var matrixCSize = Console.ReadLine().Split("*");
            var (rowC, colC) = (int.Parse(matrixCSize[0]), int.Parse(matrixCSize[1]));
            Console.WriteLine("Enter C matrix: ");
            var matrixC = MatrixInput(rowC, colC);
            var zeroC = Max(ZeroValueRow(matrixC, rowC, colC), ZeroValueColumn(matrixC, rowC, colC));

            if (zeroA == 0 && zeroB == 0 && zeroC == 0)
            {
                Console.WriteLine("\nMatrices with zero rows or columns are missing.");
            }
            else
            {
                Console.Write("\nMatrix/matrices with the largest number of zero rows or columns:");
                if (zeroA >= zeroB && zeroA >= zeroC)
                {
                    Console.WriteLine("\nMatrix A");
                    MatrixOutput(matrixA, rowA, colA);
                }

                if (zeroB >= zeroA && zeroB >= zeroC)
                {
                    Console.WriteLine("\nMatrix B");
                    MatrixOutput(matrixB, rowB, colB);
                }

                if (zeroC >= zeroA && zeroC >= zeroB)
                {
                    Console.WriteLine("\nMatrix C");
                    MatrixOutput(matrixC, rowC, colC);
                }
            }
        }
    }
}