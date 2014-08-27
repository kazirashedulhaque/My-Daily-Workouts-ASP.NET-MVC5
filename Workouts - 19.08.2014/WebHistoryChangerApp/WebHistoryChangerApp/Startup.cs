using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebHistoryChangerApp.Startup))]
namespace WebHistoryChangerApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
