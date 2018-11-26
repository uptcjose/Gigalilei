using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gigalilei.Backend.Startup))]
namespace gigalilei.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
