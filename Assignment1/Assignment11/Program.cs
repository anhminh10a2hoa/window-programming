using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    class Program
    {
        static void Main(string[] args)
        {

            //Here we define a random number generator object, which is
            //used to generate random numbers.
            const int max = 5;
            const int min = 2;
            Random r = new Random();

            int row1 = r.Next(min, max);
            int col1 = r.Next(min, max);
            int row2 = col1;
            int col2 = r.Next(min, max);

            double[,] customMatrix1 = new double[row1, col1];
            double[,] customMatrix2 = new double[row1, col1];
            double[,] customMatrix3 = new double[row2, col2];

            double[,] sum = new double[row1, col1];
            double[,] sub = new double[row1, col1];
            double[,] multi = new double[row1, col2];
            Console.WriteLine("The dimession of 2 matrix is " + row1 + "x" + col1);
            Console.WriteLine();
            //Here we define a matrix, whose rows have different lengths (jagged array)
 
            for (int i = 0; i < customMatrix1.GetLength(0); i++)
            {
                for (int j = 0; j < customMatrix1.GetLength(1); j++)
                {
                    customMatrix1[i, j] = r.NextDouble();
                    customMatrix2[i, j] = r.NextDouble();
                }
            }

            for (int i = 0; i < customMatrix3.GetLength(0); i++)
            {
                for (int j = 0; j < customMatrix3.GetLength(1); j++)
                {
                    customMatrix3[i, j] = r.NextDouble();
                }
            }

            Console.WriteLine("The first matrix");
            for (int i = 0; i < customMatrix1.GetLength(0); i++)
            {
                for (int j = 0; j < customMatrix1.GetLength(1); j++)
                {
                    Console.Write("{0,6:f2}", customMatrix1[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("The second matrix");
            for (int i = 0; i < customMatrix1.GetLength(0); i++)
            {
                for (int j = 0; j < customMatrix1.GetLength(1); j++)
                {
                    Console.Write("{0,6:f2}", customMatrix2[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("The third matrix");
            for (int i = 0; i < customMatrix3.GetLength(0); i++)
            {
                for (int j = 0; j < customMatrix3.GetLength(1); j++)
                {
                    Console.Write("{0,6:f2}", customMatrix3[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            /* calculate the sum of the matrix */
            for (int i = 0; i < customMatrix1.GetLength(0); i++)
                for (int j = 0; j < customMatrix1.GetLength(1); j++)
                    sum[i, j] = customMatrix1[i, j] + customMatrix2[i, j];

            Console.WriteLine("The sum of 2 matrix");
            for (int i = 0; i < customMatrix1.GetLength(0); i++)
            {
                for (int j = 0; j < customMatrix1.GetLength(1); j++)
                {
                    Console.Write("{0,6:f2}", sum[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            /* calculate the subtraction of the matrix */
            for (int i = 0; i < customMatrix1.GetLength(0); i++)
                for (int j = 0; j < customMatrix1.GetLength(1); j++)
                    sub[i, j] = customMatrix1[i, j] - customMatrix2[i, j];

            Console.WriteLine("The subtraction of 2 matrix");
            for (int i = 0; i < customMatrix1.GetLength(0); i++)
            {
                for (int j = 0; j < customMatrix1.GetLength(1); j++)
                {
                    Console.Write("{0,6:f2}", sub[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            /* calculate the multiplication of the matrix */
            for (int i = 0; i < customMatrix1.GetLength(0); i++)
            {
                for (int j = 0; j < customMatrix3.GetLength(1); j++)
                {
                    for (int k = 0; k < customMatrix1.GetLength(1); k++)
                    {
                        multi[i, j] += customMatrix1[i, k] * customMatrix3[k, j];
                    }

                }
            }   

            Console.WriteLine("The multiplication of 2 matrix");
            for (int i = 0; i < customMatrix1.GetLength(0); i++)
            {
                for (int j = 0; j < customMatrix3.GetLength(1); j++)
                {
                    Console.Write("{0,6:f2}", multi[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
