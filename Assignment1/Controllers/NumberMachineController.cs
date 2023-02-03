using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// Created a method which has an input {id}, and applied four mathematical operations to it
        /// </summary>
        /// <param name="x">integer x</param>
        /// <param name="y">integer y</param>
        /// <param name="z">integer z</param>
        /// <param name="w">integer w</param>
        /// <returns>
        /// all mathematical functions
        /// </returns>
        /// <example>
        /// GET: /api/numbermachine/10/1/1/1 - > 19
        /// </example>

        [HttpGet]
        [Route("api/NumberMachine/{x}/{y}/{z}/{w}")]
        public int NumberMachine(int x,int y, int z,int w)
        {
            return ((x + 10) - y) * z / w;
        }
    }
}
