using Lets.Application.Repositories;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Lets.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lets.Utils
{
    class RepositoryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromAssemblyNamed("Lets.Application"));
        }
    }
}
