using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FilmsJPTVR18_Russovits.Startup))]
namespace FilmsJPTVR18_Russovits
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
