using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Uppgift2.Startup))]
namespace Uppgift2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
