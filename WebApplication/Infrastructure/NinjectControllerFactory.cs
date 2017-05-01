using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using Domain.Abstract;
using Domain.Concrete;
using Domain.Entities;
using System.Web.Routing;

namespace WebApplication.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        public NinjectControllerFactory()
        {
            m_kernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(
            RequestContext requestContext, Type controllerType) =>
            controllerType != null ? (IController)m_kernel.Get(controllerType) : null;

        private IKernel m_kernel;

        private void AddBindings()
        {
            m_kernel.Bind(typeof(IRepository<>)).To(typeof(EFRepository<>));
        }
    }
}