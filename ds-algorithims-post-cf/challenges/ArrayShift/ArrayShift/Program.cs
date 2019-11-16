using System;

namespace ArrayShift
{
    class Program
    {
        static void MainArrayShift(string[] args)
        {
        }
        //Write a function called insertShiftArray which takes in an array and the value to be added.
        //Without utilizing any of the built-in methods available to your language, return an array with the new value added at the middle index.

        //Work on doing the same with ArrayList so it is dynamic.
        //Allow input into the console for both functions and print out result.
            //Functons will need parameters and console input will most likely need to return a Tuple of an Array and the int for insertion.

        public static Tuple<int[], int> ArrayShiftUserInput()
        {
            Console.WriteLine("How many items would you like in your array?");
            string userArraySizeInput = Console.ReadLine();
            int userArraySize = Convert.ToInt32(userArraySizeInput);
            int[] arrayPopulate = new int[userArraySize];

            for (int i = 0; i < arrayPopulate.Length; i++)
            {
                Console.WriteLine($"What would you like in the {i} spot of your array?");
                string userNumberInput = Console.ReadLine();
                int userNumber = Convert.ToInt32(userNumberInput);
                arrayPopulate[i] = userNumber;
            }


            Console.WriteLine("What number would you like to insert into the middle of your array?");
            string userInsertionInput = Console.ReadLine();
            int userInsertion = Convert.ToInt32(userInsertionInput);

            //The .Create Tuple method is also valid way to create a new tuple that is set to a variable
            Tuple<int[], int> returnTuple = new Tuple<int[], int>(arrayPopulate, userInsertion);

            //Can also just do return new Tuple<data type, data type>(first data type, second data type);

            return returnTuple;

        }

        public static void insertShiftArray(Tuple<int[], int> userTuple)
        {
            int[] startingArray = userTuple.Item1;
            int[] returnArray = new int[startingArray.Length + 1];
            int insertPoint = returnArray.Length / 2;
            int insert = userTuple.Item2;
            bool insertDone = false;


            for (int i = 0; i < returnArray.Length; i++)
            {
                if (insertDone == true)
                {
                    returnArray[i] = startingArray[i -1];
                }
                if (i == insertPoint)
                {
                    returnArray[i] = insert;
                    insertDone = true;
                }
                if (insertDone == false)
                {
                    returnArray[i] = startingArray[i];
                }
            }

            Console.Write("Your final array is ");
            for (int i = 0; i < returnArray.Length; i++)
            {
                Console.Write(returnArray[i]);
            }
        }
    }
}
