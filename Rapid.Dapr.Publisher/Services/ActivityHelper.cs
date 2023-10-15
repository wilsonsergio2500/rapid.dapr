using Rapid.Dapr.Task.Core.DTOs;
using Rapid.Dapr.Task.Core.Helpers;

namespace Rapid.Dapr.Publisher.Services
{
    public interface IActivityHelper
    {
        Task<bool> PublishActivity(ActivityMessageDTO activityMessage);
        Task<bool> PublishActivityOfValueType<T>(ActivityDTO<T> activity);
    }
    public class ActivityHelper: IActivityHelper
    {
        internal readonly IDaprClientFactory daprClientFactory;
        public ActivityHelper(IDaprClientFactory daprClientFactory)
        {
            this.daprClientFactory = daprClientFactory;
        }

        public async Task<bool> PublishActivity(ActivityMessageDTO activityMessage)
        {
            return await daprClientFactory.PublishToDapr(DaprActivityConfig.PUBSUB, DaprActivityConfig.TOPIC, activityMessage);
        }
        public async Task<bool> PublishActivityOfValueType<T>(ActivityDTO<T> activity)
        {
            return await daprClientFactory.PublishToDapr(DaprActivityConfig.PUBSUB, DaprActivityConfig.TOPIC, activity);
        }
    }
}
