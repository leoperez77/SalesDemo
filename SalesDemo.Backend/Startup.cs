using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SalesDemo.Backend.Startup))]
namespace SalesDemo.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
