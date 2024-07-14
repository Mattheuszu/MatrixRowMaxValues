using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк матрицы: ");
        if (int.TryParse(Console.ReadLine(), out int rows) && rows > 0)
        {
            Console.Write("Введите количество столбцов матрицы: ");
            if (int.TryParse(Console.ReadLine(), out int columns) && columns > 0)
            {
                double[,] matrix = new double[rows, columns];
                Console.WriteLine("Введите элементы матрицы:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"Элемент [{i + 1},{j + 1}]: ");
                        if (double.TryParse(Console.ReadLine(), out double element))
                        {
                            matrix[i, j] = element;
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод. Пожалуйста, введите действительное число.");
                            j--; 
                        }
                    }
                }

                double[] rowSums = new double[rows];
                for (int i = 0; i < rows; i++)
                {
                    double maxInRow = matrix[i, 0];
                    for (int j = 1; j < columns; j++)
                    {
                        if (matrix[i, j] > maxInRow)
                        {
                            maxInRow = matrix[i, j];
                        }
                    }
                    rowSums[i] = maxInRow;
                }

                Console.WriteLine("Суммы наибольших значений в каждой строке:");
                for (int i = 0; i < rows; i++)
                {
                    Console.WriteLine($"Строка {i + 1}: {rowSums[i]}");
                }
            }
            else
            {
                Console.WriteLine("Некорректное количество столбцов.");
            }
        }
        else
        {
            Console.WriteLine("Некорректное количество строк.");
        }
    }
}
