using Lib.COR;
using System;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Api.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class PlayersController : ApiController
    {
        [HttpGet]
        [Route("api/players")]
        public IHttpActionResult Get()
        {
            var players = Players.GetPlayers();
            if (players == null)
                return NotFound();
            return Ok(players);
        }

        [HttpGet]
        [Route("api/players/{playerID}")]
        public IHttpActionResult Get([FromUri] int playerID)
        {
            var player = Players.GetPlayerById(playerID);
            if (player == null)
                return NotFound();
            return Ok(player);
        }

        [HttpPost]
        [Route("api/players")]
        public IHttpActionResult Post([FromBody] Players newPlayer)
        {
            newPlayer.IsActive = true;
            var player = Players.SavePlayer(newPlayer);
            if (player == null)
                return InternalServerError();
            return Ok(player);
        }

        [HttpPut]
        [Route("api/players/{playerID}")]
        public IHttpActionResult Put([FromUri] int playerID, [FromBody] Players updatePlayer)
        {
            var player = Players.GetPlayerById(playerID);
            if (player == null)
                return NotFound();
            player.PlayerName = updatePlayer.PlayerName;
            player.PlayerRole = updatePlayer.PlayerRole;
            player.TeamID = updatePlayer.TeamID;
            player = Players.SavePlayer(player);
            return Ok(player);
        }

        [HttpDelete]
        [Route("api/players/{playerID}")]
        public IHttpActionResult Delete([FromUri] int playerID)
        {
            var player = Players.GetPlayerById(playerID);
            if (player == null)
                return BadRequest();
            player.IsActive = false;
            player.LeavingDate = DateTime.Now;
            player = Players.SavePlayer(player);
            return Ok(player);
        }
    }
}