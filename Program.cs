using System;
using System.Threading.Tasks;


namespace MyFirstProject
{
    class Program
    {
        delegate int ChangeNumber(int n);
        static void Main(string[] args)
        {

            Console.WriteLine(Add10(20));
            Console.WriteLine(Multiply10(100));
            ChangeNumber del1 = new ChangeNumber(Add10);
            Console.WriteLine( del1.Invoke(20));

            ChangeNumber del2 = new ChangeNumber(Multiply10);
            Console.WriteLine(del2.Invoke(100));
            Console.WriteLine(del2(100));


        }
        static int Add10(int n)
        {
            return n + 10;
        }
        static int Multiply10(int n)
        {
            return n * 10;
        }

    }
}
