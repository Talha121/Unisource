using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Unisource.Startup))]
namespace Unisource
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
