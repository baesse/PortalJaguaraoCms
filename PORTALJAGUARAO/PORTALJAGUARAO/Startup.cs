using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PORTALJAGUARAO.Startup))]
namespace PORTALJAGUARAO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
