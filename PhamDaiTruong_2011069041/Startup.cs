using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhamDaiTruong_2011069041.Startup))]
namespace PhamDaiTruong_2011069041
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
