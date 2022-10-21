using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// Calculates the total number of calories in the order
        /// </summary>
        /// <param name="burger">type of burger ordered</param>
        /// <param name="drink"> type of drink ordered</param>
        /// <param name="side">type of side ordered</param>
        /// <param name="dessert">type of dessert ordered</param>
        /// <example>GET ../api/J1/Menu/4/4/4/4 Your total calorie count is 0
        /// </example>
        /// <returns>Total number of calories ordered, depemding upon the type of burger, side, dessert, drink. </returns>
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public String J1(int burger, int drink, int side, int dessert)
        { 
            // Initialising variables for final calculation
            int calB, calD, calS, calDes;

            // Calculating Calories From Burger
            if (burger == 1)
            {
                 calB = 461;
            }
            else if (burger == 2)
            {
                calB = 461;
            }
            else if (burger == 3)
            {
                calB = 420;
            }
            else
            {
                calB = 0;
            }
            // Calculating Calories From Drink
            if(drink == 1)
            {
                calD = 130;
            }
            else if(drink == 2)
            {
                calD = 160;
            }
            else if (drink == 3)
            {
                calD = 118;
            }
            else
            {
                calD = 0;
            }
    
            // Calculation Calories From Sides
            if (side == 1)
            {
                calS = 100;
            }
            else if (side == 2)
            {
                calS = 57;
            }
            else if(side == 3)
            {
                calS = 70;
            }
            else
            {
                calS= 0;
            }

            // Calculating Calories From Dessert
            if (dessert == 1)
            {
                calDes = 167;
            }
            else if (dessert == 2)
            {
                calDes = 266;
            }
            else if (dessert == 3)
            {
                calDes = 75;
            }
            else
            {
                calDes= 0;
            }
            int totalCalorie = calB + calD + calDes + calS;
            return "Your total calorie count is " + totalCalorie;



        }
    }
}
