using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_homwork.Startup))]
namespace MVC_homwork
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
