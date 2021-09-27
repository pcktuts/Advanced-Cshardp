using System;

namespace myFirstProject
{
    public delegate void MultiCastDelegate();
    class MainClass
    {
        static void Main(string[] args)
        {
            MultiCastDelegate md1 = new MultiCastDelegate(Hello);
            MultiCastDelegate md2 = new MultiCastDelegate(Hi);
            var md = md1 + md2;
            md();
            
        }
        static void Hello()
        {
            Console.WriteLine("Hello");
        }
        static void Hi()
        {
            Console.WriteLine("Hi");
        }



    }

}
