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
        public void ConfigureWebApi(IAppBuilder app)
        {
            app.UseWebApi(Startup.HttpConfiguration);
            Startup.HttpConfiguration.MapHttpAttributeRoutes();
        }
    }
}