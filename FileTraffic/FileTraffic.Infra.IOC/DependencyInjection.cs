using FileTraffic.Application.Mappings;
using FileTraffic.Domain.Interfaces;
using FileTraffic.Infra.Data.Context;
using FileTraffic.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTraffic.Infra.IOC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
        IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
          options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"
         ), b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));


            services.AddScoped<IArchiveRepository, ArchiveRepository>();
            services.AddScoped<IFolderRepository, SystemReferenceRepository>();
            services.AddAutoMapper(typeof(DomainToDTOProfile));

            return services;
        }
    }
}
