using Lib.COR;
using System.Web.Http;

namespace Api.Controllers
{
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