using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkwithOperatorOverloading
{
    class Employee
    {
        int Sal;
        public Employee(int x)
        {
            Sal = x;
        }
        public Employee()
        {
        }
        public void Show()
        {
            Console.WriteLine("Salary=" + Sal);

        }
        public static Employee operator +(Employee e1, Employee e2)
        {
            Employee t = new Employee();
            t.Sal = e1.Sal + e2.Sal;
            return t;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(5000);
            Employee e2 = new Employee(40000);

            Employee total = new Employee();
            total = e1 + e2;
            e1.Show();
            e2.Show();

            total.Show();
            Console.ReadKey();
        }
    }
}
