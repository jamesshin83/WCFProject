using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GettingStartedWebClient.Startup))]
namespace GettingStartedWebClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
