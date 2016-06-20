using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mzwaaa.Startup))]
namespace Mzwaaa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
