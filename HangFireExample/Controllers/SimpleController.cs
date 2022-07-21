using HangFireExample.JobsManagers;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace HangFireExample.Controllers
{
    [Route("[controller]")]
    public class SimpleController : ControllerBase
    {
        private static List<byte[]> _data = new List<byte[]>();

        [HttpGet(nameof(GetResult))]
        public IActionResult GetResult()
        {
            var bytes = new byte[1024 * 1024 * 100];
            var random = RandomNumberGenerator.Create();
            random.GetBytes(bytes);
            _data.Add(bytes);
            JobsManager.Instance.StartFireForgetJob();
            return Ok("Job has Started");
        }
    }
}
