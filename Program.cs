using System;

namespace Classes
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company company = new Company("Walmart", new DateTime(2021, 2, 20));
            // Create three employees
            Employee Tristan = new Employee();
            Tristan.FirstName = "Tristan";
            Tristan.LastName = "Bron";
            Tristan.Title = "Cashier";
            Tristan.Date = new DateTime(2021, 8, 26);

            Employee Avery = new Employee();
            Avery.FirstName = "Avery";
            Avery.LastName = "Noble";
            Avery.Title = "Cart Pusher";
            Avery.Date = new DateTime(2021, 8, 26);

            Employee Kelly = new Employee();
            Kelly.FirstName = "Kelly";
            Kelly.LastName = "Kessler";
            Kelly.Title = "Baker";
            Kelly.Date = new DateTime(2021, 8, 26);

            // Assign the employees to the company
            company.Employees.Add(Tristan);
            company.Employees.Add(Avery);
            company.Employees.Add(Kelly);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            foreach (var employee in company.Employees)
            {
                company.ListEmployees(employee, company);
            }
        }
    }
}