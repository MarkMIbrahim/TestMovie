using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestMovie.Startup))]
namespace TestMovie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
