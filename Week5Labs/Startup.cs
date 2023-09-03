using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week5Labs.Startup))]
namespace Week5Labs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
