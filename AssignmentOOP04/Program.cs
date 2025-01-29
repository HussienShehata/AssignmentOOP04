using AssignmentOOP04.overloading;
using AssignmentOOP04.Overriding;
using AssignmentOOP04.Part_02;

namespace AssignmentOOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part 01

            #region Q1


            //Calculator calculatorObj = new Calculator();
            //int result, result2;
            //double result3;

            //result = calculatorObj.Add(4, 5);
            //Console.WriteLine($"Sum of two integers is {result}");

            //result2 = calculatorObj.Add(5, 4, 6);

            //Console.WriteLine($"Sum of three integers is {result2}");

            //result3 = calculatorObj.Add(5.5, 6.5);
            //Console.WriteLine($"sum of two double numbers is {result3}");


            #endregion

            #region Q2


            //Rectangle rectangleObj1 = new Rectangle();
            //Console.WriteLine(rectangleObj1);  

            //Rectangle rectangleObj2 = new Rectangle(4,3);
            //Console.WriteLine(rectangleObj2);

            //Rectangle rectangleObj3 = new Rectangle(5);
            //Console.WriteLine(rectangleObj3);

            #endregion


            #region Q3 

            //ComplexNumber C1Obj = new ComplexNumber(5,6);
            //ComplexNumber   C2Obj = new ComplexNumber(2,4);

            //ComplexNumber sum = new ComplexNumber();  
            //sum = C1Obj + C2Obj;
            //Console.WriteLine(sum);

            //ComplexNumber subtract = new ComplexNumber();   
            //subtract = C1Obj - C2Obj;
            //Console.WriteLine(subtract);


            #endregion


            #region Q4

            //Employee employeeObj = new Employee();
            //employeeObj.Work();

            //Manager managerObj = new Manager();
            //managerObj.Work();

            #endregion


            #region Q5 


            //DerivedClass1 derivedClass1 = new DerivedClass1();
            //derivedClass1.DisplayMessage();
            // // When we use "Override" keyword , objects of the derived class will call that method instead of the base class method

            //DerivedClass2 derivedClass2 = new DerivedClass2();
            //derivedClass2.DisplayMessage();
            // // When we use "new" keyword , the method is defined as being independet of the me method in the base Class




            #endregion



            #endregion


            #region Part 02


            #region 3

            //Duration D1 = new Duration(1,61,80);
            //Console.WriteLine(D1);

            

            //Duration D2 = new Duration(7800);
            //Console.WriteLine(D2);

          

            //Duration D3 = new Duration(666);
            //Console.WriteLine(D3);
            
            #endregion


            Duration D4 = new Duration(6,20,40);
            Duration D5 = new Duration(2,10,10);
            Duration D6 = new Duration();

            //D6 = D4 + D5;
            //Console.WriteLine(D6);

            //D6 = D4 + 7800;
            //Console.WriteLine(D6);

            //D6 = 666 + D6;
            //Console.WriteLine(D6);

            //D6 = ++D4;
            //Console.WriteLine(D6);

            //D6 = --D5;
            //Console.WriteLine(D6);

            //D4 = D4 - D5;
            //Console.WriteLine(D4);


            //if (D4 > D5)
            //    Console.WriteLine("D4 is larger");

            DateTime dateTime = (DateTime)D4;
            Console.WriteLine(dateTime);
            #endregion

        }
    }
}
