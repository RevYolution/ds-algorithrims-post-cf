using System;
using System.Collections;

namespace MatrixSum
{
    class Program
    {
        static void MainMatrixSum(string[] args)
        {
        }

        //Write a function to add up the sum of each row in a matrix of arbitrary size, and return an array with the appropriate values.
        //The matrix will always be full of integers.
        //Negative values are possible.
        //All nulls will be counted as zeros.

        public static void MatrixSum()
        {
            int[,] matrixToAdd = { {2,3 }, { 4,6}, { 5,2} };
            ArrayList sumArray = new ArrayList();
            int total = 0;

            Console.WriteLine(matrixToAdd.Length);
            Console.WriteLine(matrixToAdd.Rank);

            //for (int i = 0; i < matrixToAdd.Length; i++)
            //{
            //    total = 0;
            //    int[] currentArray = matrixToAdd[i];
            //    foreach (var item in i)
            //    {

            //    }
            //}

            //foreach (var item in matrixToAdd)
            //{
            //    Console.Write($"{total += item} , ");

            //}

        }
    }
}
