using System;

namespace FibonacciSeq
{
    class Program
    {
        static void MainFibSeq(string[] args)
        {
        }

        static int UserFibInput()
        {
            Console.WriteLine("Please input a whole number: ");
            string userInput = Console.ReadLine();
            int userFibNumber = Convert.ToInt32(userInput);
            return userFibNumber;
        }

        public static void FibEquation()
        {
            int fibNumber = UserFibInput();
            int counter = 0;
            int fibAtCounter = 0;
            int previousNumber =fibAtCounter;


            while (counter <= fibNumber)
            {
                if (counter==0)
                {
                    fibAtCounter=0;
                    previousNumber++;
                }
                if (counter==1)
                {
                    fibAtCounter = previousNumber;
                    previousNumber = fibAtCounter - previousNumber;
                }
                if (counter>1)
                {
                    fibAtCounter = fibAtCounter + previousNumber;
                    previousNumber = fibAtCounter - previousNumber;
                }
                counter++;
            }

            Console.WriteLine($"The nth number of a Fibonacci Sequence of {fibNumber} is {fibAtCounter}.");
        }

        public static void FibIteration()
        {
            int fibNumber = UserFibInput()+1;
            int[] outputArray = new int[fibNumber];

            for (int i = 0; i < outputArray.Length; i++)
            {
                if (i == 0)
                {
                    outputArray[i] = 0;
                }
                if (i == 1)
                {
                    outputArray[i] = 1;
                }
                if (i > 1)
                {
                    outputArray[i] = outputArray[i - 1] + outputArray[i - 2];
                }
            }

            Console.WriteLine($"The out put at the nth position of {fibNumber-1} is {outputArray[fibNumber-1]}");
        }
    }
}
