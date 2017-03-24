﻿using Autofac;
using DataAccess.Context;
using DataAccess.Repositories;
using DataAccess.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IoC
{
    public class DataAccessDependencyModule
        :Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<WorkSheetsDbContext>().Named<DbContext>("DataContext").InstancePerRequest();
            builder.RegisterType<MethodRepository>().As<IMethodRepository>()
              .WithParameter((pi, c) => pi.Name == "context", (pi, c) => (WorkSheetsDbContext)c.ResolveNamed<DbContext>("DataContext"))
              .InstancePerRequest();
        }

        }

}
