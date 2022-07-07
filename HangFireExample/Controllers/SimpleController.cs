using HangFireExample.JobsManagers;
using Microsoft.AspNetCore.Mvc;

namespace HangFireExample.Controllers
{
    [Route("[controller]")]
    public class SimpleController : ControllerBase
    {
        [HttpGet(nameof(GetResult))]
        public IActionResult GetResult()
        {
            JobsManager.Instance.StartReccuringJob();
            return Ok("deneme");
        }
    }
}
