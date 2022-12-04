using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebLogin1.Startup))]
namespace WebLogin1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
