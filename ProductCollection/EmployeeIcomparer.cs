using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCollection
{
    public class EmployeeIcomparer
    {
        public int Salary { get; set; }
        public string Name { get;set; }
    }
    public class SalaryComparision : IComparer<EmployeeIcomparer>
    {
        public int Compare(EmployeeIcomparer x, EmployeeIcomparer y) //x=gaurav y=yash
        {
            if(x.Salary < y.Salary)
            {
                return -1;
            }
            else if(x.Salary > y.Salary)
            { 
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
