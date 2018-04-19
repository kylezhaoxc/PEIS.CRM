using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using Microsoft.Owin.FileSystems;
using Microsoft.Owin.StaticFiles;

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
            const string rootFolder = "shenyi";
            var filesys = new PhysicalFileSystem(rootFolder);
            var options = new FileServerOptions
            {
                EnableDefaultFiles = true,
                FileSystem = filesys
            };
            app.UseFileServer(options);

        }
    }
}