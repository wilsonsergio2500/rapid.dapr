using Dapr;
using Microsoft.AspNetCore.Mvc;
using Rapid.Dapr.Task.Core.DTOs;
using Rapid.Dapr.Task.Core.Helpers;

namespace Rapid.Dapr.Subscriber.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActivityController : ControllerBase
    {
        [Topic(DaprActivityConfig.PUBSUB, DaprActivityConfig.TOPIC)]
        [HttpPost(nameof(PublishedMessage))]
        public ActionResult<bool> PublishedMessage(ActivityMessageDTO activityMessageDTO)
        {
            Console.WriteLine($"Published Number:- {activityMessageDTO.Key}, DateTime: - {DateTime.Now}");
            return true;
        }

    }
}
