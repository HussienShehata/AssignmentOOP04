using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP04.overloading
{
    internal class ComplexNumber
    {
        #region Properties
        public int Real { get; set; }
        public int Img { get; set; }
        #endregion


        #region constructors

        public ComplexNumber()
        {
            
        }


        public ComplexNumber(int cReal, int cImg )
        {
            Real = cReal;
            Img = cImg;
        }
        #endregion




        #region Methods

        public static ComplexNumber operator +(ComplexNumber C1, ComplexNumber C2)
        {
            return new ComplexNumber()
            {
                Real = (C1?.Real ?? 0) + C2?.Real ?? 0,
                Img = (C1?.Img?? 0) + C2?.Img?? 0
            };
        }



        public static ComplexNumber operator -(ComplexNumber C1, ComplexNumber C2)
        {
            return new ComplexNumber()
            {
                Real = (C1?.Real ?? 0) - C2?.Real ?? 0,
                Img = (C1?.Img ?? 0) - C2?.Img ?? 0
            };
        }


        #endregion

        public override string ToString()
        {
            return $"Complex number is {Real} + {Img}i";
        }
    }
}
