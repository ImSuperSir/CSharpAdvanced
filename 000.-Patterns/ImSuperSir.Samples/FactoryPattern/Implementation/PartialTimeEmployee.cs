using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImSuperSir.Samples
{
    public class PartTimeEmployee : EmployeeBase
    {
        // Additional properties or methods specific to part-time employees
        public override decimal Salary
        {
            get { return base.Salary * 0.8M; } // Part-time employees get an 80% salary
            set { base.Salary = value; }
        }
    }
}
