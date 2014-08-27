using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WorkWithModelInMvc.Startup))]
namespace WorkWithModelInMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
