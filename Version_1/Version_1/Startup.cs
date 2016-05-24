using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Version_1.Startup))]
namespace Version_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
