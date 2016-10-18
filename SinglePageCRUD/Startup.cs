using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SinglePageCRUD.Startup))]
namespace SinglePageCRUD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
