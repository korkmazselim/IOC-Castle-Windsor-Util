using Lets.Application;
using Lets.Application.Abstract;
using Lets.Application.Repositories;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Text;
using Castle.Windsor.Installer;
using Castle.Core.Resource;
using Castle.Windsor.Configuration.Interpreters;

namespace Lets.Utils
{
    public static class IocUtil
    {
        private static IWindsorContainer _WindsorContainer;
        public static void InstanceWindsorContainer() 
        {
            if (_WindsorContainer == null)
            {
                _WindsorContainer = new WindsorContainer();
                _WindsorContainer.Install(new RepositoryInstaller());

                _WindsorContainer.Register(
                    Component.For<ISaleRepository>().
                    ImplementedBy<WebSaleRepository>().
                    LifestyleTransient());

                _WindsorContainer.Register(
                    Component.For<ISaleRepository>().
                    ImplementedBy<CashSaleRepository>().
                    LifestyleTransient());

                _WindsorContainer.Register(
                    Component.For<ISaleInstance>().
                    ImplementedBy<CashSaleInstance>().
                    DependsOn(Dependency.OnComponent<ISaleRepository, CashSaleRepository>()).
                    Named("CashSaleInstance"));

                _WindsorContainer.Register(
                    Component.For<ISaleInstance>().
                    ImplementedBy<WebSaleInstance>().
                    DependsOn(Dependency.OnComponent<ISaleRepository, WebSaleRepository>()).
                    Named("WebSaleInstance"));
            }
        }

        public static T Resolve<T>() where T:class
        {
            return _WindsorContainer.Resolve<T>();
        }
        public static T Resolve<T>(string Named) where T : class
        {
            return _WindsorContainer.Resolve<T>(Named);
        }
        public static T Instance<T>() where T:class
        {
            if (!_WindsorContainer.Kernel.HasComponent(typeof(T)))
                _WindsorContainer.Register(Component.For<T>());
            return _WindsorContainer.Resolve<T>();
        }

    }
}
