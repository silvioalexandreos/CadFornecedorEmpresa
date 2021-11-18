using CadEmpresaFornecedor.Services.Base;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CadEmpresaFornecedor.Services.Helpers
{
    public static class ServicesInjector
    {
        public static IServiceCollection AddServices(this IServiceCollection services, Assembly servicesAssembly)
        {
            var concreteServices = servicesAssembly.GetExportedTypes()
                                 .Where(c => c.IsClass && !c.IsAbstract && c.IsPublic && typeof(Service).IsAssignableFrom(c));

            foreach (var serviceType in concreteServices)
            {
                services.AddScoped(serviceType);
            }

            return services;
        }
    }
}
