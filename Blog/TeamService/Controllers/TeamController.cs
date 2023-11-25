using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamService.Models;
using TeamService.Repository;

namespace TeamService.Controllers
{
    public class TeamController : BaseController
    {
        private TeamDao teamDao;

        public TeamController(TeamDao teamDao)
        {
            this.teamDao = teamDao;
        }

        [HttpGet]
        public List<Team> Get()
        {
            var list = teamDao.FindAll();
            return list;
        }

        [HttpPost]
        public Result Add(Team user)
        {
            teamDao.Add(user);
            return new Result();
        }

        [HttpPost]
        public Result Delete(Team user)
        {
            teamDao.Delete(user.Id);
            return new Result();
        }

        [HttpPost]
        public Result Update(Team user)
        {
            teamDao.Update(user);
            return new Result();
        }
    }
}
