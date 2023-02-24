using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Ban.Application.Interfac;
using Microsoft.Extensions.Configuration;



namespace Ban.persistance
{
    public static  class DependencyInjection
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["DbConnection"];

            IBanContext _context;
            switch (config["DbType"])
            {
                case "InMemory":
                    {
                        services.AddDbContext<BanContext>(opt =>
                        {
                            opt.UseInMemoryDatabase("1");
                        });
                        break;
                    }
                case "Postgres":
                    {
                        services.AddDbContext<BanContext>(options =>
                        {
                           options.UseNpgsql(connectionString);
                        });
                        break;
                    }
                case "SQLite":
                    {
                        services.AddDbContext<BanContext>(options =>
                        {
                            options.UseSqlite(connectionString);
                        });
                        break;
                    }
                default:
                    {
                        throw new Exception();
                    }
            }

            services.AddScoped<IBanContext>(provider => provider.GetService<BanContext>());
            return services;
        }
    }
}
