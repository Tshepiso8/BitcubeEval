using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Section_2.Startup))]
namespace Section_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
