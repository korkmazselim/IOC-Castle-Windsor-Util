using Application.Abstract;
using Application.Repositories;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using System;
using System.Reflection;
using Models;
using Application;

namespace CastleWindsor
{
    public class Program
    {
        static void Main(string[] args)
        {
            Utils.IocUtil.InstanceWindsorContainer();

            var _CashSaleInstance =Utils.IocUtil.Resolve<ISaleInstance>("CashSaleInstance");
            var _WebSaleInstance =Utils.IocUtil.Resolve<ISaleInstance>("WebSaleInstance");
            _CashSaleInstance.WhoIAm();
            _WebSaleInstance.WhoIAm();

            Console.ReadKey();
        }
    }
}
