using System.ComponentModel.DataAnnotations.Schema;

public class Student : BaseEntity
{
    public string? FirstName { get; set; }
    public string LastName { get; set; }
    public string EntryDate { get; set; }
    public int? CourseId { get; set; }
    public CourseStudent StudentCourses { get; set;}
}