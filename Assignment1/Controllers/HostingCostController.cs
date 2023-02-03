using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// You are charging your client $5.50 / FN (fortnight = 14 days) for web hosting and maintenance,plus an additional 13% HST. The input {id} represents the number of days which has elapsedsince the beginning of the hosting. Output 3 strings which describe the total hosting cost
        /// </summary>
        /// <param name="id">number of days</param>
        /// <returns>output three strings describing total after taxes</returns>
        /// shows error when days are 0 and doubts in fortnights count
        public string Get(int id)
        {
            var FN = id / 14;
            var result = FN * 5.50;
            var HST = result * 0.13;
            var total = result + HST;

            string one = FN + " fortnights at $5.50 / FN  = $ " + result + " CAD";
            string two = "HST 13% = $" + HST + " CAD";
            string three = "Total = " + total;

            return one + "," + two + "," + three;
        }
    }
}
