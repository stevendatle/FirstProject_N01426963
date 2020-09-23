using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstProject_N01426963.Controllers
{
    public class SubTwentyController : ApiController
    {

        //Get /api/SubTwenty/30 -> 10
        public int Get(int id)
        {

            return id - 20;
        }

    }
}
