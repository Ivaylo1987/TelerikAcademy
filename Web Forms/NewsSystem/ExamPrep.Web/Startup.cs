using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExamPrep.Web.Startup))]
namespace ExamPrep.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
