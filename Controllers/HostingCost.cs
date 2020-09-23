using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;

namespace FirstProject_N01426963.Controllers
{
    public class HostingCost : ApiController
    {
        public string Get(int id)
        {
            //a is default cost, b is fortnights, c is tax, d is total
            double a = 5.50;
            int b = id / 14;
            double c = 1.13;
            double d = a * b;

            return b + "fortnights at $5.50/FN = " + d;
            
        }
    }
}
