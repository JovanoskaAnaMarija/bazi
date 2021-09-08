using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BAZIPROEEKT.Startup))]
namespace BAZIPROEEKT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
