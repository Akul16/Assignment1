using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// To return square of the user input id 
        /// </summary>
        /// <param name="id">your input integer</param>
        /// <returns>
        /// square of user input
        /// </returns>
        /// <example>
        /// GET: api/Square/2 -> 4
        /// GET: api/Square/-2 -> 4
        /// GET: api/Square/10 -> 100
        /// </example>

        // GET api/Square/id
        public int Get(int id)
        {
            return id * id;
        }

    }
}