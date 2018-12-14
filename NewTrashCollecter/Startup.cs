using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewTrashCollecter.Startup))]
namespace NewTrashCollecter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
