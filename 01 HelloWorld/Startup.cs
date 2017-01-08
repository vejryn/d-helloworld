using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_01_HelloWorld.Startup))]
namespace _01_HelloWorld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
