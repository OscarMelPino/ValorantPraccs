using Lib.COR;
using System.Web.Http;

namespace Api.Controllers
{
    public class MapsController : ApiController
    {
        // GET: Maps
        [HttpGet]
        [Route("api/maps")]
        public IHttpActionResult Get()
        {
            var maps = Maps.GetMaps();
            return Ok(maps);
        }

        [HttpGet]
        [Route("api/maps/{mapID}")]
        public IHttpActionResult Get([FromUri] int mapID)
        {
            var map = Maps.GetMapById(mapID);
            if (map == null)
                return NotFound();
            return Ok(map);
        }
    }
}