using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebProjects.Startup))]
namespace WebProjects
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
