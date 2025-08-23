using AppCar.infrustrcture.Irepos;
using AppCar.infrustrcture.Repos;
using AppCar.infrustrcture.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.infrustrcture
{
    public static class ModuleInfrustrctureDependencies
    {
        public static IServiceCollection AddInfrustrctureDependencies(this IServiceCollection services) {
           
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork.UnitOfWork>();
            return services;
        }
    }
}
