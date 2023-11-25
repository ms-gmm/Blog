using Blog.Api.Controller;
using Blog.Api.Repository;
using Blog.Application.Poco;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Api.Controllers
{
    public class UserController : BaseController
    {
        private UserDao userDao;

        public UserController(UserDao userDao)
        {
            this.userDao = userDao;
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
