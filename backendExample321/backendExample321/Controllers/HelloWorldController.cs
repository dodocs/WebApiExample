using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace backendExample321.Controllers
{
    public class HelloWorldController : ApiController
    {
        public IHttpActionResult GetHelloWorld()
        {
            return Ok("Hello, World!");
        }
    }
}
