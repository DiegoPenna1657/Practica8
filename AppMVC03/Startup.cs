using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppMVC03.Startup))]
namespace AppMVC03
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
