using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AjaxImageDemo.Startup))]
namespace AjaxImageDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
