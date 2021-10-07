using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Company company = new Company();
           
            foreach (Employee item in company)
            {
                Console.WriteLine(item.Name);
            }
            var items = company.Employees.GetEnumerator();
            while(items.MoveNext())
            {
                Console.WriteLine(items.Current.Name);
            }
          
        }
       

    }
    class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public  Employee(string Name, int Salary)
        {
            this.Name = Name;
            this.Salary = Salary;
        }
    }

    class Company: IEnumerable<Employee>
    {
        public List<Employee> Employees;
        public Company()
        {
            Employees = new List<Employee>()
            {
                new Employee( "Krishna", 45000),
                new Employee( "Arun", 25000),
                new Employee( "Peter", 15000),
                new Employee( "Ramesh", 15000),
                new Employee( "Harry", 15000),
                new Employee( "Mohammed", 15000),
                new Employee( "Remya", 15000),
            };

        }

        IEnumerator<Employee> IEnumerable<Employee>.GetEnumerator()
        {
           // return Employees.GetEnumerator();
           return new CompanyEnumerator(Employees);

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    class CompanyEnumerator : IEnumerator<Employee>
    {        
        public List<Employee> Employees;
        int index = 0;

        object IEnumerator.Current
        {
            get { return Current;  }
        }

        public CompanyEnumerator(List<Employee> Employees)
        {
            this.Employees = Employees;
        }

        public Employee Current =>  Employees[index++];

        public bool MoveNext()
        {
            return index >= Employees.Count ? false : true;
        }

        public void Reset()
        {
            index = 0;
        }

        public void Dispose()
        {
            
        }
    }
}
