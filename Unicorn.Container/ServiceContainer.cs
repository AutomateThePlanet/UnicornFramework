using System;
using System.Collections.Generic;
using System.Linq;
using Unity;
using Unity.Lifetime;

namespace Unicorn
{
    public static class ServiceContainer
    {
        private static readonly IUnityContainer _container;
        private static readonly object _lockObject = new object();

        static ServiceContainer()
        {
            _container = new UnityContainer();
        }

        public static T Resolve<T>()
        {
            T result = _container.Resolve<T>();
            return result;
        }

        public static IEnumerable<T> ResolveAll<T>()
        {
            IEnumerable<T> result = _container.ResolveAll<T>();
            return result;
        }

        public static void RegisterType<TFrom, TTo>(string name)
           where TTo : TFrom
        {
            _container.RegisterType<TFrom, TTo>(name);
        }

        public static void RegisterType<TFrom, TTo>()
            where TTo : TFrom
        {
            lock (_lockObject)
            {
                _container.RegisterType<TFrom, TTo>();
            }
        }

        public static void RegisterInstance<TFrom>(TFrom instance)
        {
            _container.RegisterInstance(instance, new ContainerControlledLifetimeManager());
        }

        public static void UnregisterInstance<TFrom>()
        {
            var registration = _container.Registrations.FirstOrDefault(r => r.RegisteredType.Equals(typeof(TFrom)));
            registration.LifetimeManager.RemoveValue();
        }
    }
}
