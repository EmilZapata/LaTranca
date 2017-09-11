using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LaTranca.Startup))]
namespace LaTranca
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
