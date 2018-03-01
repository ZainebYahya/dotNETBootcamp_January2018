using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestIdentity2018.Startup))]
namespace TestIdentity2018
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
