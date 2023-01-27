using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3.Views
{
    internal class Menus
    {
        public static void Init()
        {
            DrawMenu();
        }

        public static void DrawMenu()
        {
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine("1. Show all students");
            Console.WriteLine("2. Show all students in class");
            Console.WriteLine("3. Add new personal");
            Console.WriteLine("4. Show all personal");
            Console.WriteLine("5. Show all grades past month");
            Console.WriteLine("6. Show average grades in class");
            Console.WriteLine("7. Add new students");
            Console.WriteLine("------------------------------");

            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    ShowAllStudents();
                    break;
                case "2":
                    ShowAllStudentsInClass();
                    break;
                default:
                    break;
            }
        }

        public static void ShowAllStudents()
        {
            Console.Clear();
            Console.WriteLine("Do you want to sort student by first or last name?");
            Console.WriteLine("1. First name\n2. Last name");
            var firstOrLastName = Console.ReadLine();

            Console.WriteLine("\nShould the students be sorted in a ascending or descending order?");
            Console.WriteLine("1. Ascending\n2. Descending");
            var ascendingOrDescedning = Console.ReadLine();
            
            switch (firstOrLastName) {
                case "1":
                    if (ascendingOrDescedning == "1") { Controls.ShowStudents.ShowAllStudents(true, true); } 
                    else { Controls.ShowStudents.ShowAllStudents(true, false); }
                    break;
                case "2":
                    if (ascendingOrDescedning == "1") { Controls.ShowStudents.ShowAllStudents(false, true); }
                    else { Controls.ShowStudents.ShowAllStudents(false, false); }
                    break;
                default:
                    break;
            }

            Console.WriteLine("\nPress any key to return.");
            Console.ReadKey();
            DrawMenu();
        }

        public static void ShowAllStudentsInClass()
        {
            Console.Clear();
            Controls.ShowStudents.ShowAllStudentsInClass();
        }
    }
}
