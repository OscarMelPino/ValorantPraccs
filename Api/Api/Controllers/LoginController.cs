using Lib.COR;
using System.Web.Http;

namespace Api.Controllers
{
    public class LoginController : ApiController
    {
        [HttpGet]
        [Route("login")]
        public IHttpActionResult Login([FromBody] string username, [FromBody] string password)
        {
            if (LoginHelper.ApproveCredentials(username, password))
                return Ok();
            return Unauthorized();
        }

        // TODO: make the post to create users and the necesary methods
    }
}