using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Web.Http;
using System.Web.Routing;

namespace Assignment2.Controllers
{
    public class J3Controller : ApiController
    {   /// <summary>
        /// FROM YEAR 2013 COMPETITION
        /// User inputs a year, and we have to find out next year with distinct digits.
        ///  Idea:
        /// .)Counting distinct digits in a year(number), then comparing it with total number of digits.
        /// .)If both the values match then it's a distinct year, and we print it and if not we move on to the next number.
        /// 
        /// </summary>
        /// <param name="year"></param>
        /// <returns>The Next year with distinct digits </returns>
        /// <example> GET ../api/J3/2013/1987   2013</example>
        [HttpGet]
        [Route("api/J3/2013/{year}")]
        public int Year(int year)
        {
            
            //counter for number digits in the year
            int counter1 = 0;
            //counter for number of distinct digits in the year
            int counter2 = 0;
            

            /// Counting number of digits in the year
            while (year != 0)
            {
                int dig = year % 10;
                counter1++;
                dig = 0;

                
                
            }
            /// Counting number of distinct digits in the year(dont know how to do this) 



            /// if both counters are equal its a distinct year
            if (counter1 == counter2) {

                return year;

            }
            /// check for next year if not equal
            else 
                year++;
            
            
        } 
        
            
        
    }
}
