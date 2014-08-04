using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoIISThreadAsync.Startup))]
namespace DemoIISThreadAsync
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
