using System.ComponentModel.DataAnnotations.Schema;

public class CourseStudent
{
    public int CourseId { get; set; }
    public int StudentId { get; set; }

    public List<Student> lstStudents { get; set; } = null!;
    public List<Course> lstCourses { get; set; } = null!;
}