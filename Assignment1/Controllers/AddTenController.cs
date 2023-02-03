using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
   
    public class AddTenController : ApiController
    {
        /// <summary>
        /// To return 10 more than the user input id 
        /// </summary>
        /// <param name="id">your input integer</param>
        /// <returns>
        /// adds 10 to user input
        /// </returns>
        /// <example>
        /// GET: api/AddTen/21 -> 31
        /// GET: api/AddTen/0 -> 10
        /// GET: api/AddTen/-9 -> 1
        /// </example>

        
        public int Get(int id)
        {
            return (id + 10);
        }
    }
}