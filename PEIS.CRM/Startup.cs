using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace PEIS.CRM
{
    public partial class Startup
    {
        public static HttpConfiguration HttpConfiguration { get; private set; }

        public void Configuration(IAppBuilder app)
        {
            Startup.HttpConfiguration = new System.Web.Http.HttpConfiguration();
            ConfigureAutofac(app);
            ConfigureWebApi(app);
        }
    }
}
