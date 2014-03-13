using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LiveITApp.Startup))]
namespace LiveITApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
