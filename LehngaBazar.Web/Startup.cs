using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LehngaBazar.Web.Startup))]
namespace LehngaBazar.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
