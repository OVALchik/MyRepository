using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part1
    {
        class Program
        {
            static void initializationMatrix(int[,] matrix)
            {
                Random rnd = new Random();
                for (int i = 0; i < matrix.GetLength(0); i++)
                    for (int j = 0; j < matrix.GetLength(1); j++)
                        matrix[i, j] = rnd.Next(10, 99);
            }

            static void printMatrix(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                        Console.Write($"{matrix[i, j]} ");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            static void swapRow(int[,] matrix)
            {
                for (int i = 0, l = matrix.GetLength(0) - 1; i < l; i++, l--)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        int temp = matrix[i, j];
                        matrix[i, j] = matrix[l, j];
                        matrix[l, j] = temp;
                    }
                }
            }

            static void Main(string[] args)
            {
                Console.Write("Size n=");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.Write("Size m=");
                int m = Convert.ToInt32(Console.ReadLine());

                int[,] matrix = new int[n, m];

                initializationMatrix(matrix);
                printMatrix(matrix);

                swapRow(matrix);
                printMatrix(matrix);
            }
        }
    }

