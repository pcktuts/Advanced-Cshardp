using System;

namespace myFirstProject
{
    class MainClass
    {
        static void Main(string[] args)
        {

           
            Console.WriteLine(MainClass.Sum(10, 20));
            /*
             * Expression lambda
             */
            Func<int, int, int> ExSum = (x, y) => x + y;
            Console.WriteLine(ExSum(25, 75));

            /**
             * Statement lambda
             */
            Func<int, int, int> StSum = (x, y) =>
            {
                var sum = x + y;
                Console.WriteLine($"Sum of {x} and {y} is {sum}");

                return sum;
            };
            Console.WriteLine(StSum(34, 78));
            

        }

        static int Sum(int x, int y)
        {
            return x + y;
        }



    }

}
