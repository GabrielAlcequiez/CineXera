using CineXera.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CineXera.Persistence
{
    public static class ServicesRegistration
    {
        public static void AddInfrastructurePersistence(this IServiceCollection services, IConfiguration config)
        {
            #region dbcontext

            string connectionString = config.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("La cadena de conexión DefaultConnection no está configurada.");

            services.AddDbContext<AppDbContext>((opt) =>
            {
                opt.UseSqlServer(connectionString, m => m.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName));
            },
            ServiceLifetime.Scoped,
            ServiceLifetime.Scoped);
            
            #endregion

            #region repositories

            #endregion
        }
    }
}