using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspWeb.Startup))]
namespace AspWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
