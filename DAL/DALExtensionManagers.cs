using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    //Inject Our services
    public static class DALExtensionManagers
    {
        //Register Our Services to DI container
        public static IServiceCollection AddDalServices( this IServiceCollection services,Action<DbContextOptionsBuilder> options)
        {
           //Registering DbContext to Dependecy injection Container
            services.AddDbContext<PersonContext>(options);
            services.AddTransient<IPersonService, PersonService>();
            return services;
        }
    }
}
