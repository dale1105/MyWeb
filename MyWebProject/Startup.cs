using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyWebProject.Startup))]
namespace MyWebProject
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
