using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2
{
    class Program
    {
        static void initializationMatrix(char[,] matrix)
        {
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = Convert.ToChar(rnd.Next('а', 'я'));
        }

        static void printMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i, j]} ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void makeWord(char[,] matrix, string word)
        {
            int count = 0;

            foreach (int letter in word)
            {
                bool mark = false;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (letter == matrix[i, j])
                        {
                            mark = true;
                            matrix[i, j] = '#';
                            break;
                        }
                    }
                    if (mark) break;
                }
                if (!mark) break;
                count++;
            }
            if (count == word.Length)
                Console.WriteLine("Можно составить слово");
            else
                Console.WriteLine("Нельзя составить слово");
        }

        static void Main(string[] args)
        {
            Console.Write("Size n=");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Size m=");
            int m = Convert.ToInt32(Console.ReadLine());

            char[,] matrix = new char[n, m];

            initializationMatrix(matrix);
            printMatrix(matrix);

            Console.Write("Input word: ");
            string s = Console.ReadLine();

            char[,] clone = (char[,])matrix.Clone();
            makeWord(clone, s);
        }
    }
}

