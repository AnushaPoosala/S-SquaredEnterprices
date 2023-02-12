using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(S_SquaredEnterprices3.Startup))]
namespace S_SquaredEnterprices3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
