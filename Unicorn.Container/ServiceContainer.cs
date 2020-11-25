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
            try
            {
                T result = _container.Resolve<T>();
                return result;
            }
            catch (Exception)
            {
            }

            return default;
        }

        public static T Resolve<T>(string uniqueName)
        {
            try
            {
                T result = _container.Resolve<T>(uniqueName);
                return result;
            }
            catch (Exception)
            {
            }

            return default;
        }

        public static IEnumerable<T> ResolveAll<T>()
        {
            try
            {
                IEnumerable<T> result = _container.ResolveAll<T>();
                return result;
            }
            catch (Exception)
            {
            }

            return null;
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
            _container.RegisterInstance(typeof(TFrom), instance, new ContainerControlledLifetimeManager());
        }

        public static void RegisterInstance<TFrom>(TFrom instance, string uniqueName)
        {
            _container.RegisterInstance(typeof(TFrom), uniqueName, instance, new ContainerControlledLifetimeManager());
        }

        public static void UnregisterInstance<TFrom>()
        {
            var registration = _container.Registrations.FirstOrDefault(r => r.RegisteredType.Equals(typeof(TFrom)));
            registration?.LifetimeManager?.RemoveValue();
        }
    }
}
