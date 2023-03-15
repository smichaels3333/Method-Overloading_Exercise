using System;
using System.Collections.Generic;

namespace Method_Overloading_Exercise_01_Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Complete all of the TODOs then push back to GitHub

            #region TODOs

            // TODO: Call each of the overloads you created below here make sure to pass in the appropriate arguments to the function
            PrintItems(1 ,2, 3);
            PrintItems(33.33, 33.44);
            PrintItems(3.3333m, 2.3333m, -1.345m);
            PrintItems(true, false, false, true, true);
            PrintItems("Hello", "Yes", "no");
            PrintItems('a', 'b', 'c', 'd', 'E');
            PrintItems(123456789L, 987654321L, 147258369L);
            PrintItems(3.33F, 4.75F, 3.23F, 12,34F);
            #endregion


            #region BONUS
            // TODO: Call the PrintItems overload and pass in a new System.Object as an argument
            PrintItems(new System.Object()); // object

            //Example 1
            var str = "Hello World!";
            var num1 = 27;
            var symbol1 = '$';
            PrintItems(str, num1, symbol1);



            //Example 2:
            var arr = new int[] { 1, 2, 3 };
            var arr1 = new double[] { .1, .2, .3 };
            var arr2 = new float[] { .1f, .2f, .3f };
            PrintItems(arr, arr1, arr2);

            #endregion
        }


        #region TODOs
        // TODO: Create a method called PrintItems
        // TODO: Make the method public 
        // TODO: Make the method static
        // TODO: Make the return type void
        // TODO: Make the parameter of type int
        // TODO: Make the method print out what's passed in to the console
        public static void PrintItems(int item)
        {
            Console.WriteLine(item);
        }

        // TODO: Create an overload for PrintItems that prints out ANY amount of integers passed in to the function as arguments
        public static void PrintItems(params int[] items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        // TODO: Create a PrintItems() double overload
        public static void PrintItems(double item)
        {
            Console.WriteLine(item);
        }

        // TODO: Create a PrintItems() double overload that prints out ANY amount of doubles passed in to the function as arguments
        public static void PrintItems(params double[] items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        // TODO: Create a PrintItems() decimal overload
        public static void PrintItems (decimal item) 
        {
            Console.WriteLine(item);
        }

        // TODO: Create a PrintItems() decimal overload that prints out ANY amount of decimals passed in to the function as arguments
        public static void PrintItems (params decimal[] items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        // TODO: Create a PrintItems() bool overload
        public static void PrintItems(bool item)
        {
            Console.WriteLine(item);
        }

        // TODO: Create a PrintItems() bool overload that prints out ANY amount of bools passed in to the function as arguments
        public static void PrintItems(params bool[] items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        // TODO: Create a PrintItems() string overload
        public static void PrintItems(string item)
        {
            Console.WriteLine(item);
        }

        // TODO: Create a PrintItems() string overload that prints out ANY amount of strings passed in to the function as arguments
        public static void PrintItems(params string[] items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        // TODO: Create a PrintItems() char overload
        public static void PrintItems(char item)
        {
            Console.WriteLine(item);
        }

        // TODO: Create a PrintItems() char overload that prints out ANY amount of chars passed in to the function as arguments
        public static void PrintItems(params char[] items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        // TODO: Create a PrintItems() float overload
        public static void PrintItems(float item) 
        {
            Console.WriteLine(item);
        }

        // TODO: Create a PrintItems() float overload that prints out ANY amount of floats passed in to the function as arguments
        public static void PrintItems(params float[] items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        // TODO: Create a PrintItems() long overload
        public static void PrintItems(long item)
        {
            Console.WriteLine(item);
        }

        // TODO: Create a PrintItems() long overload that prints out ANY amount of longs passed in to the function as arguments 
        public static void PrintItems(params long[] items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
        

        #endregion


        #region BONUS

        // TODO: Create a PrintItems() object overload that prints out ANY amount of objects passed in to the function as arguments
        public static void PrintItems(params object[] items) 
        {
            foreach (var item in items)
            {
                Console.WriteLine(item.ToString());
            }
        }

        #endregion
    }
}
