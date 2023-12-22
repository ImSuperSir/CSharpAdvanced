using ImSuperSir.Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImSuperSir.Samples
{
    public static class EmployeeFactory
    {

        public static IEmployee GetEmployeeInstance(EmployeeType pEmployeeType, int pId, string pFirstName, string pLastName, decimal pSalary)
        { 
            IEmployee lEmployee = null;

            switch (pEmployeeType)
            {
                case EmployeeType.FullTime:
                    lEmployee = FactoryPattern<IEmployee, FullTimeEmployee>.GetInstance();
                    break;
                case EmployeeType.PartialTime:
                    lEmployee = FactoryPattern<IEmployee, PartTimeEmployee>.GetInstance();
                    break;
                default:
                    break;
            }

            if (null != lEmployee)
            {
                lEmployee.Id = pId;
                lEmployee.FirstName = pFirstName;
                lEmployee.LastName = pLastName;
                lEmployee.Salary = pSalary;
            }
            else
            {
                throw new ArgumentException();
            }


            return lEmployee;

        }


    }
}
