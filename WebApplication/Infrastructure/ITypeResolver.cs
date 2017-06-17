using System;

namespace WebApplication.Infrastructure
{
    public interface ITypeResolver
    {
        object Get(Type type);
    }
}
