using System;
using System.Collections.Generic;

namespace _08_03_employee_liste
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Employee Objects
            Employee emp1 = new Employee()
            {
                ID = 101,
                Name = "Pranaya",
                Gender = "Male",
                Salary = 5000
            };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Priyanka",
                Gender = "Female",
                Salary = 7000
            };
            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Anurag",
                Gender = "Male",
                Salary = 5500
            };
            Employee emp4 = new Employee()
            {
                ID = 104,
                Name = "Sambit",
                Gender = "Male",
                Salary = 6500
            };




            // Create a List of Employees
            List<Employee> listEmployees = new List<Employee>();

            listEmployees.Add(emp1);
            listEmployees.Add(emp2);
            listEmployees.Add(emp3);
            // We can retrieve the Items from a list collection by using index. 
            // The following line of code will retrieve the employee from the list. 
            // The List index is also 0 based.
            Employee emp = listEmployees[0];
            Console.WriteLine("Retrive the First employee by index");
            Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary = {3}",
                     emp.ID, emp.Name, emp.Gender, emp.Salary);
            Console.WriteLine();

            // retrieving the list using for loop
            Console.WriteLine("Retriving the list using for loop");
            for (int i = 0; i < listEmployees.Count; i++)
            {
                Employee employee = listEmployees[i];
                Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary = {3}",
                         employee.ID, employee.Name, employee.Gender, employee.Salary);
            }
            Console.WriteLine();
            // retrieving the list using foreach loop
            Console.WriteLine("Retriving the list using foreach loop");
            foreach (Employee e in listEmployees)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary = {3}",
                        e.ID, e.Name, e.Gender, e.Salary);
            }
            Console.WriteLine();

            // inserting an employee into the index position 1.
            listEmployees.Insert(1, emp4);
            // retrieving the list after inserting the employee in index position 1
            Console.WriteLine("Retriving the list after inserting new employee in index 1");
            foreach (Employee e in listEmployees)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary = {3}",
                        e.ID, e.Name, e.Gender, e.Salary);
            }
            Console.WriteLine();

            foreach (var e in listEmployees)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary = {3}",
                        e.ID, e.Name, e.Gender, e.Salary);
            }
            Console.WriteLine();
            //If you want to get the index postion of a specific employee
            //then use Indexof() method as shown below
            Console.WriteLine("Index of emp3 object in the List = " +
                    listEmployees.IndexOf(emp3));


            emp4.PlacaPutaDva();
            
           
            Console.WriteLine(emp4);
            Console.WriteLine("Ukupno zaposleno ljudi: "+Employee.UkupanBrojZaposlenika.ToString());
        }
    }
}

