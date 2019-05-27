using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab21.Startup))]
namespace Lab21
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
