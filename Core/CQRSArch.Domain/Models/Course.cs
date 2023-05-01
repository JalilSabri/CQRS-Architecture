public class Course : BaseEntity
{
    public string CourseTitle { get; set; }
    public int? StudentId { get; set; }
    public CourseStudent? CourseStudents { get; set; }
}