using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DogPlayDate.Startup))]
namespace DogPlayDate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
