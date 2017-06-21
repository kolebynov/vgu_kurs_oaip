using System;
using Ninject;
using Domain.Abstract;
using Domain.Concrete;
using System.Collections.Generic;
using FormApp.Forms;
using Domain.Model;

namespace FormApp.Infrastructure
{
    public static class Factory
    {
        public static T GetInstance<T>(bool useCache = false)
        {
            return (T)GetInstance(typeof(T), useCache);
        }
        public static object GetInstance(Type type, bool useCache = false)
        {
            object result = null;
            if (!useCache)
                result = _kernel.Get(type);
            else if (!_cache.TryGetValue(type, out result))
            {
                result = _kernel.Get(type);
                _cache[type] = result;
            }
            return result;
        }

        static Factory()
        {
            RegisterBindings();
        }

        private static IKernel _kernel = new StandardKernel();
        private static Dictionary<Type, object> _cache = new Dictionary<Type, object>();

        private static void RegisterBindings()
        {
            _kernel.Bind(typeof(IRepository<>)).To(typeof(EFRepository<>));
            _kernel.Bind<BaseEditForm<Contact>>().To<ContactEditForm>();
            _kernel.Bind<BaseEditForm<BookedTour>>().To<BookedTourEditForm>();
            _kernel.Bind<BaseEditForm<Tour>>().To<TourEditForm>();
            _kernel.Bind(typeof(IDataHelper<>)).To(typeof(DataHelper<>));
        }
    }
}
