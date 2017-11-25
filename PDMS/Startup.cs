using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PDMS.Startup))]
namespace PDMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
