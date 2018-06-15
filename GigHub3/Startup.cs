using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GigHub3.Startup))]
namespace GigHub3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
