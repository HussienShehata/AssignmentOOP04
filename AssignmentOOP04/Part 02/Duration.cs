using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP04.Part_02
{
    internal class Duration
    {
        #region Attributes 


        private int hours;
        private int minutes;
        private int seconds;


        #endregion

        #region Properties 


        public int Hours
        {
            get { return hours; }
            set 
            {

                if (value > 0)
                    hours = value;
                else
                    Console.WriteLine("hours are out of range ");

            }
        }



        public int Minutes 
        {
            get { return minutes; }
            set
            {
                if (value > 0 && value <= 60)
                    minutes = value;
                else
                {
                   minutes = value % 60;
                    Hours =hours+ value / 60;
                } 
                    

            }
        }

        
        public int Seconds
        {
            get { return seconds; }
            set 
            {
                if (value > 0 && value <= 60)
                    seconds = value;
                else
                {
                    seconds =   value % 60;
                    Minutes =  minutes + value/60;
                }
            }
        }



        #endregion


        #region Constructors


        public Duration()
        {
            
        }

        public Duration(int hours , int minutes , int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Duration(int seconds)
        {
          
            Seconds = seconds;

        }



        #endregion



        #region Methods overloading 

        public static Duration operator +(Duration x , Duration y)
        {
            return new Duration()
            {
                Hours = x.hours + y.hours,
                Minutes = x.minutes + y.minutes,
                Seconds = x.seconds + y.seconds
            };
        }


        public static Duration operator +(Duration x, int seconds)
        {
            return new Duration()
            {
                Hours = x.Hours,
                Minutes = x.Minutes,
                Seconds = x.Seconds+ seconds



            };


        }

        public static Duration operator +( int seconds, Duration x)
        {
            return new Duration()
            {
                Hours = x.Hours,
                Minutes = x.Minutes,
                Seconds =  seconds + x.Seconds

            };

        }


        public static Duration operator ++(Duration x)
        {

            return new Duration()
            {
                Hours = x.hours,
                Minutes = x.minutes + 1,
                Seconds = x.seconds,
            };
        }


        public static Duration operator --(Duration x)
        {

            return new Duration()
            {
                Hours = x.hours,
                Minutes = x.minutes - 1,
                Seconds = x.seconds,
            };
        }





        public static Duration operator -(Duration x,Duration y)
        {
            return new Duration()
            {
                Hours = x.Hours- y.Hours,
                Minutes = x.Minutes- y.Minutes,
                Seconds = x.Seconds- y.Seconds
            };
        }

        public static bool operator > (Duration x, Duration y)
        {


            if (x.Hours == y.Hours)
                return x.Minutes > y.Minutes;
            else if (x.Hours == y.Hours && x.Minutes == y.Minutes)
                return x.Seconds > y.Seconds;
            else if (x.Hours == y.Hours && x.Minutes == y.Minutes && x.Seconds > y.Seconds)
                return x.Seconds > y.Seconds;
            else 
                return x.Hours > y.Hours;
            
      
        }
        


        public static bool operator < (Duration x, Duration y)
        {


            if(x.Hours == y.Hours)
                return x.Minutes < y.Minutes;
            else if (x.Hours == y.Hours && x.Minutes == y.Minutes)
                return x.Seconds < y.Seconds;

            else return x.Hours< y.Hours;
          

        }

        public static explicit operator DateTime(Duration x)
        {
            return new DateTime(DateTime.Now.Year,
                                DateTime.Now.Month,
                                DateTime.Now.Day,
                                x.Hours,
                                x.Minutes,
                                x.Seconds);

          
        }


        #endregion

        public override string ToString()
        {
            return $"Hours : {Hours} , Minutes : {Minutes} , Seconds : {Seconds}";
        }
    }
}
