using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> Employees { get; set; }

        public Company(string name, DateTime createdon)
        {
            Name = name;
            CreatedOn = createdon;
            Employees = new List<Employee>();
        }
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */

        public void ListEmployees(Employee employee, Company company)
        {
            Console.WriteLine($"{employee.FullName} works for {company.Name} as a {employee.Title} since {employee.Date}");
        }
    }
}