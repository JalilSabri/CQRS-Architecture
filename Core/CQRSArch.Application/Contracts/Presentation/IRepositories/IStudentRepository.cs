public interface IStudentRepository : IBaseRepository<Student> 
{
    public Task<IReadOnlyList<CourseStudent>> GetCoursesByStudentIdAsync(int StudentId);
}