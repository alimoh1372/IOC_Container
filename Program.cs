using System;
using Resolver_IOC_Container;
using Unity;
using Unity.Injection;

namespace IOC_Container
{
    class Program
    {
        static void Main(string[] args)
        {
            //var shopper = new Shopper(new Visa());
            //shopper.charge();

            //var resolver = new Resolver();

            ////تنظیمات اولیه
            //resolver.Register<Shopper, Shopper>();
            //resolver.Register<ICreditCard, Visa>();

            ////تزریق وابستگی‌ها و وهله سازی
            //var shopper = resolver.Resolve<Shopper>();
            //shopper.charge();

            var container = new UnityContainer();
            container.RegisterType<ICreditCard, MasterCard>(new InjectionProperty("Ali","Alimohammadzade"));


            var shopper = container.Resolve<Shopper>();

            shopper.charge();
            Console.WriteLine(shopper.Ali);
            Console.ReadKey();
        }
    }
}
