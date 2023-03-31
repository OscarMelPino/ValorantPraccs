using Lib.COR;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Api.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class LoginController : ApiController
    {
        [HttpPost]
        [Route("api/login")]
        public IHttpActionResult Login([FromBody] LoginRequest request)
        {
            if (LoginHelper.ApproveCredentials(request.Username, request.Password))
                return Ok();
            return Unauthorized();
        }

        [HttpPost]
        [Route("api/login/new")]
        public IHttpActionResult Register([FromBody] LoginRequest request)
        {
            if (LoginHelper.CreateNewUser(request.Username, request.Password))
                return Ok();
            return Unauthorized();
        }
    }
    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

}