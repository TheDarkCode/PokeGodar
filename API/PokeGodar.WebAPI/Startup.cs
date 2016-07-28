using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(PokeGodar.WebAPI.Startup))]

namespace PokeGodar.WebAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
