using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcUsernameInUrl.Startup))]
namespace MvcUsernameInUrl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
