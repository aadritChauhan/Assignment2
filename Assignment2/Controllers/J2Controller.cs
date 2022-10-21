using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Http;

namespace Assignment2.Controllers
{
    
    public class J2Controller : ApiController
    {   /// <summary>
        /// Counts the number of ways a value of 10 can be rolled
        /// </summary>
        /// <param name="m">number of sides in dice 1</param>
        /// <param name="n">number of sides in dice 2</param>
        /// <example>
        /// GET ../api/J2/DiceGame/6/8 There are 5 total ways to get the sum 10.
        /// GET../api/J2/DiceGame/12/4 There are 4 ways to get the sum 10.
        ///</example>
        /// <returns>
        ///  Total number of ways a value of can be rolled with 2 dices
        /// </returns>
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string Dice( int m, int n)
        {
            int count=0;
            for (int i = 1; i <= m; i++)
            {

                for (int h = 1; h <= n; h++)
                {
                    if (i + h == 10)
                    {
                        count++;
                    }
                }
            }
            return "There are " + count + " total ways to get the sum 10";

        }
    }
}
