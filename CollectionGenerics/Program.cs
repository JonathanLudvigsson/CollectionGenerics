using System;
using System.Collections.Generic;

namespace CollectionGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(1, "Jack", "Female", 25000.00m);
            Employee e2 = new Employee(2, "Gary", "Male", 32000.32m);
            Employee e3 = new Employee(3, "Nex", "Male", 16000.00m);
            Employee e4 = new Employee(4, "Yu", "Male", 240000.00m);
            Employee e5 = new Employee(5, "Mi", "Female", 14000.72m);

            Stack<Employee> eStack = new Stack<Employee>();
            eStack.Push(e1);
            eStack.Push(e2);
            eStack.Push(e3);
            eStack.Push(e4);
            eStack.Push(e5);

            Console.WriteLine("All employees");
            foreach (Employee employ in eStack)
            {
                Console.WriteLine($"{employ.ID} - {employ.Name} - {employ.Gender} - {employ.Salary}");
                Console.WriteLine($"Items left in eStack = {eStack.Count}");
            }
            Console.WriteLine("------------------------------");

            Console.WriteLine("Using Pop()");
            for (int i = eStack.Count; i > 0; i--)
            {
                Employee employ = eStack.Pop();
                Console.WriteLine($"{employ.ID} - {employ.Name} - {employ.Gender} - {employ.Salary}");
                Console.WriteLine($"Items left in eStack = {eStack.Count}");
            }
            Console.WriteLine("------------------------------");

            eStack.Push(e1);
            eStack.Push(e2);
            eStack.Push(e3);
            eStack.Push(e4);
            eStack.Push(e5);

            Console.WriteLine("Using Peek()");
            for (int i = 0; i < 2; i++)
            {
                Employee employ = eStack.Peek();
                Console.WriteLine($"{employ.ID} - {employ.Name} - {employ.Gender} - {employ.Salary}");
                Console.WriteLine($"Items left in eStack = {eStack.Count}");
            }
            Console.WriteLine("------------------------------");

            if (eStack.Contains(e3))
            {
                Console.WriteLine("Employee #3 is in the eStack");
            }
            else
            {
                Console.WriteLine("Employee #3 is not in the eStack");
            }
            Console.WriteLine("------------------------------");

            List<Employee> eList = new List<Employee>()
            {
                e1, e2, e3, e4, e5
            };
            if (eList.Contains(e2))
            {
                Console.WriteLine("Employee #2 is in the list");
            }
            else
            {
                Console.WriteLine("Employee #2 is not in the list");
            }
            Console.WriteLine("------------------------------");

            Console.WriteLine("First male in list");
            Employee firstMale = eList.Find(x => x.Gender == "Male");
            Console.WriteLine($"{firstMale.ID} - {firstMale.Name} - {firstMale.Gender} - {firstMale.Salary}");
            Console.WriteLine("------------------------------");

            Console.WriteLine("All males in list");
            foreach (Employee male in eList.FindAll(x => x.Gender == "Male"))
            {
                Console.WriteLine($"{male.ID} - {male.Name} - {male.Gender} - {male.Salary}");
            }
        }
    }
}
