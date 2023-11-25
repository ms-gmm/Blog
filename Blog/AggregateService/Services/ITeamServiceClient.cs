using AggregateService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AggregateService.Services
{
    public interface ITeamServiceClient
    {
        /// <summary>
        /// 获取团队服务
        /// </summary>
        /// <returns></returns>
        Task<List<Team>> GetTeams();
    }
}
