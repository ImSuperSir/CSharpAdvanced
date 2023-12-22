using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImSuperSir.Samples
{
    public class FullTimeEmployee : EmployeeBase
    {
        // Additional properties or methods specific to full-time employees
        public override decimal Salary
        {
            get { return base.Salary * 1.2M; } // Full-time employees get a 20% bonus
            set { base.Salary = value; }
        }
    }


}
