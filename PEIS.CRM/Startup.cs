using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(PEIS.CRM.Startup))]

namespace PEIS.CRM
{
    public partial class Startup
    {
        public static HttpConfiguration HttpConfiguration { get; private set; }

        public void Configuration(IAppBuilder app)
        {
            Startup.HttpConfiguration = new System.Web.Http.HttpConfiguration();

            ConfigureAuth(app);
            ConfigureAutofac(app);

            // WebAPI call must come after Autofac
            // Autofac hooks into the HttpConfiguration settings
            ConfigureWebApi(app);

        }
    }
}