using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Empleado.BL.Automapper;
using Empleado.BL.Interfaces;
using Empleado.DAL.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Empleado.BL.Services
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServiceConnector(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutomapperProfile).Assembly);
            services.AddTransient<IEmpleadoService, EmpleadoService>();
            services.AddRepositoryConnector();
            return services;
        }
    }
}
