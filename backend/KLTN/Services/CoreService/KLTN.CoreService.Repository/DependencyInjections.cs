using KLTN.CoreService.Repository.Interfaces;
using KLTN.CoreService.Repository.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLTN.CoreService.Repository
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {

            services.AddScoped<IAccountRepository, AccountRepository>();

            return services;
        }
    }
}
