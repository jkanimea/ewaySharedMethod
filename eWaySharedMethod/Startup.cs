using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eWaySharedMethod.Startup))]
namespace eWaySharedMethod
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
