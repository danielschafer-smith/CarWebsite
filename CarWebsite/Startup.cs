using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarWebsite.Startup))]
namespace CarWebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
