using CQRSArch.Persistence.Data.DBContext;

namespace CQRSArch.Persistence.Data.Repositories
{
    public class CourseStudentRepository : BaseRepository<CourseStudent>, ICourseStudentRepository
    {
        public CourseStudentRepository(CQRSArchDBContext cqrsDbContext) : base(cqrsDbContext)
        {
        }
    }
}
