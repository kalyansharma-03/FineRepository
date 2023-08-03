using FineTable.Domain.Interface;
using FineTable.Infrastructure.Repository;
using FineTable.Infrastructure.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FineTable.Infrastructure
{
    public static class InfrastructureServices
    {
        public static IServiceCollection AddInInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DatabaseContext>(o => o.UseNpgsql(configuration["ConnectionStrings:DefaultConnection"]));
            services.AddScoped<IServiceFactory, ServiceFactory>();
            services.AddScoped<IFineService,FineService>();
            services.AddScoped<IFineCollectionService,FineCollectionService>();
            

            return services;
        }
    }
}
