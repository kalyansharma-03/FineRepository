using FineTable.Application.Manager.Implementation;
using FineTable.Application.Manager.Interface;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FineTable.Application
{
    public static class ApplicationServices
    {
        public static IServiceCollection AddInApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IFineManager, FineManager>();
            services.AddScoped<IFineCollectionManager, FineCollectionManager>();

            return services;
        }
    }
}
