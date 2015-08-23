using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSharpOnlineMVC.Startup))]
namespace CSharpOnlineMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
