using Labb3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3.Controls
{
    internal class ShowStudents
    {
        // Method to show all students
        public static void ShowAllStudents(bool sortByFirstName, bool sortByAscending)
        {
            // Get the context aka Database, Then get the students in that Database
            var context = new Labb3DbContext();
            var students = context.Students;

            // Check if we are sorting by first or last name
            if (sortByFirstName) {
                // Check if we want the output to be ascending or descending
                if (sortByAscending)
                {
                    // Using lamda with OrderBy to get the students sorted by first name
                    foreach (var student in students.OrderBy(x => x.FName))
                    {
                        Console.WriteLine(student.FName + " " + student.LName);
                    }
                }
                else
                {
                    // Using .Reverse() to sort the students in a descending order
                    foreach (var student in students.OrderBy(x => x.FName).Reverse())
                    {
                        Console.WriteLine(student.FName + " " + student.LName);
                    }
                }
            } 
            else // Sort by last name instead of first name
            {
                if (sortByAscending) // Check if ascending or descending
                {
                    // using .OrderBy lastname instead of first name
                    foreach (var student in students.OrderBy(x => x.LName))
                    {
                        Console.WriteLine(student.FName + " " + student.LName);
                    }
                }
                else
                {
                    // using .Reverse to get the students sorted in a descending order
                    foreach (var student in students.OrderBy(x => x.LName).Reverse())
                    {
                        Console.WriteLine(student.FName + " " + student.LName);
                    }
                }
            }            
        }


    }
}
