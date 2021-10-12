using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Database_Existing.Startup))]
namespace Database_Existing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
