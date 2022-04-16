using Lets.Application.Abstract;
using Lets.Application.Repositories;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using System;
using System.Reflection;
using Lets.Models;
using Lets.Application;
using Lets.Utils;

namespace CastleWindsor
{
    public class Program
    {
        static void Main(string[] args)
        {
            IocUtil.InstanceWindsorContainer();

            var _CashSaleInstance = IocUtil.Resolve<ISaleInstance>("CashSaleInstance");
            var _WebSaleInstance = IocUtil.Resolve<ISaleInstance>("WebSaleInstance");
            _CashSaleInstance.WhoIAm();
            _WebSaleInstance.WhoIAm();

            Console.ReadKey();
        }
    }
}
