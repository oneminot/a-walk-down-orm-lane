using Microsoft.Owin;
using Owin;
using Web.AWalkDownORMLane;

[assembly: OwinStartup(typeof (Startup))]

namespace Web.AWalkDownORMLane
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}