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
        public async Task<IActionResult> Post([FromBody] ActivityMessageDTO message)
        {
            await activityHelper.PublishActivity(message);
            return Ok();
        }

    }
}
