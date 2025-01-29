using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP04
{
    internal class Rectangle
    {

        #region prpoperties
        public int Height { get; set; }
        public int Width { get; set; }


        #endregion


        #region contructors
        public Rectangle()
        {
            
        }

        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;  
        }

        public Rectangle(int length)
        {
            Height = length;
            Width = length;
        }


        public override string ToString()
        {
            return $"Dimensions of the rectangle is height : {Height} and width is : {Width}";
        }
        #endregion

    }
}
