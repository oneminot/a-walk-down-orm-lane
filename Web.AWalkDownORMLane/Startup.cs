using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web.AWalkDownORMLane.Startup))]
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
