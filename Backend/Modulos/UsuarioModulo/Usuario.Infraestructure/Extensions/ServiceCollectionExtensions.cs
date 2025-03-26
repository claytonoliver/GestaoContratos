using Microsoft.Extensions.DependencyInjection;
using MediatR;
using System.Reflection;

namespace Usuario.Infraestucture.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMediatRWithAutoDiscovery(this IServiceCollection services)
        {
            var loadedAssemblies = AppDomain.CurrentDomain.GetAssemblies().ToList();

            var referencedAssemblies = Assembly.GetExecutingAssembly().GetReferencedAssemblies();

            foreach (var assemblyName in referencedAssemblies)
            {
                if (!loadedAssemblies.Any(a => a.FullName == assemblyName.FullName))
                {
                    loadedAssemblies.Add(Assembly.Load(assemblyName));
                }
            }

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(loadedAssemblies.ToArray()));

            return services;
        }
    }
}
