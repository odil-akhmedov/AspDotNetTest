using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCforGit.Startup))]
namespace MVCforGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
