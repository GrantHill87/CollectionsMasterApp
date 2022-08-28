using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            var arraySpec = new int[50];


            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            for (int i = 0; i < arraySpec.Length; i++)
            {
                Random rng = new Random();
                arraySpec[i] = rng.Next(0, 50);
            }

            //TODO: Print the first number of the array
            Console.WriteLine($"{arraySpec[0]}.");

            //TODO: Print the last number of the array            
            Console.WriteLine($"{arraySpec[arraySpec.Length - 1]}.");
            Console.WriteLine("All Numbers Original");

            //UNCOMMENT this method to print out your numbers from arrays or lists

            NumberPrinter(arraySpec);

            Console.WriteLine("-------------------");

            
            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");

            ReverseArray(arraySpec);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");

            ThreeKiller(arraySpec);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");

            Array.Sort(arraySpec);
            NumberPrinter(arraySpec);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var intSpec = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine($"{intSpec.Capacity}");

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(intSpec);

            //TODO: Print the new capacity
            Console.WriteLine($"{intSpec.Capacity}");

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            int userInput;
            bool doesUserUnderstand;

            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                doesUserUnderstand = int.TryParse(Console.ReadLine(), out userInput);
            } while (doesUserUnderstand == false);

            NumberChecker(intSpec, userInput);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter();
           
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(intSpec);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            intSpec.Sort();
            NumberPrinter(intSpec);
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var newArray = intSpec.ToArray();

            //TODO: Clear the list
            intSpec.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] arraySpec)
        {
            for (int i = 0; i < arraySpec.Length; i++)
            {
                if (arraySpec[i] % 3 == 0)
                {
                    arraySpec[i] = 0;
                }
                NumberPrinter(arraySpec);
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count -1; i >= 0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.Remove(numberList[i]);
                }
                NumberPrinter(numberList);
                // Alternative Method: var evens = numberList.Where(x => % 2 != 0);
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine("Congratulations! The number you're seeking is present.");
            }
            else
            {
                Console.WriteLine("Bummer! That number ain't here. Best check elsewhere.");
            }
        }

        private static void Populater(List<int> numberList)
        {
            while (numberList.Count < 51)

            {
                Random rng = new Random();
                int number = rng.Next(0, 50);

                numberList.Add(number);
            }
            NumberPrinter(numberList);
        }
        private static void Populater(int[] arraySpec)
        {
            for (int i = 0; i < arraySpec.Length; i++)
            {
                Random rng = new Random();
                arraySpec[i] = rng.Next(0, 50);
            }
        }        

        private static void ReverseArray(int[] array)
        {
            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */
            Array.Reverse(array);
            NumberPrinter(array);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
