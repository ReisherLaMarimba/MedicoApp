using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MedicApp.Startup))]
namespace MedicApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
