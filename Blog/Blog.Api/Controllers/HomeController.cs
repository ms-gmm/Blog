using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Api.Controller
{
    public class HomeController : BaseController
    {
        [HttpGet]
        public ActionResult<string> Test()
        {
            return "hello world";
        }
    }
}
