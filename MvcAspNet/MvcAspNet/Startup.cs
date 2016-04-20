using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcAspNet.Startup))]
namespace MvcAspNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
