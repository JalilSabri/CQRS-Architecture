using CQRSArch.Persistence.Data.DBContext;

namespace CQRSArch.Persistence.Data.Repositories
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public StudentRepository(CQRSArchDBContext cqrsDbContext) : base(cqrsDbContext)
        {
        }
    }
}