using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UmbracoTest.Startup))]
namespace UmbracoTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
