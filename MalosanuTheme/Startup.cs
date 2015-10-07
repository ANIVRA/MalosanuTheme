using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MalosanuTheme.Startup))]
namespace MalosanuTheme
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
