using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            TestExampleWith(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10});
            TestExampleWith(new int[] {1});
            TestExampleWith(new int[] {2});
        }

        static void TestExampleWith(int[] testData) {
            new MyFluentClass()
                .SetArray(testData)
                .CalculateSum()
                .GetTypeOfSum()
                .PrintResult()
                ;
        }
    }
}
