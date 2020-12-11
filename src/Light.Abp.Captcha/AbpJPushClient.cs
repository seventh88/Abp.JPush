using Jiguang.JPush;
using Microsoft.Extensions.Options;
using Volo.Abp.DependencyInjection;

namespace Light.Abp.JPush
{
    public class AbpJPushClient : JPushClient, ITransientDependency
    {
        public AbpJPushClient(IOptions<AbpJPushOptions> options) : base(options.Value.AppKey, options.Value.MasterSecret)
        {
        }

        //var response = await _jPushClient.SendPushAsync(new PushPayload()
        //{
        //    CId = "aa",
        //    Platform = "all",
        //    Audience = "all",
        //    Message = new Message() { Content = "", ContentType = "" },
        //    Notification = new Notification() { Alert = "alert", Android = new Android() { }, IOS = new IOS() },
        //    Options = new Options()
        //    {
        //        IsApnsProduction = true
        //    }
        //});
    }
}
