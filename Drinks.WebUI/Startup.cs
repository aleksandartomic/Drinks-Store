using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Drinks.WebUI.Startup))]
namespace Drinks.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
