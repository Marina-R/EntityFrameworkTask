using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EFTask.Startup))]
namespace EFTask
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
