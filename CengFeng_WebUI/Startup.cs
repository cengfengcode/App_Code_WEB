using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CengFeng_WebUI.Startup))]
namespace CengFeng_WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
