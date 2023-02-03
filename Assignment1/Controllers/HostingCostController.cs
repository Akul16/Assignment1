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
        public string Get(int id)
        {
            var FN = id / 14;
            var result = FN * 5.50;
            var HST = result * 0.13;
            var total = result + HST;

            return "ans" + total;
        }
    }
}
