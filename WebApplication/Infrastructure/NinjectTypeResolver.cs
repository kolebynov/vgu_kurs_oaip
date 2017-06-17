using Domain.Abstract;
using Domain.Concrete;
using Ninject;
using System;

namespace WebApplication.Infrastructure
{
    public class NinjectTypeResolver : ITypeResolver
    {
        public NinjectTypeResolver()
        {
            RegisterBindings();
        }

        public object Get(Type type)
        {
            return m_kernel.Get(type);
        }

        private IKernel m_kernel = new StandardKernel();

        private void RegisterBindings()
        {
            m_kernel.Bind(typeof(IRepository<>)).To(typeof(EFRepository<>));
            m_kernel.Bind<ITypeResolver>().To<NinjectTypeResolver>();
        }
    }
}