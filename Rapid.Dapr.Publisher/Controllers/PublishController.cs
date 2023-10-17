using Microsoft.AspNetCore.Mvc;
using Rapid.Dapr.Publisher.Services;
using Rapid.Dapr.Task.Core.DTOs;

namespace Rapid.Dapr.Publisher.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PublishController : ControllerBase
    {
        internal readonly IActivityHelper activityHelper;
        public PublishController(IActivityHelper activityHelper)
        {
            this.activityHelper = activityHelper;
        }
        [HttpPost("message")]
        public async Task<IActionResult> PostMessage([FromBody] ActivityMessageDTO message)
        {
            Console.WriteLine($"Calling Publish Action:- {message.Key}, DateTime: - {DateTime.Now}");
            await activityHelper.PublishActivity(message);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ActivityMessageDTO message)
        {
            Console.WriteLine($"Calling Publish Action:- {message.Key}, DateTime: - {DateTime.Now}");
            await activityHelper.PublishActivity(message);
            return Ok();
        }

    }
}
