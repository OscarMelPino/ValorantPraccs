using Lib.COR;
using Newtonsoft.Json;
using System;
using System.Web.Http;

namespace Api.Controllers
{
    public class AgentsController : ApiController
    {
        // GET: Agents
        public String Get()
        {
            var agents = Agents.GetAgents();
            var json = JsonConvert.SerializeObject(agents);
            return json;
        }

        [HttpGet]
        [Route("api/agents/{agentID}")]
        public String Get([FromUri] int agentID)
        {
            var agent = Agents.GetAgentById(agentID);
            var json = JsonConvert.SerializeObject(agent);
            return json;
        }
    }
}