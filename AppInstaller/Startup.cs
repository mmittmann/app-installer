using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppInstaller.Startup))]
namespace AppInstaller
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
