using CQRSArch.Persistence.Data.DBContext;

namespace CQRSArch.Persistence.Data.Repositories
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        CQRSArchDBContext cqrsDbContext;

        public StudentRepository(CQRSArchDBContext cqrsDbContext) : base(cqrsDbContext)
        {
            this.cqrsDbContext = cqrsDbContext;
        }

        public Task<IReadOnlyList<CourseStudent>> GetCoursesByStudentIdAsync(int StudentId)
        {
           return  new CourseStudentRepository(CqrsDbContext).GetAllAsync();
        }
    }
}