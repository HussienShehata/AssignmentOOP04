using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP04.Overriding
{
    internal class Manager : Employee
    {
        #region Methods

        public override void Work()
        {
            Console.WriteLine("Manger is manging");
        }

        #endregion
    }
}
