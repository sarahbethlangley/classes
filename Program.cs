using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.

            Company rustyAntiques = new Company("Rusty Antiques", new DateTime(1954, 12, 25));

            // Create three employees

            Employee one = new Employee();
            {
                one.FirstName = "Santa";
                one.LastName = "Chowder";
                one.Title = "Rust Cleaner";
                one.StartDate = new DateTime(1977, 01, 06);
            }

            Employee two = new Employee();
            {
                two.FirstName = "Sassy";
                two.LastName = "Chowder";
                two.Title = "Rust Maker";
                two.StartDate = new DateTime(1990, 04, 16);
            }

            Employee three = new Employee();
            {
                three.FirstName = "Sue";
                three.LastName = "Shorts";
                three.Title = "Owner";
                three.StartDate = new DateTime(2001, 09, 02);
            }



            // Assign the employees to the company

            rustyAntiques.Employees.Add(one);
            rustyAntiques.Employees.Add(two);
            rustyAntiques.Employees.Add(three);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */

            rustyAntiques.ListEmployees();
        }
    }
}