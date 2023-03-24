using Lib.COR;
using Newtonsoft.Json;
using System;
using System.Web.Http;

namespace Api.Controllers
{
    public class MatchesController : ApiController
    {
        [System.Web.Http.HttpGet]
        public String Get()
        {
            var matches = Matches.GetMatches();
            var json = JsonConvert.SerializeObject(matches);
            return json;
        }

        [HttpGet]
        [Route("{matchID}")]
        public String Get(int matchID)
        {
            var match = Matches.GetMatchById(matchID);
            var json = JsonConvert.SerializeObject(match);
            return json;
        }

        public Matches Post([FromBody] Matches value)
        {
            return Matches.SaveMatch(value);
        }

        public Matches Put([FromBody] string value)
        {
            Matches match = JsonConvert.DeserializeObject<Matches>(value);
            return Matches.SaveMatch(match);
        }
    }
}