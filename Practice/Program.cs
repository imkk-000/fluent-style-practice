using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            new MyFluentClass()
                .SetArray(new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10})
                .CalculateSum()
                .GetTypeOfSum()
                .PrintResult();
        }
    }
}
