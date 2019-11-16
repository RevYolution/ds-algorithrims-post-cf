using System;

namespace BinarySearch
{
    class Program
    {
        static void MainBinarySearch(string[] args)
        {
        }
        //Write a function called BinarySearch which takes in 2 parameters: a sorted array and the search key.
        //Without utilizing any of the built-in methods available to your language, return the index of the array’s element that is equal to the search key,
        //or -1 if the element does not exist.

        public static void BinarySearchArray()
        {
            int[] sortedArray = { 1, 2, 3, 4, 5, 6 };
            int searchKey = 2;
            int left = 0;
            int right = sortedArray.Length - 1;
            int pointer = (left+right)/2;

            while (sortedArray[pointer] != searchKey)
            {
                if (sortedArray[pointer]>searchKey)
                {
                    right = pointer;
                    pointer = (right + left) / 2;
                }
                if (sortedArray[pointer]<searchKey)
                {
                    left = pointer;
                    pointer = (right + left) / 2;
                }
            }

            Console.WriteLine($"The number being searched is at index {pointer}");
        }
    }
}
