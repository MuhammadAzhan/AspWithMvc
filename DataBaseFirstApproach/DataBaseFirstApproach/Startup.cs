using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DataBaseFirstApproach.Startup))]
namespace DataBaseFirstApproach
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
