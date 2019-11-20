using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BandBook.Startup))]
namespace BandBook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
