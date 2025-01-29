using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP04.Overriding
{
    internal class Employee
    {

        #region methods

        public virtual void Work()
        {
            Console.WriteLine("Employee is working");
        } 
        #endregion
    }
}
