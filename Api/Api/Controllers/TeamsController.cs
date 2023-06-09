﻿using Lib.COR;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Api.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class TeamsController : ApiController
    {
        [HttpGet]
        [Route("api/teams")]
        public IHttpActionResult Get()
        {
            var teams = Teams.GetTeams();
            return Ok(teams);
        }

        [HttpGet]
        [Route("api/teams/{teamID}")]
        public IHttpActionResult Get([FromUri] int teamID)
        {
            var team = Teams.GetTeamById(teamID);
            if (team == null)
                return NotFound();
            return Ok(team);
        }

        [HttpPost]
        [Route("api/teams")]
        public IHttpActionResult Post([FromBody] Teams newTeam)
        {
            var team = Teams.SaveTeam(newTeam);
            if (team == null)
                return InternalServerError();
            return Ok(team);
        }
    }
}