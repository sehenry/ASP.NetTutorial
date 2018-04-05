using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP.NetTutorial.Startup))]
namespace ASP.NetTutorial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
