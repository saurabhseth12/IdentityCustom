using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityCustom.Startup))]
namespace IdentityCustom
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
