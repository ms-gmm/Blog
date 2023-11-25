using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AggregateService.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class BaseController : ControllerBase
    {

    }

    public class Result<T> : Result
    {
        public T Data { get; set; }
        public Result(T data)
        {
            Data = data;
        }
    }

    public class Result
    {
        public int Code { get; set; } = 200;
        public string Msg { get; set; }

        public Result()
        {
        }

        public Result(Exception ex)
        {
            Code = 500;
            Msg = ex.Message;
        }
    }
} 
