
using Blog.Api.Controller;
using Blog.Api.Repository;
using Blog.Application.Poco;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Threading;
using System.Threading.Tasks;

namespace Blog.Api.Controllers
{
    [ApiController]
    public class UserController : BaseController
    {
        private UserDao userDao;
        private readonly IConfiguration _configuration;

        public UserController(UserDao userDao,IConfiguration configuration)
        {
            this.userDao = userDao;
            _configuration = configuration;
        }
        [HttpGet]
        public IActionResult GetEnviroment()
        {
            var a = _configuration["DbConnect"];
            return Ok(a);
        }


        [HttpGet]
        public IActionResult Test1()
        {
            Thread.Sleep(3000);
            var a = "111111111";
            return Ok(a);
        }

        [HttpGet]
        public IActionResult Test2()
        {
            Thread.Sleep(1000);
            var a = "22222222222";
            return Ok(a);
        }

        [HttpGet]
        public IActionResult Test3()
        {
            var a = "3333333333";
            return Ok(a);
        }

        [HttpGet]
        public IActionResult PrometheusTest()
        {
            return Ok("hello world");
        }
        [HttpGet]
        public List<UserDto> Get()
        {
            var list = userDao.FindAll();
            //
            return list;
        }
        [HttpGet]
        public List<UserDto> GetByTeamId(int teamId)
        {
            var list = userDao.FindAll();
            list = list.Where(o => o.TeamId == teamId).ToList();
            return list;
        }

        [HttpPost]
        public Result Add(UserDto user)
        {
            userDao.Add(user);
            return new Result();
        }

        [HttpPost]
        public Result Delete(UserDto user)
        {
            userDao.Delete(user.Id);
            return new Result();
        }

        [HttpPost]
        public Result Update(UserDto user)
        {
            userDao.Update(user);
            return new Result();
        }
    }
}
