using Lib.COR;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Api.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class AgentsController : ApiController
    {
        [HttpGet]
        [Route("api/agents")]
        public IHttpActionResult Get()
        {
            var agents = Agents.GetAgents();
            return Ok(agents);
        }

        [HttpGet]
        [Route("api/agents/{agentID}")]
        public IHttpActionResult Get([FromUri] int agentID)
        {
            var agent = Agents.GetAgentById(agentID);
            if (agent == null)
                return NotFound();
            return Ok(agent);
        }
    }
}