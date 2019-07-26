using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            var numbers = new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var sum = 0;
            var typeOfSum = "";

            // find sum of numbers array
            foreach (var number in numbers)
            {
                sum += number;
            }

            // find type sum of numbers
            if (sum % 2 == 1) {
                typeOfSum = "Odd";
            } else {
                typeOfSum = "Even";
            }

            // print the result
            Console.WriteLine("sum of numbers is {0}, and type of sum is {1}.", sum, typeOfSum);
        }
    }
}
