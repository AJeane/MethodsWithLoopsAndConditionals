using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Threes();


        }

        //Write a method that will print to the console all numbers 1000 through -1000.

        public static void PrintRange(int ceiling, int floor)
        {
            for (int i = ceiling; i >= floor; i--)
            {

                Console.WriteLine(i);

            }



        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time.

        public static void Threes()
        {
             
            for(int k=3; k <=999; k += 3)
            {

                Console.WriteLine(k);

            }

        }

        //Write a method to accept two integers as parameters and check whether they are equal or not.

        public static bool IsEqual(int a, int b)
        {

            if(a == b)
            {

                return true;
                
            }

            return false;

        }








    }
}
