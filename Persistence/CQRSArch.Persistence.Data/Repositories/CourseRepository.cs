using CQRSArch.Persistence.Data.DBContext;

namespace CQRSArch.Persistence.Data.Repositories
{
    public class CourseRepository : BaseRepository<Course>, ICourseRepository
    {
        public CourseRepository(CQRSArchDBContext cqrsDbContext) : base(cqrsDbContext)
        {
        }
    }
}
