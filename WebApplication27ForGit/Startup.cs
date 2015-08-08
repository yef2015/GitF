using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication27ForGit.Startup))]
namespace WebApplication27ForGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
