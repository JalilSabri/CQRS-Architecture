using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using CQRSArch.Persistence.Data.DBContext;
using CQRSArch.Persistence.Data.Repositories;

public class DependenciesContainer
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
}
