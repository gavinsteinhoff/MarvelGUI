using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Marvel.Startup))]
namespace Marvel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
