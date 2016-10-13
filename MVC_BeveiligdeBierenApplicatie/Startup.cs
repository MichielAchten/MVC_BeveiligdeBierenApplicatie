using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_BeveiligdeBierenApplicatie.Startup))]
namespace MVC_BeveiligdeBierenApplicatie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
