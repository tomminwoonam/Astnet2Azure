using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aspnet2Azure.Startup))]
namespace Aspnet2Azure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
