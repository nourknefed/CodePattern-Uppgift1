using Autofac;

using KennelLibrary;
using KennelLibrary.animal;
using KennelLibrary.customer;
using KennelLibrary.menu;
using KennelLibrary.service;
using KennelLibrary.status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Kennel
{
    public class AFConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            
            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<Customer>();
            builder.RegisterType<Animal>();
            builder.RegisterType<Service>();




            builder.RegisterType<Customer>().As<ICustomer>();
            builder.RegisterType<CustomerManager>().As<ICustomerManager>();

            builder.RegisterType<Animal>().As<IAnimal>();
            builder.RegisterType<AnimalManager>().As<IAnimalManager>();
            builder.RegisterType<AnimalServiceManager>().As<IAnimalServiceManager>();

            builder.RegisterType<MenuItem>().As<IMenuItem>();
            builder.RegisterType<MenuManger>().As<IMenuManger>();
            builder.RegisterType<UserInputOutput>().As<IUserInputOutput>();

            builder.RegisterType<Service>().As<IService>();
            builder.RegisterType<Clean>().As<IClean>();
            builder.RegisterType<ClawClipping>().As<IClawClipping>();

       
            builder.RegisterType<StatusManager>().As<IStatusManager>();



            //builder.RegisterAssemblyTypes(Assembly.Load(nameof(KennelLibrary)))
            // .Where(t => t.Namespace.Contains("customer"))
            // .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name))
            // .AsImplementedInterfaces();


            //builder.RegisterAssemblyTypes(Assembly.Load(nameof(KennelLibrary)))
            //   .Where(t => t.Namespace.Contains("animal"))
            //   .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name))
            //   .AsImplementedInterfaces();

            //builder.RegisterAssemblyTypes(Assembly.Load(nameof(KennelLibrary)))
            //   .Where(t => t.Namespace.Contains("menu"))
            //   .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name))
            //   .AsImplementedInterfaces();

            //builder.RegisterAssemblyTypes(Assembly.Load(nameof(KennelLibrary)))
            //   .Where(t => t.Namespace.Contains("service"))
            //   .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name))
            //   .AsImplementedInterfaces();

            //builder.RegisterAssemblyTypes(Assembly.Load(nameof(KennelLibrary)))
            //   .Where(t => t.Namespace.Contains("status"))
            //   .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name))
            //   .AsImplementedInterfaces();

            return builder.Build();
        }
    }
}
