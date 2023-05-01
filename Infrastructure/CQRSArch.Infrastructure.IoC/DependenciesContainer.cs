using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using CQRSArch.Persistence.Data.DBContext;
using CQRSArch.Persistence.Data.Repositories;
using Microsoft.Extensions.Configuration;

public static class DependenciesContainer
{
    public static void InjectServices(IServiceCollection services, string cnnectionString)
    {
        services.AddDbContext<CQRSArchDBContext>(options =>
        {
            options.UseSqlServer(cnnectionString);
        });

        services.AddScoped<IStudentRepository, StudentRepository>();
        services.AddScoped<ICourseRepository, CourseRepository>();
        services.AddScoped<ICourseStudentRepository, CourseStudentRepository>();
        services.AddAutoMapper(typeof(CustomeProfile));
    }

    public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<CQRSArchDBContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("CQRSArchConnectionString"));
        });

        //services.AddScoped<IGenericRepository<>,GenericRepository<>>();//Error
        services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        services.AddScoped<IStudentRepository, StudentRepository>();
        services.AddScoped<ICourseRepository, CourseRepository>();
        services.AddScoped<ICourseStudentRepository, CourseStudentRepository>();
        services.AddAutoMapper(typeof(CustomeProfile));
    }
}
