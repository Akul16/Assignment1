using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// returns the string "hello world!
        /// posts message "greeting to "id people" where id is user input
        /// </summary>
        /// <param name="id"> number of people</param>
        /// <returns>
        /// prints the "greeting to total peoples" and "Hello world!"
        /// </returns>
        /// <example>
        /// GET: /api/Greeting/10 -> Greeting to 10 people
        /// POST: /api/Greeting -> Hello World!
        /// </example>

        // GET api/Greeting/id
        public string Get(int id)
        {
            return "Greeting to" + id +  "people!" ;
        }

        public string Post()
        {
            return "Hello World!";
        }


    }

}