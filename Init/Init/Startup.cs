using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Init.Startup))]
namespace Init
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
