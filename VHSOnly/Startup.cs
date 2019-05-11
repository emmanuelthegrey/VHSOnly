using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VHSOnly.Startup))]
namespace VHSOnly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
