using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyCollege.Startup))]
namespace MyCollege
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
