using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

namespace OrdinaryGeeksArcadeMVCForms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
