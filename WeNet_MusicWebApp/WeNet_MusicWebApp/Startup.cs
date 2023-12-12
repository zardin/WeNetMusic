using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WeNet_MusicWebApp.Startup))]
namespace WeNet_MusicWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
