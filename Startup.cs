using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestApp_Partial.Startup))]
namespace TestApp_Partial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
