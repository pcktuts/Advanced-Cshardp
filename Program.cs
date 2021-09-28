using System;

namespace myFirstProject
{
    class MainClass
    {
        public delegate int SumDelegate(int x, int y);
        static void Main(string[] args)
        {

            SumDelegate sd = new SumDelegate(Sum);
            Console.WriteLine(sd(100, 200));
            SumDelegate sd1 = delegate (int x, int y) { return x + y; };
            Console.WriteLine(sd1(200, 300));

        }
       
        static int Sum(int x, int y)
        {
            return x + y;
        }



    }

}
