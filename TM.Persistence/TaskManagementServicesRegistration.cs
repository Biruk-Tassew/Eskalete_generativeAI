using TM.Application.Contracts.Persistence;
using TM.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM.Persistence
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TMDbContext>(opt =>
            opt.UseNpgsql(configuration.GetConnectionString("TMConnectionString")));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            
            return services;
        }
    }
}
