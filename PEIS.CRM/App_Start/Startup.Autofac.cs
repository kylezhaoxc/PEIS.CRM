using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace PEIS.CRM
{
    public partial class Startup
    {
        public void ConfigureAutofac(IAppBuilder app)
        {

            var builder = new ContainerBuilder();

            // register the class that sets up bindings between interfaces and implementation
            builder.RegisterModule(new WebAutofacModule());

            // register Autofac w/ the MVC application
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // Register the WebAPI controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            var container = builder.Build();

            // Setup Autofac dependency resolver for WebAPI
            HttpConfiguration.DependencyResolver = new Autofac.Integration.WebApi.AutofacWebApiDependencyResolver(container);

            // 1.  Register the Autofac middleware 
            // 2.  Register Autofac Web API middleware,
            // 3.  Register the standard Web API middleware (this call is made in the Startup.WebApi.cs)
            app.UseAutofacMiddleware(container);
            app.UseAutofacWebApi(HttpConfiguration);
        }
    }
}