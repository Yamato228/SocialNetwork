using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SocialNetworkNew.Startup))]
namespace SocialNetworkNew
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
