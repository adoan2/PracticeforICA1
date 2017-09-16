using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Practice1_Website.Startup))]
namespace Practice1_Website
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
