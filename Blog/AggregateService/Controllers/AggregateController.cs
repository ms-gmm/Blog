using AggregateService.Models;
using AggregateService.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AggregateService.Controllers
{
    public class AggregateController : BaseController
    {
        private readonly ITeamServiceClient _teamServiceClient;

        public AggregateController(ITeamServiceClient teamServiceClient)
        {
            _teamServiceClient = teamServiceClient;
        }
        [HttpGet]
        public async Task<ActionResult<List<Team>>>   Get()
        {
            var teams = await _teamServiceClient.GetTeams();
            return Ok(teams);
        }
    }
}
