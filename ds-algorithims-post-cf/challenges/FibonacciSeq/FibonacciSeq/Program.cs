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
                //int fibCalculation = fibAtCounter + previousNumber;
                //previousNumber = fibCalculation;
                //fibAtCounter = fibCalculation - previousNumber;
                counter++;
            }

            //int fibCalculation = (fibNumber - 1) + (fibNumber - 2);

            Console.WriteLine($"The nth number of a Fibonacci Sequence of {fibNumber} is {fibAtCounter}.");
        }
    }
}
