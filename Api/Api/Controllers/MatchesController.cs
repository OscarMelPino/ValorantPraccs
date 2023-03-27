using Lib.COR;
using System;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Api.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
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
            if (newMatch.MatchDate == DateTime.MinValue)
                newMatch.MatchDate = DateTime.Now;
            var match = Matches.SaveMatch(newMatch);
            if (match == null)
                return InternalServerError();
            return Ok(match);
        }

        [HttpPut]
        [Route("api/matches/{matchID}")]
        public IHttpActionResult Put([FromUri] int matchID, [FromBody] Matches updateMatch)
        {
            var match = Matches.GetMatchById(matchID);
            if (match == null)
                return BadRequest();
            match.Winner = updateMatch.Winner;
            match.Result = updateMatch.Result;
            match = Matches.SaveMatch(match);
            return Ok(match);
        }
    }
}