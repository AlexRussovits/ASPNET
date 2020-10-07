using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Phones2020_Russovits.Startup))]
namespace Phones2020_Russovits
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
