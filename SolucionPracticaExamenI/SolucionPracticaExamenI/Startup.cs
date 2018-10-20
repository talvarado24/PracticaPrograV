using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SolucionPracticaExamenI.Startup))]
namespace SolucionPracticaExamenI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
