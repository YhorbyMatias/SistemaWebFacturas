using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemaWebFacturas.Startup))]
namespace SistemaWebFacturas
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
