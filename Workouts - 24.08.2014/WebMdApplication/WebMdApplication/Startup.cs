using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebMdApplication.Startup))]
namespace WebMdApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
