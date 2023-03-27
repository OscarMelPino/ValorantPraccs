using Lib.COR;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Api.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
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