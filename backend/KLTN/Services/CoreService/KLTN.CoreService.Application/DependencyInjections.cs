using KLTN.CoreService.Application.Applications;
using KLTN.CoreService.Application.Interfaces;
using KLTN.CoreService.Repository.Interfaces;
using KLTN.CoreService.Repository.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLTN.CoreService.Application
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddService(this IServiceCollection services)
        {
            services.AddScoped<IAuthApplication, AuthApplication>();

            return services;
        }
    }
}
