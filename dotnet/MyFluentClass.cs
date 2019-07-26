using System;

namespace Practice {
    class MyFluentClass {
        private int[] numbers = null;
        private int sum = 0;
        private string typeOfSum = "";

        public MyFluentClass SetArray(int[] numbers) {
            this.numbers = numbers;
            return this;
        }

        public MyFluentClass CalculateSum() {
            foreach (var number in numbers)
            {
                this.sum += number;
            }
            return this;
        }

        public MyFluentClass GetTypeOfSum() {
            if (this.sum % 2 == 1) {
                this.typeOfSum = "Odd";
            } else {
                this.typeOfSum = "Even";
            }
            return this;
        }

        public MyFluentClass PrintResult() {
            Console.WriteLine("sum of numbers is {0}, and type of sum is {1}.", this.sum, this.typeOfSum);
            return this;
        }
    }
}
