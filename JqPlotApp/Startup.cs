using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JqPlotApp.Startup))]
namespace JqPlotApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
