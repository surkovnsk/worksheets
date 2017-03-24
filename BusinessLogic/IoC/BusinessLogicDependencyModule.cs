using Autofac;
using BusinessLogic.Services;
using BusinessLogic.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.IoC
{
    public class BusinessLogicDependencyModule
        :Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MethodService>().As<IMethodService>()
                .InstancePerRequest();
        }
    }
}
