using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Novsiy.Web.Startup))]
namespace Novsiy.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
