using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        protected override IController GetControllerInstance(
            RequestContext requestContext, Type controllerType) =>
            controllerType != null ? (IController)m_typeResolver.Get(controllerType) : null;

        private ITypeResolver m_typeResolver = new NinjectTypeResolver();
    }
}