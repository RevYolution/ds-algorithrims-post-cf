using System;

namespace ArrayReverse
{
    class Program
    {
        static void MainArrayReverse(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void ArrayReverseWhileLoop()
        {
            int[] startArray = { 4, 8, 2, 3, 9 };

            int start = 0;
            int end = startArray.Length - 1;

            while (start != end)
            {
                int hold = startArray[start];
                startArray[start] = startArray[end];
                startArray[end] = hold;
                start++;
                end--;
            }

            Console.WriteLine($"The reversed array from a while loop is [{startArray[0]}, {startArray[1]}, {startArray[2]}, {startArray[3]}, {startArray[4]}]");

        }

        public static void ArrayReverseForLoop()
        {
            int[] startArray = { 4, 8, 2, 3, 9 };
            int[] reversedArray = new int[startArray.Length];
            int end = startArray.Length - 1;

            for (int i = 0; i < startArray.Length; i++)
            {
                reversedArray[end] = startArray[i];
                end--;
            }

            Console.WriteLine($"The reversed array from for loop is [{reversedArray[0]}, {reversedArray[1]}, {reversedArray[2]}, {reversedArray[3]}, {reversedArray[4]}]");

        }
    }
}
