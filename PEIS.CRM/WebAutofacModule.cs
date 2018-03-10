using Autofac;
using Infrastructure.Logic;
using Infrastructure.Logic.Impl;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PEIS.CRM
{
    public sealed class WebAutofacModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CustomerLogic>().As<ICustomerLogic>();
            builder.RegisterType<SqlTableRepository>().As<ISqlTableRepository>();
        }
    }
}