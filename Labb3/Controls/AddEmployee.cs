using Labb3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3.Controls
{
    internal class AddEmployee
    {
        public static void AddNewEmployee()
        {
            // init variables
            int id = 0;
            string workTitle;
            string fName;
            string lName;

            // Connect to database
            var context = new Labb3DbContext();

            // Select all current employees
            foreach (Employee emp in context.Employees)
            {
                // Get the latest ID
                id = emp.EmployeeId + 1;
            }

            // Get work title from user
            Console.Write("Work Title: ");
            workTitle = Console.ReadLine().Trim();
            
            // Get first name from user 
            Console.Write("First Name: ");
            fName = Console.ReadLine().Trim();
            
            // Get last name from user
            Console.Write("Last Name: ");
            lName = Console.ReadLine().Trim();

            // Create a new employee
            var employee = new Employee();
            employee.EmployeeId = id;
            employee.WorkTitle = workTitle;
            employee.FullName = fName + " " + lName;

            // Add the employee to the database
            context.Add<Employee>(employee);

            // Save the database
            context.SaveChanges();   
        }
    }
}
