using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImSuperSir.Samples.FactoryPattern
{
    /// <summary>
    /// this class it is a kind of helper to execute the pattern, so it is
    /// very helpful to execute from the console program to
    /// debug / study the patten
    /// </summary>
    public class FactoryPatternSample : PatternSampleRunnableBase
    {
        public override void Run()
        {
            Console.WriteLine($"Se esta ejecutando el patron de Factoria.");

            List<IEmployee> lEmployees = new List<IEmployee>();

            SeedData(lEmployees);

            Console.WriteLine($"Total Salarios: {lEmployees.Sum(e => e.Salary)}");
        }



        /// <summary>
        /// Factory patter in action to generate distinct types of employees
        /// </summary>
        /// <param name="employees"></param>
        public static void SeedData(List<IEmployee> employees)
        {
            IEmployee teacher1 = EmployeeFactory.GetEmployeeInstance(EmployeeType.FullTime, 1, "Bob", "Fisher", 40000);
            employees.Add(teacher1);


            IEmployee headOfDepartment = EmployeeFactory.GetEmployeeInstance(EmployeeType.PartialTime, 3, "Brenda", "Mullins", 50000);
            employees.Add(headOfDepartment);
        }
    }
}
