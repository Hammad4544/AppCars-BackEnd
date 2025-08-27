using AppCar.infrustrcture.Irepos;
using AppCar.infrustrcture.Repos;
using AppCar.infrustrcture.UnitOfWork;
using AppCar.Service.IService;
using AppCar.Service.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.Service
{
    public static class ModuleServiceDependencies 
    {
        public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
        {

            
            services.AddScoped<ICarService, CarService>();
            return services;
        }
    }
}
