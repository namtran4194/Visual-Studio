using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoADO.NET.Startup))]
namespace DemoADO.NET
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
