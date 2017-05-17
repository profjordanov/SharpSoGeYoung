using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SociateGeYoung.App.Startup))]
namespace SociateGeYoung.App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
