using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/

        public string Index()
        {
            return @"This is my <B>default</B> action...";
        }

        public string Welcome()
        {
            return @"This is the welcome action message...";
        }
    }
}
