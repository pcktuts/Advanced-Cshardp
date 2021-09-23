using System;

namespace myFirstProject
{
    public delegate bool CustomerDelegate(Customer customer);
    class MainClass
    {
        static void Main(string[] args)
        {
            var c = new Customer()
            {
                Name = "Krishna",
                Salary = 14000,
                LastThreeMonthsTransaction = 45000
            };
            Customer.IsEligibleForLoan(c, customer => customer.Salary > 10000 && customer.LastThreeMonthsTransaction > 30000);
            Customer.IsEligibleForLoan(c, customer => customer.Salary > 500000 && customer.LastThreeMonthsTransaction > 12000);

        }



    }
    public class Customer
    {
        public string Name;
        public int Salary;
        public int LastThreeMonthsTransaction;

        public static void IsEligibleForLoan(Customer c, CustomerDelegate cd)
        {
            if(cd(c))
            {
                Console.WriteLine("Loan approved");
                return;
            }
            Console.WriteLine("Loan not approved");
        }
        
    }
}
