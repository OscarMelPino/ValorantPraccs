using Lib.COR;
using System.Web.Http;

namespace Api.Controllers
{
    public class MatchesController : ApiController
    {
        [HttpGet]
        [Route("api/matches")]
        public IHttpActionResult Get()
        {
            var matches = Matches.GetMatches();
            if (matches == null)
                return NotFound();
            return Ok(matches);
        }

        [HttpGet]
        [Route("api/matches/{matchID}")]
        public IHttpActionResult Get([FromUri] int matchID)
        {
            var match = Matches.GetMatchById(matchID);
            if (match == null)
                return NotFound();
            return Ok(match);
        }

        [HttpPost]
        [Route("api/matches")]
        public IHttpActionResult Post([FromBody] Matches newMatch)
        {
            var match = Matches.SaveMatch(newMatch);
            if (match == null)
                return InternalServerError();
            return Ok(match);
        }

        [HttpPut]
        [Route("api/matches")]
        public IHttpActionResult Put([FromBody] Matches updateMatch)
        {
            return Ok(Matches.SaveMatch(updateMatch));
        }
    }
}