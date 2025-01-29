using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP04.overloading
{
    internal class Calculator
    {
        #region properties

        //public int Integer1 {  get; set; }
        //public int Integer2 { get; set; }
        //public int Integer3 {  get; set; }
        //public double Number1 { get; set; }
        //public double Number2 { get; set; }

        #endregion


        #region constructor
        public Calculator()
        {
            
        }
        //public Calculator(int integer1, int integer2, int integer3, double number1, double number2)
        //{
        //    Integer1 = integer1;
        //    Integer2 = integer2;
        //    Integer3 = integer3;
        //    Number1 = number1;
        //    Number2 = number2;

        //}
        #endregion

        #region Methods

        public int Add(int integer1, int integer2)
        {

            return integer1 + integer2;
        }

        public  int Add(int integer1, int integer2, int integer3) 
        {
         return integer1+ integer2 + integer3;
        }

        public  double Add(double number1 , double number2 )
            { return number1 + number2; }
        #endregion

    }
}
