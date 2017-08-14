using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UnitConverter.Startup))]
namespace UnitConverter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
