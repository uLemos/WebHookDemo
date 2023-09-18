using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebHooks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace WebHookGitHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebHookController : ControllerBase
    {
        [GitHubWebHook]
        public IActionResult GitHubHandler(JObject data)
        {
            var result = JsonConvert.SerializeObject(data);
            return Ok();
        }
    }
}
