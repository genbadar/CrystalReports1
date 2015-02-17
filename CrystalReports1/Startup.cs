using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrystalReports1.Startup))]
namespace CrystalReports1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
