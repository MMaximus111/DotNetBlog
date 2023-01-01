using DotNetBlog.Application;
using DotNetBlog.Infrastructure;
using DotNetBlog.Infrastructure.DataBase;
using DotNetBlog.Infrastructure.DataBase.Repositories.Base;
using DotNetBlog.Web.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DotNetBlog.Web.Extensions;

public static class DependencyExtensions
{
    public static void RegisterDependencies(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        serviceCollection.AddMediatR(typeof(IApplicationAssemblyMarker).Assembly);
        serviceCollection.RegisterRepositories();
        serviceCollection.AddDbContext<BlogDbContext>(x => x.UseNpgsql(configuration.GetConnectionString("Postgres")));
        serviceCollection.AddScoped<ThemeProvider>();
    }

    private static void RegisterRepositories(this IServiceCollection serviceCollection)
    {
        Type[] types = typeof(IInfrastructureAssemblyMarker).Assembly
            .GetTypes()
            .Where(t => t is { IsClass: true, BaseType.IsGenericType: true }
                        && t.BaseType.GetGenericTypeDefinition() == typeof(RepositoryBase<>))
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
}