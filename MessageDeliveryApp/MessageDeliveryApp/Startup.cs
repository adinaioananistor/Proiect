using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MessageDeliveryApp.Startup))]
namespace MessageDeliveryApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
