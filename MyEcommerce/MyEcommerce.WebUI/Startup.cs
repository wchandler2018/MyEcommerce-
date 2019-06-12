using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyEcommerce.WebUI.Startup))]
namespace MyEcommerce.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
