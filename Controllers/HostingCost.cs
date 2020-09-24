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
            //a is default cost, b is fortnights, c is tax, d is total without tax, e is total with tax
            double a = 5.50;
            double b = id / 14;
            double c = 1.13;
            double d = a * b;
            double e = d * c;

            string message1 = "fortnights at $5.50/FN = " + d;
            string message2 = "HST 13% = " + c;
            string message3 = "Total " + e;

            return (message1 + message2 + message3);
           
            
            
        }
    }
}
