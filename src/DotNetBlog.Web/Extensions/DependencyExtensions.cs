using DotNetBlog.Infrastructure;
using DotNetBlog.Infrastructure.DataBase.Repositories.Base;

namespace DotNetBlog.Web.Extensions;

public static class DependencyExtensions
{
    public static void RegisterDependencies(this IServiceCollection serviceCollection)
    {
        serviceCollection.RegisterRepositories();
        serviceCollection.RegisterDbMappings();
    }

    private static void RegisterRepositories(this IServiceCollection serviceCollection)
    {
        Type[] types = typeof(IInfrastructureAssemblyMarker).Assembly
            .GetTypes()
            .Where(t => t is { IsClass: true, BaseType: { } } && t.BaseType == typeof(RepositoryBase<>))
            .ToArray();

        foreach (Type type in types)
        {
            Type? interfaceType = type.GetInterfaces().FirstOrDefault(x => x.IsGenericType == false);

            if (interfaceType != null)
            {
                serviceCollection.AddScoped(interfaceType, type);
            }
        }
    }

    private static void RegisterDbMappings(this IServiceCollection serviceCollection)
    {
        
    }
}